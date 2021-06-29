package org.apiForMagazyn.api.adres;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping(path = "adres")
public class AdresController {
    @Autowired
    private AdresRepository adresRepository;

    @GetMapping(path="/all")
    public @ResponseBody
    Iterable<Adres>  getAllAdres(){
        return adresRepository.findAll();
    }

    @PostMapping(path="/add")
    public @ResponseBody String addNewAdres (@RequestParam String street
            , @RequestParam String number, @RequestParam String city
            , @RequestParam String pCode) {
        Adres adr = new Adres();
        adr.setStreet(street);
        adr.setNumber(number);
        adr.setCity(city);
        adr.setPCode(pCode);
        adresRepository.save(adr);
        return "Saved";
    }

    @PostMapping(path="/update")
    public @ResponseBody String updateAdres (
            @RequestParam Integer id,  @RequestParam String street
            , @RequestParam String number, @RequestParam String city
            , @RequestParam String pCode) {
        Adres adr = adresRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id));
        adr.setStreet(street);
        adr.setNumber(number);
        adr.setCity(city);
        adr.setPCode(pCode);
        adresRepository.save(adr);
        return "Update";
    }
    @GetMapping(path="/{id}")
    public @ResponseBody Adres  getAdresById(@PathVariable("id") Integer id){

        return adresRepository.findById(id).orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id));
    }

    @PostMapping(path = "/delete")
    public @ResponseBody String delAdres(@RequestParam Integer id)
    {
        Adres adr = adresRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id));
        adresRepository.delete(adr);
        return "delete Adres with ID: " + id.toString();
    }
}
