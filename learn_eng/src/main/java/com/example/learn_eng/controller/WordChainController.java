package com.example.learn_eng.controller;

import com.example.learn_eng.entity.GameSession;
import com.example.learn_eng.Service.WordChainResponse;
import com.example.learn_eng.Service.WordChainService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/game")
public class WordChainController {

    @Autowired
    private WordChainService wordChainService;

    @PostMapping("/play/bot")
    @PreAuthorize("hasAnyRole('USER', 'ADMIN')")
    public ResponseEntity<WordChainResponse> playWithBot(@RequestBody WordChainRequest request) {
        String gameSessionId = request.getGameSessionId() != null ?
                request.getGameSessionId() : java.util.UUID.randomUUID().toString();
        WordChainResponse response = wordChainService.playWithBot(
                request.getWord(), gameSessionId, request.getTurn());
        return ResponseEntity.ok(response);
    }

    @PostMapping("/create-session")
    @PreAuthorize("hasAnyRole('USER', 'ADMIN')")
    public ResponseEntity<GameSession> createGameSession(@RequestBody GameSessionRequest request) {
        GameSession session = wordChainService.createGameSession(request.getPassword());
        return ResponseEntity.ok(session);
    }
}

class WordChainRequest {
    private String word;
    private String gameSessionId;
    private int turn;

    public String getWord() { return word; }
    public void setWord(String word) { this.word = word; }
    public String getGameSessionId() { return gameSessionId; }
    public void setGameSessionId(String gameSessionId) { this.gameSessionId = gameSessionId; }
    public int getTurn() { return turn; }
    public void setTurn(int turn) { this.turn = turn; }
}

class GameSessionRequest {
    private String password;

    public String getPassword() { return password; }
    public void setPassword(String password) { this.password = password; }
}
