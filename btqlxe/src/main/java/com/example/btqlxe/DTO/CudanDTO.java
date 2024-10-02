package com.example.btqlxe.DTO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class CudanDTO {
    private Long id;
    private String tencudan;
    private String solienlac;
    private Long canhoId; // ID của Canho
    // ID của Canho
}
