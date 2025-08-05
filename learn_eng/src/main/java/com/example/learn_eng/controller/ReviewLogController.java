package com.example.learn_eng.controller;

import com.example.learn_eng.entity.ReviewLog;
import com.example.learn_eng.Service.ReviewLogService;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/review")
public class ReviewLogController {

    private final ReviewLogService reviewLogService;

    public ReviewLogController(ReviewLogService reviewLogService) {
        this.reviewLogService = reviewLogService;
    }

    @PostMapping("/log")
    public ReviewLog logReview(@RequestParam Long userId,
                               @RequestParam Long vocabId,
                               @RequestParam boolean remembered) {
        return reviewLogService.logReview(userId, vocabId, remembered);
    }

    @GetMapping("/user")
    public List<ReviewLog> getUserReviews(@RequestParam Long userId) {
        return reviewLogService.getUserReviews(userId);
    }
}
