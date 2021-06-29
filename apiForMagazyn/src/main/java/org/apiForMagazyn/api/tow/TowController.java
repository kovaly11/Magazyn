package org.apiForMagazyn.api.tow;

import org.apiForMagazyn.api.adres.Adres;
import org.apiForMagazyn.api.prod.Prod;
import org.apiForMagazyn.api.prod.ProdRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping(path = "tow")
public class TowController {
    @Autowired
    private TowRepository towRepository;
    @Autowired
    private ProdRepository prodRepository;

    @GetMapping(path = "/all")
    public @ResponseBody
    Iterable<Tow> getAllTow() {
        return towRepository.findAll();
    }

    @PostMapping(path="/add")
    public @ResponseBody String addNewTow (@RequestParam String nrSer
            , @RequestParam String name, @RequestParam String dim
            , @RequestParam Integer idProd) {
        Tow tow = new Tow();
        Prod prod  = prodRepository.findById(idProd)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idProd));
       tow.setNrSer(nrSer);
       tow.setName(name);
       tow.setDim(dim);
       tow.setProd(prod);
       towRepository.save(tow);
       return "Saved";
    }

    @PostMapping(path="/update")
    public @ResponseBody String updateProd (
            @RequestParam Integer id,  @RequestParam String nrSer
            , @RequestParam String name, @RequestParam String dim
            , @RequestParam Integer idProd) {
        Tow tow = towRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id));
        Prod prod  = prodRepository.findById(idProd)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idProd));
        tow.setNrSer(nrSer);
        tow.setName(name);
        tow.setDim(dim);
        tow.setProd(prod);
        towRepository.save(tow);
        return "Update";
    }
    @GetMapping(path="/{id}")
    public @ResponseBody Tow  getProdById(@PathVariable("id") Integer id){

        return towRepository.findById(id).orElseThrow(() -> new IllegalArgumentException("Invalid prod Id:" + id));
    }

    @PostMapping(path = "/delete")
    public @ResponseBody String delProd(@RequestParam Integer id)
    {
        Tow tow = towRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
        towRepository.delete(tow);
        return "delete Prod with ID: " + id.toString();
    }
}
