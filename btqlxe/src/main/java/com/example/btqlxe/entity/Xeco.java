package com.example.btqlxe.entity;

import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import lombok.*;
import lombok.experimental.FieldDefaults;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Builder
@FieldDefaults(level = AccessLevel.PRIVATE)
@Table(name = "xeco")
@Entity
public class Xeco {
@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    long id;
String biensoxe;
String loaixe;
@ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "xeco_id",nullable = false)
@JsonManagedReference
    Cudan cudan;
}
