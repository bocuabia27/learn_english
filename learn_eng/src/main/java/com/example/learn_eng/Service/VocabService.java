package com.example.learn_eng.Service;

import com.example.learn_eng.entity.User;
import com.example.learn_eng.entity.Vocab;
import com.example.learn_eng.repository.UserRepository;
import com.example.learn_eng.repository.VocabRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class VocabService {
    private final VocabRepository vocabRepository;
    private final UserRepository userRepository;

    public VocabService(VocabRepository vocabRepository, UserRepository userRepository) {
        this.vocabRepository = vocabRepository;
        this.userRepository = userRepository;
    }

    public Vocab addVocab(Long userId, String englishWord, String topic,String meaning,String partOfSpeech) {
        User user = userRepository.findById(userId)
                .orElseThrow(() -> new RuntimeException("User not found"));

        Vocab vocab = new Vocab();
        vocab.setUser(user); // ✅ thay vì setUserId
        vocab.setEnglishWord(englishWord.toLowerCase());
        vocab.setTopic(topic);
        vocab.setTopic(topic);
        vocab.setMeaning(meaning); // Thêm ý nghĩa
        vocab.setPartOfSpeech(partOfSpeech);
        return vocabRepository.save(vocab);
    }
    public List<Vocab> getAllByUser(Long userId) {
        return vocabRepository.findByUser_Id(userId);
    }

    public List<Vocab> getByUserAndTopic(Long userId, String topic) {
        return vocabRepository.findByUserIdAndTopic(userId, topic);
    }
}
