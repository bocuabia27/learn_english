package com.example.learn_eng.Service;

import com.example.learn_eng.entity.ReviewLog;
import com.example.learn_eng.entity.User;
import com.example.learn_eng.entity.Vocab;
import com.example.learn_eng.repository.ReviewLogRepository;
import com.example.learn_eng.repository.UserRepository;
import com.example.learn_eng.repository.VocabRepository;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;

@Service
public class ReviewLogService {
    private final ReviewLogRepository reviewLogRepository;
    private final UserRepository userRepository;
    private final VocabRepository vocabRepository;

    public ReviewLogService(
            ReviewLogRepository reviewLogRepository,
            UserRepository userRepository,
            VocabRepository vocabRepository) {
        this.reviewLogRepository = reviewLogRepository;
        this.userRepository = userRepository;
        this.vocabRepository = vocabRepository;
    }

    public ReviewLog logReview(Long userId, Long vocabId, boolean remembered) {
        User user = userRepository.findById(userId)
                .orElseThrow(() -> new RuntimeException("User not found"));
        Vocab vocab = vocabRepository.findById(vocabId)
                .orElseThrow(() -> new RuntimeException("Vocab not found"));

        ReviewLog log = new ReviewLog();
        log.setUser(user);
        log.setVocab(vocab);
        log.setReviewDate(LocalDateTime.now());
        log.setRemembered(remembered);
        return reviewLogRepository.save(log);
    }

    public List<ReviewLog> getUserReviews(Long userId) {
        return reviewLogRepository.findByUser_Id(userId);
    }
}
