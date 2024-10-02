package com.example.btqlxe.entity;

import com.fasterxml.jackson.annotation.JsonBackReference;
import jakarta.persistence.*;
import lombok.*;
import lombok.experimental.FieldDefaults;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Builder
@FieldDefaults(level = AccessLevel.PRIVATE)
@Table(name = "canho")
@Entity
public class Canho {
@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    Long id;
   String socanho;
   @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "toanha_id ",nullable = false)
   @JsonBackReference
    Toanha toanha;
}
