package org.apiForMagazyn.api.adres;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Entity
@Table
@Setter
@Getter
public class Adres {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idAd;

    @Size(max = 50)
    private String street;

    @Size(max = 8)
    private String number;

    @Size(max = 50)
    private String city;

    @Size(max = 10)
    private String pCode;

}
