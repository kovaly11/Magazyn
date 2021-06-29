package org.apiForMagazyn.api.dok;

import org.apiForMagazyn.api.company.Company;
import org.apiForMagazyn.api.company.CompanyRepository;
import org.apiForMagazyn.api.prac.Prac;
import org.apiForMagazyn.api.prac.PracRepository;
import org.apiForMagazyn.api.prod.Prod;
import org.apiForMagazyn.api.tow.Tow;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.Date;

@Controller
@RequestMapping("dok")
public class DokController {
    @Autowired
    private DokRepository dokRepository;
    @Autowired
    private CompanyRepository companyRepository;
    @Autowired
    private PracRepository pracRepository;

    @GetMapping(path="/all")
    public @ResponseBody
    Iterable<Dok>  getAllDok(){
        return dokRepository.findAll();
    }

    @PostMapping(path="/add")
    public @ResponseBody String addNewDok (@RequestParam Integer idPrac
            , @RequestParam Integer idCom, @RequestParam String tDok
            , @RequestParam  @DateTimeFormat(pattern = "dd.MM.yyyy HH:mm:ss") Date data) {
        Dok dok = new Dok();
        Prac prac = pracRepository.findById(idPrac)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idPrac));
        Company company = companyRepository.findById(idCom)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idCom));
        dok.setPrac(prac);
        dok.setCompany(company);
        dok.setTDok(tDok);
        dok.setData(data);
        dokRepository.save(dok);
        return "Saved";
    }

    @PostMapping(path="/update")
    public @ResponseBody String updateProd (
            @RequestParam Integer id,  @RequestParam Integer idPrac
            , @RequestParam Integer idCom, @RequestParam String tDok
            , @RequestParam  @DateTimeFormat(pattern = "dd.MM.yyyy HH:mm:ss") Date data) {
        Dok dok = dokRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id));
        Prac prac = pracRepository.findById(idPrac)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idPrac));
        Company company = companyRepository.findById(idCom)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idCom));
        dok.setPrac(prac);
        dok.setCompany(company);
        dok.setTDok(tDok);
        dok.setData(data);
        dokRepository.save(dok);
        return "Update";
    }
    @GetMapping(path="/{id}")
    public @ResponseBody Dok  getDokById(@PathVariable("id") Integer id){

        return dokRepository.findById(id).orElseThrow(() -> new IllegalArgumentException("Invalid prod Id:" + id));
    }

    @PostMapping(path = "/delete")
    public @ResponseBody String delDok(@RequestParam Integer id)
    {
        Dok dok = dokRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
        dokRepository.delete(dok);
        return "delete Prod with ID: " + id.toString();
    }
}
