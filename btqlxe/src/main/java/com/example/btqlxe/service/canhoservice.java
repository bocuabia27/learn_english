package com.example.btqlxe.service;

import com.example.btqlxe.entity.Canho;

import java.util.List;

public interface canhoservice {
    List<Canho> getALlcanho();
    Canho getcanhoByID(Long id);
    Canho createcanho(Canho canho);
    Canho updatecanho(Long id,Canho canhoDetails);
    void delete (Long id);
}
