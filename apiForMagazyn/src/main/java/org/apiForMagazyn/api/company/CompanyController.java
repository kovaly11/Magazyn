package org.apiForMagazyn.api.company;

import org.apiForMagazyn.api.adres.Adres;
import org.apiForMagazyn.api.adres.AdresRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping(path = "company")
public class CompanyController {
    @Autowired
    private CompanyRepository companyRepository;
    @Autowired
    private AdresRepository adresRepository;

    @GetMapping(path="/all")
    public @ResponseBody
    Iterable<Company>  getAllCompany(){
        return companyRepository.findAll();
    }

    @PostMapping(path="/add")
    public @ResponseBody String addNewCompany (@RequestParam String name
            , @RequestParam String person, @RequestParam String nip
            , @RequestParam Integer idAd) {
        Company company = new Company();
        Adres adr = adresRepository.findById(idAd)
                .orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + idAd));
        company.setName(name);
        company.setPerson(person);
        company.setNip(nip);
        company.setAdres(adr);
        companyRepository.save(company);
        return "Saved";
    }

    @PostMapping(path="/update")
    public @ResponseBody String updateCompany (
            @RequestParam Integer id,  @RequestParam String name
            , @RequestParam String person, @RequestParam String nip
            , @RequestParam Integer idAd) {
        Adres adr = adresRepository.findById(idAd)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + idAd));
        Company company = companyRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
        company.setName(name);
        company.setPerson(person);
        company.setNip(nip);
        company.setAdres(adr);
        companyRepository.save(company);
        return "Update";
    }
    @GetMapping(path="/{id}")
    public @ResponseBody Company  getAdresById(@PathVariable("id") Integer id){

        return companyRepository.findById(id).orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
    }

    @PostMapping(path = "/delete")
    public @ResponseBody String delCompany(@RequestParam Integer id)
    {
        Company company = companyRepository.findById(id)
                .orElseThrow(() -> new IllegalArgumentException("Invalid company Id:" + id));
        companyRepository.delete(company);
        return "delete Company with ID: " + id.toString();
    }
}
