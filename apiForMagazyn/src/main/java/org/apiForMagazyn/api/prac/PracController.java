package org.apiForMagazyn.api.prac;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping(path = "/prac")
public class PracController {
    @Autowired
    private PracRepository pracRepository;

    @GetMapping(path="all")
    public @ResponseBody
    Iterable<Prac>  getAllPrac(){
        return pracRepository.findAll();
    }

    @GetMapping(path="/log")
    public @ResponseBody Integer chekLoginAndPass(@RequestParam("login") String login, @RequestParam("passw") String passw){
        List<Prac> prac = pracRepository.findPracByLoginAndPass(login, passw);
        if(prac.isEmpty())
            return -1;
        else
            return prac.get(0).idPrac;
    }

    @GetMapping(path="/{id}")
    public @ResponseBody Prac getPracById(@PathVariable("id") Integer id){

        return pracRepository.findById(id).orElseThrow(() -> new IllegalArgumentException("Invalid adres Id:" + id)); }

}
