package org.apiForMagazyn.api.prod;

import lombok.Getter;
import lombok.Setter;
import org.apiForMagazyn.api.adres.Adres;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Entity
@Table
@Setter
@Getter
public class Prod {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idProd;

    @Size(max = 50)
    private String name;

    @Size(max = 50)
    private String person;

    @Size(max = 20)
    private String tel;
    @OneToOne
    @JoinColumn(name="idAd")
    private Adres adres;
}
