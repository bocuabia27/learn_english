package com.example.learn_eng.Service;

import com.example.learn_eng.entity.GameSession;
import com.example.learn_eng.entity.User;
import com.example.learn_eng.entity.Vocab;
import com.example.learn_eng.entity.WordChainHistory;
import com.example.learn_eng.repository.GameSessionRepository;
import com.example.learn_eng.repository.UserRepository;
import com.example.learn_eng.repository.VocabRepository;
import com.example.learn_eng.repository.WordChainHistoryRepository;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Random;
import java.util.UUID;

import static com.example.learn_eng.Jwt.JwtChannelInterceptor.logger;

@Service
public class WordChainService {

    @Autowired
    private VocabRepository vocabRepository;

    @Autowired
    private WordChainHistoryRepository wordChainHistoryRepository;

    @Autowired
    private UserRepository userRepository;

    @Autowired
    private GameSessionRepository gameSessionRepository;

    @Autowired
    private PasswordEncoder passwordEncoder;

    // Lấy người dùng hiện tại từ SecurityContext
    private User getCurrentUser() {
        String username = SecurityContextHolder.getContext().getAuthentication().getName();
        return userRepository.findByUsername(username)
                .orElseThrow(() -> new RuntimeException("Không tìm thấy người dùng"));
    }

    // Chơi với máy
    public WordChainResponse playWithBot(String userWord, String gameSessionId, int turn) {
        User user = getCurrentUser();

        // Kiểm tra từ người dùng có trong vocab không
        Vocab userVocab = vocabRepository.findByUserIdAndEnglishWordIgnoreCase(user.getId(), userWord);
        if (userVocab == null) {
            return new WordChainResponse(false, "Từ '" + userWord + "' không tồn tại trong từ vựng của bạn", null, turn);
        }

        // Kiểm tra từ hợp lệ theo luật nối chữ
        if (!isValidWord(userWord, gameSessionId, turn,user)) {
            return new WordChainResponse(false, "Từ không hợp lệ hoặc không khớp luật nối chữ", null, turn);
        }

        // Lưu từ của người dùng
        saveWord(user, userWord, gameSessionId, turn);

        // Máy chọn từ
        String lastLetter = userWord.substring(userWord.length() - 1).toLowerCase();
        List<Vocab> possibleWords = vocabRepository.findByUserIdAndStartingLetter(user.getId(), lastLetter);
        if (possibleWords.isEmpty()) {
            return new WordChainResponse(true, "Máy không tìm thấy từ phù hợp. Bạn thắng!", null, turn + 1);
        }

        String botWord = possibleWords.get(new Random().nextInt(possibleWords.size())).getEnglishWord();
        saveWord(user, botWord, gameSessionId, turn + 1);

        return new WordChainResponse(true, "Lượt chơi thành công", botWord, turn + 2);
    }

    // Chơi online (kiểm tra từ)
    @Transactional
    public WordChainResponse playOnline(String word, String gameSessionId, int turn, String sessionPassword, String username) {
        User user = userRepository.findByUsername(username)
                .orElseThrow(() -> new RuntimeException("Không tìm thấy người dùng: " + username));
        GameSession session = gameSessionRepository.findBySessionId(gameSessionId);
        if (session == null || (session.getPassword() != null && !passwordEncoder.matches(sessionPassword, session.getPassword()))) {
            return new WordChainResponse(false, "Mật khẩu phòng không đúng hoặc phòng không tồn tại", null, turn);
        }

        if (!session.getPlayers().contains(user)) {
            session.addPlayer(user);
            gameSessionRepository.save(session);
        }

        if (turn != session.getCurrentTurn()) {
            logger.debug("Turn mismatch: clientTurn={}, serverCurrentTurn={}", turn, session.getCurrentTurn());
            return new WordChainResponse(false, "Không phải lượt của bạn", null, session.getCurrentTurn());
        }

        if (!isValidWord(word, gameSessionId, turn, user)) {
            return new WordChainResponse(false, "Từ không hợp lệ hoặc không khớp luật nối chữ", null, turn);
        }

        saveWord(user, word, gameSessionId, turn);
        session.setCurrentTurn(session.getCurrentTurn() + 1);
        gameSessionRepository.save(session);
        return new WordChainResponse(true, "Lượt chơi thành công", word, session.getCurrentTurn());
    }

    // Tạo phòng chơi online
    public GameSession createGameSession(String password) {
        GameSession session = new GameSession();
        session.setSessionId(UUID.randomUUID().toString());
        if (password != null && !password.isEmpty()) {
            session.setPassword(passwordEncoder.encode(password));
        }
        return gameSessionRepository.save(session);
    }

    // Kiểm tra từ hợp lệ
    private boolean isValidWord(String word, String gameSessionId, int turn, User user) {
        if (word == null || word.trim().isEmpty()) {
            return false;
        }

        // Kiểm tra từ có trong vocab của user
        Vocab userVocab = vocabRepository.findByUserIdAndEnglishWordIgnoreCase(user.getId(), word);
        if (userVocab == null) {
            return false; // Từ không tồn tại trong từ vựng của user
        }

        // Lượt đầu tiên (turn == 1) luôn hợp lệ nếu từ trong vocab
        if (turn == 1) {
            return true;
        }

        // Kiểm tra ký tự nối cho các lượt sau
        WordChainHistory lastEntry = wordChainHistoryRepository.findTopByGameSessionIdOrderByTurnDesc(gameSessionId);
        if (lastEntry == null) {
            return false; // Không có từ trước, chỉ hợp lệ cho turn == 1
        }
        String lastWord = lastEntry.getWord().toLowerCase();
        String currentWord = word.toLowerCase();
        return currentWord.startsWith(lastWord.substring(lastWord.length() - 1));
    }
    // Lưu từ vào lịch sử
    private void saveWord(User user, String word, String gameSessionId, int turn) {
        WordChainHistory history = new WordChainHistory();
        history.setUser(user);
        history.setWord(word);
        history.setGameSesionId(gameSessionId);
        history.setTurn(turn);
        history.setCreatedAt(LocalDateTime.now());
        wordChainHistoryRepository.save(history);
    }
}

