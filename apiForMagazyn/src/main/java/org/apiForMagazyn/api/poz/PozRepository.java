package org.apiForMagazyn.api.poz;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface PozRepository extends CrudRepository<Poz, PozId> {
    @Query(value = "SELECT * FROM POZ WHERE ID_DOK = :idDok", nativeQuery = true)
    List<Poz> findDokByIdDok(@Param("idDok") Integer idDok);
}
