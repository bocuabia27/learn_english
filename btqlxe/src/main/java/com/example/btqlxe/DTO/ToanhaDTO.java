package com.example.btqlxe.DTO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class ToanhaDTO {
    private Long id;
    private String tentoanha; // Tên của Toanha
    private String diachi; // Địa chỉ
}
