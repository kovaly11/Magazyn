package org.apiForMagazyn.api.dok;

import lombok.Getter;
import lombok.Setter;
import org.apiForMagazyn.api.company.Company;
import org.apiForMagazyn.api.prac.Prac;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.Date;

@Entity
@Table
@Setter
@Getter
public class Dok {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idDok;
    @OneToOne
    @JoinColumn(name="idPrac")
    private Prac prac;
    @OneToOne
    @JoinColumn(name="idCom")
    private Company company;
    @Size(max=2)
    private String tDok;
    @Temporal(TemporalType.TIMESTAMP)
    private Date data;
}
