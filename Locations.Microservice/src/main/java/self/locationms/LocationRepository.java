package self.locationms;

import java.util.ArrayList;

public class LocationRepository {
	private static ArrayList<Location> Localizacoes;
	
	public LocationRepository() {
		if(Localizacoes == null) {
			Localizacoes = new ArrayList<>();
			Localizacoes.add(new Location(1, 1, 14.2, 44.5));
			Localizacoes.add(new Location(2, 2, 74.2, 74.5));
			Localizacoes.add(new Location(3, 7, 14.2, 44.5));
			Localizacoes.add(new Location(4, 8, 14.2, 44.5));
			Localizacoes.add(new Location(5, 9, 14.2, 44.5));
		}
	}

	public ArrayList<Location> getLocalizacoes() {
		return Localizacoes;
	}

	public void setLocalizacoes(ArrayList<Location> localizacoes) {
		Localizacoes = localizacoes;
	}
	
	public void create(Location localizacao) {
		Localizacoes.add(new Location(Localizacoes.size() + 1, localizacao.getUserId(), localizacao.getLatitude(), localizacao.getLongitude()));
	}
}
