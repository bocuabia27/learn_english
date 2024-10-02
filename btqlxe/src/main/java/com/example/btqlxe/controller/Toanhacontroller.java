package com.example.btqlxe.controller;

import com.example.btqlxe.entity.Toanha;
import com.example.btqlxe.service.toanhaservice; // Đổi tên lớp dịch vụ cho đúng quy tắc camel case
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/toanha")
public class Toanhacontroller { // Đổi tên lớp cho đúng quy tắc camel case
    @Autowired
    private toanhaservice toanhaService; // Đổi tên biến cho đúng quy tắc camel case

    @GetMapping
    public List<Toanha> getAllToanha() {
        return toanhaService.getAlltoanha();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Toanha> getToanhaByID(@PathVariable long id) {
        Toanha toanha = toanhaService.gettoanhaByID(id);
        if (toanha != null) {
            return ResponseEntity.ok(toanha);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    @PostMapping
    public ResponseEntity<Toanha> createToanha(@RequestBody Toanha toanha) {
        Toanha newToanha = toanhaService.createtoanha(toanha); // Đổi tên biến cho đúng quy tắc camel case
        return ResponseEntity.ok(newToanha);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Toanha> updateToanha(@PathVariable long id, @RequestBody Toanha toanhaDetails) {
        Toanha updatedToanha = toanhaService.updatetoanha(id, toanhaDetails); // Đổi tên biến cho đúng quy tắc camel case
        if (updatedToanha != null) {
            return ResponseEntity.ok(updatedToanha);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteToanha(@PathVariable long id) {
        toanhaService.delete(id);
        return ResponseEntity.noContent().build();
    }
}
