package org.apiForMagazyn.api.poz;

import org.apiForMagazyn.api.adres.Adres;
import org.apiForMagazyn.api.prod.Prod;
import org.apiForMagazyn.api.tow.Tow;
import org.apiForMagazyn.api.tow.TowRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping(path = "poz")
public class PozController {
    @Autowired
    private PozRepository pozRepository;
    @Autowired
    private TowRepository towRepository;

    @GetMapping(path = "/all")
    public @ResponseBody Iterable<Poz> getAllDok(){
        return pozRepository.findAll();
    }

    @PostMapping(path="/add")
    public @ResponseBody String addNewProd (@RequestParam Integer idDok,
                                            @RequestParam Integer idTow
            , @RequestParam Integer qty) {
        Poz poz = new Poz();
        Tow tow = towRepository.findById(idTow)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idTow));
        poz.setIdDok(idDok);
        poz.setTow(tow);
        poz.setQty(qty);
        pozRepository.save(poz);
        return "Saved";
    }

    @PostMapping(path="/update")
    public @ResponseBody String updatePoz(@RequestParam Integer idDok
            , @RequestParam Integer nrPoz, @RequestParam Integer idTow
            , @RequestParam Integer qty) {
        PozId id = new PozId(idDok, nrPoz);
        Poz poz = pozRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id));
        Tow tow = towRepository.findById(idTow)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idTow));
        poz.setTow(tow);
        poz.setQty(qty);
        pozRepository.save(poz);
        return "Update";
    }
    @GetMapping(path="/{idDok}")
    public @ResponseBody
    List<Poz> getDokById(@PathVariable("idDok") Integer idDok){
        return pozRepository.findDokByIdDok(idDok);
    }

    @PostMapping(path = "/delete")
    public @ResponseBody String delProd(@RequestParam Integer idDok, @RequestParam Integer nrPoz)
    {
        PozId id = new PozId(idDok, nrPoz);
        Poz poz = pozRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
        pozRepository.delete(poz);
        return "delete Prod with ID: " + id.toString();
    }
}

