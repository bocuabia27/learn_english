package com.example.learn_eng.Service;

public class WordChainResponse {
    private boolean success;
    private String message;
    private String nextWord;
    private int nextTurn;

    public WordChainResponse(boolean success, String message, String nextWord, int nextTurn) {
        this.success = success;
        this.message = message;
        this.nextWord = nextWord;
        this.nextTurn = nextTurn;
    }

    public boolean isSuccess() { return success; }
    public void setSuccess(boolean success) { this.success = success; }
    public String getMessage() { return message; }
    public void setMessage(String message) { this.message = message; }
    public String getNextWord() { return nextWord; }
    public void setNextWord(String nextWord) { this.nextWord = nextWord; }
    public int getNextTurn() { return nextTurn; }
    public void setNextTurn(int nextTurn) { this.nextTurn = nextTurn; }
}
