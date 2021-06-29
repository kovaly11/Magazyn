package org.apiForMagazyn.api.company;

import lombok.Getter;
import lombok.Setter;
import org.apiForMagazyn.api.adres.Adres;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Entity
@Table
@Setter
@Getter
public class Company {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idCom;

    @Size(max = 50)
    private String name;

    @Size(max = 50)
    private String person;

    @Size(max = 20)
    private String nip;
    @OneToOne
    @JoinColumn(name="idAd")
    private Adres adres;
}
