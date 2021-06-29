package org.apiForMagazyn.api.prac;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface PracRepository extends CrudRepository<Prac, Integer> {
    @Query(value = "SELECT * FROM PRAC WHERE login = :login and passw = :passw", nativeQuery = true)
    List<Prac> findPracByLoginAndPass(@Param("login") String login, @Param("passw") String passw);
}
