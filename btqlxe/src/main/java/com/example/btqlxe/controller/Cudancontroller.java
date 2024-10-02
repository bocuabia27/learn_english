package com.example.btqlxe.controller;

import com.example.btqlxe.DTO.CudanDTO;
import com.example.btqlxe.entity.Canho;
import com.example.btqlxe.entity.Cudan;
import com.example.btqlxe.exception.ResourceNotFoundException;
import com.example.btqlxe.repository.Canhorepo;
import com.example.btqlxe.service.cudanservice;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.context.config.ConfigDataResourceNotFoundException;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.stream.Collectors;

@RestController
@RequestMapping("/api/cudan")
public class Cudancontroller {

    @Autowired
    private cudanservice cudanService;
    @Autowired
    private Canhorepo canhoRepository;

    @GetMapping
    public List<Cudan> getAllCudan() {
        return cudanService.getAllCudan();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Cudan> getCudanById(@PathVariable Long id) {
        Cudan cudan = cudanService.getCudanByID(id);
        if (cudan == null) {
            return ResponseEntity.notFound().build();
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    @PostMapping
    public ResponseEntity<Cudan> createCudan(@RequestBody Cudan cudan) {
        Cudan newcudan = cudanService.createcudan(cudan);
        return ResponseEntity.ok(newcudan);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Cudan> updateCudan(@PathVariable Long id, @RequestBody Cudan cudanDetails) {
        Cudan updatecudan = cudanService.updatecudan(id, cudanDetails);
        if (updatecudan != null){
            return ResponseEntity.ok(updatecudan);
        }
        else {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteCudan(@PathVariable Long id) {
        cudanService.delete(id);
        return ResponseEntity.noContent().build();
    }
}
