package com.example.btqlxe.service;

import com.example.btqlxe.entity.Cudan;
import com.example.btqlxe.entity.Xeco;
import com.example.btqlxe.repository.Cudanrepo;
import jakarta.persistence.EntityNotFoundException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.example.btqlxe.repository.Xecorepo;

import java.util.List;
import java.util.Optional;
@Service
public class Xecoserviceimpl implements  Xecoservice{
    @Autowired
    private Xecorepo xecorepo;
    @Autowired
    private Cudanrepo cudanrepo;
    @Override
   public List<Xeco> getAllXeco(){
        return xecorepo.findAll();
    }
    public Xeco  getxecoByID(Long id){
    return xecorepo.findById(id).orElse(null);

    }
    public Xeco createxeco(Xeco xeco){
        Cudan cudan = cudanrepo.findById(xeco.getCudan().getId()).orElse(null);
        if (cudan == null){
            throw new EntityNotFoundException("Xe co khong ton tai");
        }
        xeco.setCudan(cudan);
        return xecorepo.save(xeco);
    }
    public Xeco updatexeco(Long id , Xeco xecoDetails){
        Optional<Xeco> xecoOptional = xecorepo.findById(id);
        if (xecoOptional.isPresent()){
            Xeco exsittingxeco = xecoOptional.get();
            exsittingxeco.setBiensoxe(xecoDetails.getBiensoxe());
            exsittingxeco.setLoaixe(xecoDetails.getLoaixe());
            return xecorepo.save(exsittingxeco);
        }
        return null;
    }
    public void delete (Long id){
        xecorepo.deleteById(id);
    }
}
