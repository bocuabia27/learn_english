package com.example.btqlxe.controller;

import com.example.btqlxe.DTO.CanhoDTO;
import com.example.btqlxe.entity.Canho;
import com.example.btqlxe.entity.Toanha; // Nhập Toanha
import com.example.btqlxe.service.canhoservice;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.stream.Collectors;

@RestController
@RequestMapping("/api/canho")
public class Canhocontroller {

    @Autowired
    private canhoservice canhoservice;

    @GetMapping
    public List<Canho> getAllToanha() {
        return canhoservice.getALlcanho();
    }


    @GetMapping("/{id}")
    public ResponseEntity<Canho> getcanhoByID(@PathVariable Long id) {
        Canho canho = canhoservice.getcanhoByID(id);
        if (canho != null) {
            return ResponseEntity.ok(canho);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    @PostMapping
    public ResponseEntity<Canho> createcanho(@RequestBody Canho canho) {
        Canho newCanho = canhoservice.createcanho(canho); // Đổi tên biến cho đúng quy tắc camel case
        return ResponseEntity.ok(newCanho);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Canho> updatecanho(@PathVariable long id, @RequestBody Canho canhoDetails) {
        Canho updatedCanho = canhoservice.updatecanho(id, canhoDetails); // Đổi tên biến cho đúng quy tắc camel case
        if (updatedCanho != null) {
            return ResponseEntity.ok(updatedCanho);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deletecanho(@PathVariable long id) {
        canhoservice.delete(id);
        return ResponseEntity.noContent().build();
    }
}
