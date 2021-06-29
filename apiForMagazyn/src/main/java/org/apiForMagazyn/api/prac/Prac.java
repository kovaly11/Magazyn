package org.apiForMagazyn.api.prac;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Entity
@Table
@Setter
@Getter
public class Prac {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer idPrac;

    @Size(max = 50)
    private String imie;

    @Size(max = 50)
    private String nazw;

    @Size(max = 15)
    private String tel;

    @Size(max=10)
    private String role;
}
