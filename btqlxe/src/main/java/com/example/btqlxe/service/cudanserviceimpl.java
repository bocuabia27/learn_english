    package com.example.btqlxe.service;
    import com.example.btqlxe.entity.Canho;
    import com.example.btqlxe.entity.Toanha;
    import com.example.btqlxe.repository.Canhorepo;
    import jakarta.persistence.EntityNotFoundException;
    import org.springframework.beans.factory.annotation.Autowired;
    import org.springframework.stereotype.Service;
    import com.example.btqlxe.repository.Cudanrepo;
    import com.example.btqlxe.entity.Cudan;

    import java.util.List;
    import java.util.Optional;

    @Service
    public class cudanserviceimpl implements cudanservice {

        @Autowired
        private Cudanrepo cudanrepo;
        @Autowired
private Canhorepo canhorepo;
        @Override
        public List<Cudan> getAllCudan() {
            return cudanrepo.findAll();
        }
        public Cudan getCudanByID(Long id) {
          return cudanrepo.findById(id).orElse(null);
        }
        public Cudan createcudan(Cudan cudan){

            Canho canho = canhorepo.findById(cudan.getCanho().getId()).orElse(null);

            if (canho == null) {
                throw new EntityNotFoundException("can ho không tồn tại với id: " + canho.getToanha().getId());
            }
            cudan.setCanho(canho);
            return cudanrepo.save(cudan);
        }
        public Cudan updatecudan(Long id, Cudan cudanDetails){
            Optional<Cudan> optionalCudan = cudanrepo.findById(id);
            if (optionalCudan.isPresent()){
                Cudan exsittingcudan = optionalCudan.get();
                {
                    exsittingcudan.setTencudan(cudanDetails.getTencudan());
                    exsittingcudan.setSolienlac(cudanDetails.getSolienlac());
                    return cudanrepo.save(exsittingcudan);
                }

            }
            return null;
        }
        public void delete  (Long id){
            cudanrepo.deleteById(id);
        }
    }
