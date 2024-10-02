package com.example.btqlxe.repository;
import com.example.btqlxe.entity.Toanha;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface Toanharepo extends JpaRepository <Toanha,Long>  {
}
