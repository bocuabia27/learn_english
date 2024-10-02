package com.example.btqlxe.entity;

import jakarta.persistence.*;
import lombok.*;
import lombok.experimental.FieldDefaults;

import java.time.LocalDateTime;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Builder
@FieldDefaults(level = AccessLevel.PRIVATE)
@Table(name = "lichsuxeravao")
@Entity
public class LishsuxeRaVao {
@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    long id;
    String thoigianvao;
    String thoigianra;
    @Enumerated(EnumType.STRING)
    @Column(nullable = false)
    Trangthai trangthai;

}
