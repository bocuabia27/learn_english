package com.example.learn_eng.controller;

import com.example.learn_eng.Service.WordChainResponse;
import com.example.learn_eng.Service.WordChainService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.messaging.handler.annotation.MessageMapping;
import org.springframework.messaging.handler.annotation.Payload;
import org.springframework.messaging.simp.SimpMessagingTemplate;
import org.springframework.stereotype.Controller;

import static com.example.learn_eng.Jwt.JwtChannelInterceptor.logger;

@Controller
public class WordChainWebSocketController {
    @Autowired
    private SimpMessagingTemplate messagingTemplate;

    @Autowired
    private WordChainService wordChainService;

    @MessageMapping("/game/play")
    public void playOnline(@Payload WordChainMessage message) {
        logger.debug("Received message: word={}, gameSessionId={}, turn={}, sessionPassword={}, username={}",
                message.getWord(), message.getGameSessionId(), message.getTurn(), message.getSessionPassword(), message.getUsername());
        try {
            WordChainResponse response = wordChainService.playOnline(
                    message.getWord(),
                    message.getGameSessionId(),
                    message.getTurn(),
                    message.getSessionPassword(),
                    message.getUsername()
            );
            logger.debug("Sending response to /topic/game/{}: {}", message.getGameSessionId(), response);
            messagingTemplate.convertAndSend(
                    "/topic/game/" + message.getGameSessionId(),
                    response
            );
        } catch (Exception e) {
            logger.error("Error processing message: {}", e.getMessage(), e);
        }
    }

    // Đánh dấu WordChainMessage là static
    public static class WordChainMessage {
        private String word;
        private String gameSessionId;
        private int turn;
        private String sessionPassword;
        private String username; // Thêm trường username

        public WordChainMessage() {
        }

        public WordChainMessage(String word, String gameSessionId, int turn, String sessionPassword, String username) {
            this.word = word;
            this.gameSessionId = gameSessionId;
            this.turn = turn;
            this.sessionPassword = sessionPassword;
            this.username = username;
        }

        // Getters và Setters
        public String getWord() {
            return word;
        }

        public void setWord(String word) {
            this.word = word;
        }

        public String getGameSessionId() {
            return gameSessionId;
        }

        public void setGameSessionId(String gameSessionId) {
            this.gameSessionId = gameSessionId;
        }

        public int getTurn() {
            return turn;
        }

        public void setTurn(int turn) {
            this.turn = turn;
        }

        public String getSessionPassword() {
            return sessionPassword;
        }

        public void setSessionPassword(String sessionPassword) {
            this.sessionPassword = sessionPassword;
        }

        public String getUsername() {
            return username;
        } // Getter

        public void setUsername(String username) {
            this.username = username;
        } // Setter
    }
}

