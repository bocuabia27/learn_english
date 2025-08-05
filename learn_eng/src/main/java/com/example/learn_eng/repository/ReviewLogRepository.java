package com.example.learn_eng.repository;

import com.example.learn_eng.entity.ReviewLog;
import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;

public interface ReviewLogRepository extends JpaRepository<ReviewLog, Long> {
    List<ReviewLog> findByUser_Id(Long userId);
    List<ReviewLog> findByVocabId(Long vocabId);
}
