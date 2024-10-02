package com.example.btqlxe.entity;

import com.fasterxml.jackson.annotation.JsonBackReference;
import jakarta.persistence.*;
import lombok.*;
import lombok.experimental.FieldDefaults;

@Data
@AllArgsConstructor
@NoArgsConstructor
@FieldDefaults(level = AccessLevel.PRIVATE)
@Builder
@Entity
@Table(name = "cudan")
public class Cudan {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    Long id;
    String tencudan;
    String solienlac;
    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "canho_id",nullable = false)
    @JsonBackReference
    Canho canho;
}

