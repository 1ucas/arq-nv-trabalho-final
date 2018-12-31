package self.locationms;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.concurrent.atomic.AtomicLong;
import java.util.stream.Collectors;

import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class LocationController {

    private static final String template = "Hello, %s!";

    @RequestMapping(value = "/location", method = RequestMethod.GET)
    public List<Location> getLocations(@RequestParam(value="userId", required = false) Long userId) {
    	List<Location> todasLocalizacoes = new LocationRepository().getLocalizacoes();
    	List<Location> loc = userId == null ? todasLocalizacoes : todasLocalizacoes.stream()
        			.filter((localizacao) ->localizacao.getUserId() == userId).collect(Collectors.toList());
        return loc;
    }
    
    @RequestMapping(value = "/location", method = RequestMethod.POST)
    public void addLocation(@RequestBody Location location) {
        new LocationRepository().create(location);
    }
}
