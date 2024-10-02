package com.example.btqlxe.service;

import com.example.btqlxe.entity.User;
import com.example.btqlxe.repository.USerRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

@Service
public class UserServiceImpl implements UserService {

    @Autowired
    private USerRepository uSerRepository;

    @Autowired
    private BCryptPasswordEncoder passwordEncoder;

    @Override
    public boolean existsByUsername(String username) {
        return uSerRepository.existsByUsername(username);
    }

    @Override
    public void saveUser(User user) {
        uSerRepository.save(user);
    }

    @Override
    public User findUserByUsername(String username) {
        return uSerRepository.findByUsername(username);
    }

    @Override
    public User loginUser(String username, String password) {
        User user = findUserByUsername(username);
        if (user != null && passwordEncoder.matches(password, user.getPassword())) {
            return user; // Trả về người dùng nếu đăng nhập thành công
        }
        return null; // Trả về null nếu không tìm thấy người dùng hoặc mật khẩu không đúng
    }
}
