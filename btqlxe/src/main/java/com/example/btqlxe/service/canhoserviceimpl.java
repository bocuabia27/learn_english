package com.example.btqlxe.service;
import com.example.btqlxe.entity.Canho;
import com.example.btqlxe.entity.Toanha;
import com.example.btqlxe.repository.Toanharepo;
import jakarta.persistence.EntityNotFoundException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.example.btqlxe.repository.Canhorepo;

import java.util.List;
import java.util.Optional;
@Service
public class canhoserviceimpl implements canhoservice{
    @Autowired
    private Canhorepo canhorepo;
    @Autowired
    private Toanharepo toanharepo;
    @Override
    public List<Canho> getALlcanho(){
        return canhorepo.findAll();
    }
    public Canho getcanhoByID(Long id){

        return canhorepo.findById(id).orElse(null);
    }
    public Canho createcanho(Canho canho) {
        // Kiểm tra xem Toanha có tồn tại trong cơ sở dữ liệu không
        Toanha toanha = toanharepo.findById(canho.getToanha().getId()).orElse(null);

        if (toanha == null) {
            throw new EntityNotFoundException("Tòa nhà không tồn tại với id: " + canho.getToanha().getId());
        }
        canho.setToanha(toanha);
        return canhorepo.save(canho);
    }
    public Canho updatecanho(Long id , Canho canhoDetails){
        Optional<Canho> optionalCanho =canhorepo.findById(id);
        if (optionalCanho.isPresent()){
            Canho exsittingcanho = optionalCanho.get();
            exsittingcanho.setSocanho(canhoDetails.getSocanho());
            return  canhorepo.save(exsittingcanho);
        }
        return null;
    }
    @Override
    public void delete(Long id){
        canhorepo.deleteById(id);
    }
}
