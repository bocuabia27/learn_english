package com.example.btqlxe.controller;

import com.example.btqlxe.DTO.LishsuxeRaVaoDTO;
import com.example.btqlxe.entity.LishsuxeRaVao;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import com.example.btqlxe.service.LichsuxeRaVaoService;

import java.util.List;

@RestController
@RequestMapping("/lichsuxeraVao")
public class LichsuxeRaVaoController {

    @Autowired
    private LichsuxeRaVaoService lichsuxeraVaoService;

    // Lấy danh sách tất cả lịch sử xe ra vào
    @GetMapping
    public List<LishsuxeRaVao> getAllLichsuxeRaVao() {
        return lichsuxeraVaoService.getAllLichsuxeRaVao();
    }

    // Lấy thông tin lịch sử ra vào theo ID
    @GetMapping("/{id}")
    public ResponseEntity<LishsuxeRaVao> getLichsuxeRaVaoById(@PathVariable Long id) {
       LishsuxeRaVao lishsuxeRaVao = lichsuxeraVaoService.getLichsuxeRaVaoById(id);
        if (lishsuxeRaVao != null) {
            return ResponseEntity.ok(lishsuxeRaVao);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    // Thêm một lịch sử xe ra vào mới
    @PostMapping("/create")
    public ResponseEntity<LishsuxeRaVao> createLichsuxeRaVao(@RequestBody LishsuxeRaVaoDTO lishsuxeRaVaoDto) {
        LishsuxeRaVao createdLishsuxeRaVao = lichsuxeraVaoService.createLichsuxeRaVao(lishsuxeRaVaoDto);
        return ResponseEntity.ok(createdLishsuxeRaVao);
    }

    // Cập nhật thông tin lịch sử xe ra vào
    @PutMapping("/{id}")
    public ResponseEntity<LishsuxeRaVao> updateLichsuxeRaVao(@PathVariable Long id, @RequestBody LishsuxeRaVao lichsuDetails) {
        LishsuxeRaVao updatedLichsu = lichsuxeraVaoService.updateLichsuxeRaVao(id, lichsuDetails);
        if (updatedLichsu != null) {
            return ResponseEntity.ok(updatedLichsu);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    // Xóa lịch sử xe ra vào theo ID
    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteLichsuxeRaVao(@PathVariable Long id) {
      lichsuxeraVaoService.deleteLichsuxeRaVao(id);
        return ResponseEntity.noContent().build();
    }
}
