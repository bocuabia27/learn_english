package com.example.btqlxe.service;

import com.example.btqlxe.DTO.LishsuxeRaVaoDTO;
import com.example.btqlxe.entity.LishsuxeRaVao;
import java.util.List;

public interface LichsuxeRaVaoService {
    List<LishsuxeRaVao> getAllLichsuxeRaVao();
    LishsuxeRaVao getLichsuxeRaVaoById(Long id);
    LishsuxeRaVao createLichsuxeRaVao(LishsuxeRaVaoDTO lishsuxeRaVaoDto);
    LishsuxeRaVao updateLichsuxeRaVao(Long id, LishsuxeRaVao lishsuxeRaVaoDetails);
    void deleteLichsuxeRaVao(Long id);
}
