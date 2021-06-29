package org.apiForMagazyn.api.prod;

import org.apiForMagazyn.api.adres.Adres;
import org.apiForMagazyn.api.adres.AdresRepository;
import org.apiForMagazyn.api.company.Company;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;


@Controller
@RequestMapping(path = "prod")
public class ProdController {
    @Autowired
    private ProdRepository prodRepository;
    @Autowired
    private AdresRepository adresRepository;

    @GetMapping(path="/all")
    public @ResponseBody
    Iterable<Prod>  getAllProd(){
        return prodRepository.findAll();
    }

    @PostMapping(path="/add")
    public @ResponseBody String addNewProd (@RequestParam String name
            , @RequestParam String person, @RequestParam String tel
            , @RequestParam Integer idAd) {
        Prod prod = new Prod();
        Adres adr = adresRepository.findById(idAd)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idAd));
        prod.setName(name);
        prod.setPerson(person);
        prod.setTel(tel);
        prod.setAdres(adr);
        prodRepository.save(prod);
        return "Saved";
    }

    @PostMapping(path="/update")
    public @ResponseBody String updateProd (
            @RequestParam Integer id,  @RequestParam String name
            , @RequestParam String person, @RequestParam String tel
            , @RequestParam Integer idAd) {
        Adres adr = adresRepository.findById(idAd)
                .orElseThrow(() -> new IllegalArgumentException("Invalid Adres Id:" + idAd));
        Prod prod = prodRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid prod Id:" + id));
        prod.setName(name);
        prod.setPerson(person);
        prod.setTel(tel);
        prod.setAdres(adr);
        prodRepository.save(prod);
        return "Update";
    }
    @GetMapping(path="/{id}")
    public @ResponseBody Prod  getProdById(@PathVariable("id") Integer id){

        return prodRepository.findById(id).orElseThrow(() -> new IllegalArgumentException("Invalid prod Id:" + id));
    }

    @PostMapping(path = "/delete")
    public @ResponseBody String delProd(@RequestParam Integer id)
    {
        Prod prod = prodRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
        prodRepository.delete(prod);
        return "delete Prod with ID: " + id.toString();
    }
}
