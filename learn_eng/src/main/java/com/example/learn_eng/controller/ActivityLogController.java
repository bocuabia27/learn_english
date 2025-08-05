package com.example.learn_eng.controller;

import com.example.learn_eng.entity.ActivityLog;
import com.example.learn_eng.Service.ActivityLogService;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/activity")
public class ActivityLogController {

    private final ActivityLogService activityLogService;

    public ActivityLogController(ActivityLogService activityLogService) {
        this.activityLogService = activityLogService;
    }

    @PostMapping("/log")
    public ActivityLog logAction(@RequestParam Long userId,
                                 @RequestParam String action,
                                 @RequestParam String details) {
        return activityLogService.log(userId, action, details);
    }
}
