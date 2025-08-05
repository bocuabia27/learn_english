package com.example.learn_eng.repository;

import com.example.learn_eng.entity.GameSession;
import org.springframework.data.jpa.repository.EntityGraph;
import org.springframework.data.jpa.repository.JpaRepository;

public interface GameSessionRepository extends JpaRepository<GameSession, Long> {
    @EntityGraph(attributePaths = {"players"})
    GameSession findBySessionId(String sessionId);
}