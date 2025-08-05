package com.example.learn_eng.repository;

import com.example.learn_eng.entity.WordChainHistory;
import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;

public interface WordChainHistoryRepository extends JpaRepository<WordChainHistory, Long> {
    WordChainHistory findTopByGameSessionIdOrderByTurnDesc(String gameSessionId);
    List<WordChainHistory> findByUser_Id(Long userId);
    ;
}
