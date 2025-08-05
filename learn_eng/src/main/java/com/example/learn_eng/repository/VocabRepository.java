package com.example.learn_eng.repository;

import com.example.learn_eng.entity.Vocab;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;

public interface VocabRepository extends JpaRepository<Vocab, Long> {
    List<Vocab> findByUser_Id(Long userId);
    List<Vocab> findByUserIdAndTopic(Long userId, String topic);
    Vocab findByUserIdAndEnglishWordIgnoreCase(Long userId, String englishWord);
    @Query("SELECT v FROM Vocab v WHERE v.user.id = :userId AND LOWER(v.englishWord) LIKE :startingLetter%")
    List<Vocab> findByUserIdAndStartingLetter(Long userId, String startingLetter);
    List<Vocab> findByUserIdAndMeaningContainingIgnoreCase(Long userId, String meaning);
    List<Vocab> findByUserIdAndPartOfSpeech(Long userId, String partOfSpeech);
}
