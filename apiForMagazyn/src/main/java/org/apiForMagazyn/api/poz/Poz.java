package org.apiForMagazyn.api.poz;

import lombok.Getter;
import lombok.Setter;
import org.apiForMagazyn.api.tow.Tow;

import javax.persistence.*;


@Entity
@Table
@Setter
@Getter
@IdClass(PozId.class)
public class Poz {
    @Id
    private Integer idDok;
    @Id
    private Integer nrPoz;
    @OneToOne
    @JoinColumn(name="idTow")
    private Tow tow;
    private Integer qty;
}
