 package com.example.learn_eng.Jwt;

import com.example.learn_eng.Jwt.JwtUtil;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.messaging.Message;
import org.springframework.messaging.MessageChannel;
import org.springframework.messaging.simp.stomp.StompCommand;
import org.springframework.messaging.simp.stomp.StompHeaderAccessor;
import org.springframework.messaging.support.ChannelInterceptor;
import org.springframework.messaging.support.MessageHeaderAccessor;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.context.SecurityContextHolder;

import java.util.Collections;

public class JwtChannelInterceptor implements ChannelInterceptor {

    public static final Logger logger = LoggerFactory.getLogger(JwtChannelInterceptor.class);
    private final JwtUtil jwtUtil;

    public JwtChannelInterceptor(JwtUtil jwtUtil) {
        this.jwtUtil = jwtUtil;
    }

    @Override
    public Message<?> preSend(Message<?> message, MessageChannel channel) {
        StompHeaderAccessor accessor = MessageHeaderAccessor.getAccessor(message, StompHeaderAccessor.class);

        if (StompCommand.CONNECT.equals(accessor.getCommand())) {
            String authHeader = accessor.getFirstNativeHeader("Authorization");
            logger.debug("Received Authorization header: {}", authHeader);
            if (authHeader != null && authHeader.startsWith("Bearer ")) {
                String jwt = authHeader.substring(7);
                logger.debug("Extracted JWT: {}", jwt);
                String username = jwtUtil.extractUsername(jwt);
                logger.debug("Extracted username: {}", username);
                if (username != null && jwtUtil.validateToken(jwt, username)) {
                    String role = jwtUtil.extractRole(jwt);
                    logger.debug("Extracted role: {}", role);
                    UsernamePasswordAuthenticationToken auth = new UsernamePasswordAuthenticationToken(
                            username, null, Collections.singletonList(new SimpleGrantedAuthority(role)));
                    SecurityContextHolder.getContext().setAuthentication(auth);
                    accessor.setUser(auth);
                } else {
                    logger.error("Invalid JWT token for username: {}", username);
                    throw new SecurityException("Invalid JWT token");
                }
            } else {
                logger.error("Missing or invalid Authorization header: {}", authHeader);
                throw new SecurityException("Missing or invalid Authorization header");
            }
        }
        return message;
    }

}