package com.example.learn_eng.controller;

import com.example.learn_eng.entity.Vocab;
import com.example.learn_eng.Service.VocabService;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/vocab")
public class VocabController {

    private final VocabService vocabService;

    public VocabController(VocabService vocabService) {
        this.vocabService = vocabService;
    }

    @PostMapping("/add")
    public Vocab addVocab(@RequestBody Vocab vocab) {
        return vocabService.addVocab(vocab.getUser().getId(),vocab.getEnglishWord(), vocab.getTopic(),vocab.getMeaning(),vocab.getPartOfSpeech());
    }


    @GetMapping("/all")
    public List<Vocab> getAll(@RequestParam Long userId) {
        return vocabService.getAllByUser(userId);
    }

    @GetMapping("/by-topic")
    public List<Vocab> getByTopic(@RequestParam Long userId,
                                  @RequestParam String topic) {
        return vocabService.getByUserAndTopic(userId, topic);
    }
}
