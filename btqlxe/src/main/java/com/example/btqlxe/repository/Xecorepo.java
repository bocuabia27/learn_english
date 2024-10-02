package com.example.btqlxe.repository;
import com.example.btqlxe.entity.Xeco;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface Xecorepo extends JpaRepository<Xeco,Long> {
}
