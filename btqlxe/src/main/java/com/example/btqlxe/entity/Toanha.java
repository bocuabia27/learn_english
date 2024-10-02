package com.example.btqlxe.entity;

import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import lombok.*;
import lombok.experimental.FieldDefaults;

import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Builder
@FieldDefaults(level = AccessLevel.PRIVATE)
@Table(name = "toanha")
@Entity

public class Toanha {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    Long id;
    String tentoanha;
    String diachi;
    @OneToMany(mappedBy = "toanha", cascade = CascadeType.ALL,fetch = FetchType.LAZY)
    @JsonManagedReference
    List<Canho> canhos;

}
