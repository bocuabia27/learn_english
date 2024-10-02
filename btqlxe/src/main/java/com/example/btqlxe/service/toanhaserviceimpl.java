package com.example.btqlxe.service;
import com.example.btqlxe.entity.Canho;
import com.example.btqlxe.entity.Toanha;
import com.example.btqlxe.repository.Toanharepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;
@Service
public class toanhaserviceimpl implements toanhaservice  {
    @Autowired
    private Toanharepo toanharepo;
    @Override
    public List<Toanha> getAlltoanha(){
        return toanharepo.findAll();
    }
    public Toanha gettoanhaByID(Long id){
        Optional<Toanha> toanha = toanharepo.findById(id);
        return toanha.orElse(null);
    }


    public Toanha createtoanha(Toanha toanha) {
        if (toanha.getCanhos() != null) {
            for (Canho canho : toanha.getCanhos()) {
                canho.setToanha(toanha); // Thiết lập mối quan hệ
            }
        }
        return toanharepo.save(toanha); // Lưu tòa nhà
    }

    public Toanha updatetoanha(Long id,Toanha toanhaDetails){
        Optional<Toanha> optionalToanha = toanharepo.findById(id);
        if (optionalToanha.isPresent()){
            Toanha exsitingtoanha = optionalToanha.get();
            exsitingtoanha.setTentoanha(toanhaDetails.getTentoanha());
            exsitingtoanha.setDiachi(toanhaDetails.getDiachi());
            return toanharepo.save(exsitingtoanha);
        }
        return null;
    }

    @Override
    public void delete(Long id) {
        toanharepo.deleteById(id);
    }
}
