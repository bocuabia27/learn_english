package com.example.learn_eng.Enum;

public enum PartOfSpeech {
    NOUN("danh từ"),
    VERB("động từ"),
    ADJECTIVE("tính từ"),
    ADVERB("trạng từ");

    private final String vietnamese;

    PartOfSpeech(String vietnamese) {
        this.vietnamese = vietnamese;
    }

    public String getVietnamese() {
        return vietnamese;
    }
}