package com.example.btqlxe.DTO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class LishsuxeRaVaoDTO {
    private Long id;
    private String thoigianvao; // Thời gian vào
    private String thoigianra; // Thời gian ra
    private String trangthai; // Trạng thái
}
