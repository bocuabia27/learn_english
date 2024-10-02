package com.example.btqlxe.service;

import com.example.btqlxe.entity.Xeco;

import java.util.List;

public interface Xecoservice {
    List<Xeco> getAllXeco();

    Xeco getxecoByID(Long id);

    Xeco createxeco(Xeco xeco);

    Xeco updatexeco(Long id, Xeco xecoDetails);

    void delete(Long id);
}

