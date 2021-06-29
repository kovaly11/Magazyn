package org.apiForMagazyn.api.poz;

import java.io.Serializable;

public class PozId implements Serializable {
    private Integer idDok;
    private Integer nrPoz;
    public PozId() {};
    public PozId(Integer idDok, Integer nrPoz){
        this.idDok = idDok;
        this.nrPoz = nrPoz;
    }
}