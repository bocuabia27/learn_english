package com.example.btqlxe.controller;

import com.example.btqlxe.DTO.UserDTO;
import com.example.btqlxe.entity.User;
import com.example.btqlxe.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/users")
public class UserController {

    @Autowired
    private UserService userService;

    @Autowired
    private BCryptPasswordEncoder passwordEncoder;

    @PostMapping("/register")
    public ResponseEntity<?> registerUser(@RequestBody UserDTO userDTO) {
        if (userService.existsByUsername(userDTO.getUsername())) {
            return ResponseEntity.badRequest().body("Username is already taken!");
        }

        // Tạo người dùng mới
        User newUser = new User();
        newUser.setUsername(userDTO.getUsername());
        newUser.setPassword(passwordEncoder.encode(userDTO.getPassword())); // Mã hóa mật khẩu
        userService.saveUser(newUser);

        return ResponseEntity.ok("User registered successfully!"); // Trả về thông báo thành công
    }

    @PostMapping("/login")
    public ResponseEntity<User> loginUser(@RequestParam String username, @RequestParam String password) {
        User user = userService.loginUser(username, password);
        if (user != null) {
            return ResponseEntity.ok(user); // Trả về người dùng nếu đăng nhập thành công
        }
        return ResponseEntity.status(401).body(null); // Unauthorized
    }
}
