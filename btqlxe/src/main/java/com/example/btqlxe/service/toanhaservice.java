    package com.example.btqlxe.service;
    import com.example.btqlxe.entity.Toanha;
    import java.util.List;

    public interface toanhaservice {
        List<Toanha> getAlltoanha();
        Toanha gettoanhaByID(Long id);
        Toanha createtoanha(Toanha toanha);
        Toanha updatetoanha(Long id,Toanha toanhaDetails);
        void delete (Long id);
    }
