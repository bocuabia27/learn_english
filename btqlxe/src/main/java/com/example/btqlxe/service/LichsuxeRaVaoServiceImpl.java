package com.example.btqlxe.service;

import com.example.btqlxe.DTO.LishsuxeRaVaoDTO;
import com.example.btqlxe.entity.LishsuxeRaVao;
import com.example.btqlxe.entity.Toanha;
import com.example.btqlxe.entity.Trangthai;
import com.example.btqlxe.entity.Xeco;
import com.example.btqlxe.repository.Xecorepo;
import jakarta.persistence.EntityNotFoundException;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.example.btqlxe.repository.LishsuxeRaVaoRepo;

import java.util.List;
import java.util.Optional;

@Service
public class LichsuxeRaVaoServiceImpl implements LichsuxeRaVaoService {

    @Autowired
    private LishsuxeRaVaoRepo lishsuxeRaVaoRepo;
    @Autowired
    private Xecorepo xecorepo;

    @Override
    public List<LishsuxeRaVao> getAllLichsuxeRaVao() {

        return lishsuxeRaVaoRepo.findAll();
    }

    @Override
    public LishsuxeRaVao getLichsuxeRaVaoById(Long id) {
        return lishsuxeRaVaoRepo.findById(id).orElse(null);
    }

    @Override
    @Transactional
    public LishsuxeRaVao createLichsuxeRaVao(LishsuxeRaVaoDTO lishsuxeRaVaoDto) {
        // Tạo một đối tượng LishsuxeRaVao mới từ dữ liệu trong DTO
        LishsuxeRaVao lishsuxeRaVao = LishsuxeRaVao.builder()
                .thoigianvao(lishsuxeRaVaoDto.getThoigianvao())
                .thoigianra(lishsuxeRaVaoDto.getThoigianra())
                .trangthai(Trangthai.valueOf(lishsuxeRaVaoDto.getTrangthai()))
                .build();

        // Lưu lịch sử xe ra vào vào database
        return lishsuxeRaVaoRepo.save(lishsuxeRaVao);
    }

    @Override
    public LishsuxeRaVao updateLichsuxeRaVao(Long id, LishsuxeRaVao lishsuxeRaVaoDetails) {
        Optional<LishsuxeRaVao> optionalLishsuxeRaVao = lishsuxeRaVaoRepo.findById(id);
        if (optionalLishsuxeRaVao.isPresent()) {
            LishsuxeRaVao existingLishsuxeRaVao = optionalLishsuxeRaVao.get();
            existingLishsuxeRaVao.setThoigianvao(lishsuxeRaVaoDetails.getThoigianvao());
            existingLishsuxeRaVao.setThoigianra(lishsuxeRaVaoDetails.getThoigianra());
            existingLishsuxeRaVao.setTrangthai(lishsuxeRaVaoDetails.getTrangthai());
            return lishsuxeRaVaoRepo.save(existingLishsuxeRaVao);
        }
        return null;
    }

    @Override
    public void deleteLichsuxeRaVao(Long id) {
        lishsuxeRaVaoRepo.deleteById(id);
    }
}
