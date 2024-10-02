package com.example.btqlxe.service;

import com.example.btqlxe.entity.User;

public interface UserService {
    boolean existsByUsername(String username);
    void saveUser(User user);
    User findUserByUsername(String username);
    User loginUser(String username, String password);

}
