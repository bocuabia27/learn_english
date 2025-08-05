package com.example.learn_eng.entity;

import com.fasterxml.jackson.annotation.JsonBackReference;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.time.LocalDateTime;
import java.util.List;

@Getter
@Setter
@Entity
@Table(name = "vocab")
@AllArgsConstructor
@NoArgsConstructor
public class Vocab {
    @Id
    @GeneratedValue(strategy =  GenerationType.IDENTITY)
    private Long id;
    private String word; // Từ tiếng Anh
    private String meaning; // Ý nghĩa tiếng Việt
    private String partOfSpeech;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "user_id",nullable = false)
    @JsonBackReference
    private User user;

    @Column(name = "english_word",nullable = false)
    private String englishWord;

    @Column(name = "topic")
    private String topic;

    @Column(name = "learned_date")
    private java.time.LocalDateTime learnedDate = java.time.LocalDateTime.now();

    @OneToMany(mappedBy = "vocab",cascade = CascadeType.ALL)
    private List<ReviewLog> reviewLogs;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public String getEnglishWord() {
        return englishWord;
    }

    public void setEnglishWord(String englishWord) {
        this.englishWord = englishWord;
    }

    public String getTopic() {
        return topic;
    }

    public void setTopic(String topic) {
        this.topic = topic;
    }

    public LocalDateTime getLearnedDate() {
        return learnedDate;
    }

    public void setLearnedDate(LocalDateTime learnedDate) {
        this.learnedDate = learnedDate;
    }

    public List<ReviewLog> getReviewLogs() {
        return reviewLogs;
    }

    public void setReviewLogs(List<ReviewLog> reviewLogs) {
        this.reviewLogs = reviewLogs;
    }

    public String getWord() {
        return word;
    }

    public void setWord(String word) {
        this.word = word;
    }

    public String getMeaning() {
        return meaning;
    }

    public void setMeaning(String meaning) {
        this.meaning = meaning;
    }

    public String getPartOfSpeech() {
        return partOfSpeech;
    }

    public void setPartOfSpeech(String partOfSpeech) {
        this.partOfSpeech = partOfSpeech;
    }
}
