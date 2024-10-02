package com.example.btqlxe.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import com.example.btqlxe.entity.Cudan;
@Repository
public interface Cudanrepo extends JpaRepository<Cudan, Long> {
}
