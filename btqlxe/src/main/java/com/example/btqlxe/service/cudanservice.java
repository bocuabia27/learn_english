package com.example.btqlxe.service;

import com.example.btqlxe.entity.Cudan;

import java.util.List;

public interface cudanservice  {
    List<Cudan> getAllCudan();
    Cudan getCudanByID(Long id);
    Cudan createcudan(Cudan cudan);
    Cudan updatecudan(Long id, Cudan cudanDetails);
    void delete (Long id);

}
