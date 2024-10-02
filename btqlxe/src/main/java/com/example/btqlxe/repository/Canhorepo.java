package com.example.btqlxe.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import com.example.btqlxe.entity.Canho;
@Repository
public interface Canhorepo extends JpaRepository<Canho, Long> {
}
