package com.example.btqlxe.controller;

import com.example.btqlxe.entity.Xeco;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import com.example.btqlxe.service.Xecoservice;

import java.util.List;

@RestController
@RequestMapping("/api/xeco")
public class Xecocontroller {
    @Autowired
    private Xecoservice xecoservice;
    @GetMapping
    public List<Xeco> getAllxeco(){
        return xecoservice.getAllXeco();
    }
    @GetMapping("/{id}")
    public ResponseEntity<Xeco> getxecoByID(@PathVariable Long id){
        Xeco xeco = xecoservice.getxecoByID(id);
        if (xeco!=null){
            return ResponseEntity.ok(xeco);
        }
        else {
            return ResponseEntity.notFound().build();
        }
    }
    @PostMapping
    public ResponseEntity<Xeco> createxeco(@RequestBody Xeco xeco){
        Xeco newxeco = xecoservice.createxeco(xeco);
        return ResponseEntity.ok(newxeco);
    }
    @PutMapping("/{id}")
    public ResponseEntity<Xeco> updatexeco(@PathVariable Long id , @RequestBody Xeco xecoDetails){
        Xeco updatexeco = xecoservice.updatexeco(id, xecoDetails);
        if (updatexeco != null){
            return ResponseEntity.ok(updatexeco);
        }
        else {
            return ResponseEntity.notFound().build();
        }
    }
    @DeleteMapping
    public  ResponseEntity<Xeco> deletexeco(@PathVariable Long id){
        xecoservice.delete(id);
        return ResponseEntity.noContent().build();
    }
}
