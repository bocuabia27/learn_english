package com.example.btqlxe.DTO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class CanhoDTO {
    private Long id;
    private String socanho; // Trường socanho từ Canho entity
    private Long toanhaId; // ID của Toanha liên kết
}
