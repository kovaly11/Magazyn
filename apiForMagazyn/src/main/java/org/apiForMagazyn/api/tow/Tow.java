package org.apiForMagazyn.api.tow;

import lombok.Getter;
import lombok.Setter;
import org.apiForMagazyn.api.prod.Prod;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Entity
@Table
@Setter
@Getter
public class Tow {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idTow;

    @Size(max = 50)
    private String nrSer;

    @Size(max = 50)
    private String name;

    @Size(max = 20)
    private String dim;

    @OneToOne
    @JoinColumn(name="idProd")
    private Prod prod;
}
