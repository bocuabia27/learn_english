package com.example.learn_eng.Service;

import com.example.learn_eng.entity.ActivityLog;
import com.example.learn_eng.entity.User;
import com.example.learn_eng.repository.ActivityLogRepository;
import com.example.learn_eng.repository.UserRepository;
import org.springframework.stereotype.Service;

@Service
public class ActivityLogService {
    private final ActivityLogRepository activityLogRepository;
    private final UserRepository userRepository;

    public ActivityLogService(ActivityLogRepository activityLogRepository, UserRepository userRepository) {
        this.activityLogRepository = activityLogRepository;
        this.userRepository = userRepository;
    }

    public ActivityLog log(Long userId, String action, String details) {
        User user = userRepository.findById(userId)
                .orElseThrow(() -> new RuntimeException("User not found"));

        ActivityLog log = new ActivityLog();
        log.setUser(user);
        log.setAction(action);
        log.setDetails(details);
        return activityLogRepository.save(log);
    }
}
