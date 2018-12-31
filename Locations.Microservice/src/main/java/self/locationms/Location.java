package self.locationms;

public class Location {

    private final long id;
    private final long userId;
    private final double latitude;
    private final double longitude;
	
    public Location(long id, long userId, double latitude, double longitude) {
		super();
		this.id = id;
		this.userId = userId;
		this.latitude = latitude;
		this.longitude = longitude;
	}

	public long getId() {
		return id;
	}

	public double getLatitude() {
		return latitude;
	}

	public double getLongitude() {
		return longitude;
	}

	public long getUserId() {
		return userId;
	}
}