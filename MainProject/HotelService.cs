namespace MainProject.Services;

public class HotelService
{
    private static List<Hotel> Hotels = new()
    {
        new Hotel
        {
            Id = 1,
            Name = "Seaside Paradise",
            Location = "Maldives",
            Rating = 4.9,
            ImageUrl = "https://example.com/images/seaside-paradise.jpg",
            DatesOfTravel = new List<string> { "2024-01-01", "2024-01-07" },
            BoardBasis = "All Inclusive",
            Rooms = new List<Room>
            {
                new() { RoomType = "Deluxe Suite", Amount = 5 },
                new() { RoomType = "Family Room", Amount = 3 },
            },
        },
        new Hotel
        {
            Id = 2,
            Name = "Mountain Retreat",
            Location = "Swiss Alps",
            Rating = 4.7,
            ImageUrl = "https://example.com/images/mountain-retreat.jpg",
            DatesOfTravel = new List<string> { "2024-02-15", "2024-02-22" },
            BoardBasis = "Bed & Breakfast",
            Rooms = new List<Room>
            {
                new() { RoomType = "Standard Room", Amount = 10 },
            },
        },
        new Hotel
        {
            Id = 3,
            Name = "Urban Oasis",
            Location = "New York City, USA",
            Rating = 4.5,
            ImageUrl = "https://example.com/images/urban-oasis.jpg",
            DatesOfTravel = new List<string> { "2024-03-10", "2024-03-17" },
            BoardBasis = "Room Only",
            Rooms = new List<Room>
            {
                new() { RoomType = "Luxury Suite", Amount = 2 },
            },
        },
        new Hotel
        {
            Id = 4,
            Name = "Desert Dream",
            Location = "Dubai, UAE",
            Rating = 4.8,
            ImageUrl = "https://example.com/images/desert-dream.jpg",
            DatesOfTravel = new List<string> { "2024-04-01", "2024-04-10" },
            BoardBasis = "Half Board",
            Rooms = new List<Room>
            {
                new() { RoomType = "Luxury Villa", Amount = 10 },
                new() { RoomType = "Family Room", Amount = 5 },
            },
        },
        new Hotel
        {
            Id = 5,
            Name = "Tropical Escape",
            Location = "Bali, Indonesia",
            Rating = 4.6,
            ImageUrl = "https://example.com/images/tropical-escape.jpg",
            DatesOfTravel = new List<string> { "2024-05-01", "2024-05-10" },
            BoardBasis = "All Inclusive",
            Rooms = new List<Room>
            {
                new() { RoomType = "Beach Villa", Amount = 8 },
                new() { RoomType = "Garden Room", Amount = 12 },
            },
        },
        new Hotel
        {
            Id = 6,
            Name = "Historic Haven",
            Location = "Rome, Italy",
            Rating = 4.4,
            ImageUrl = "https://example.com/images/historic-haven.jpg",
            DatesOfTravel = new List<string> { "2024-06-01", "2024-06-07" },
            BoardBasis = "Breakfast Included",
            Rooms = new List<Room>
            {
                new() { RoomType = "Classic Room", Amount = 15 },
                new() { RoomType = "Luxury Suite", Amount = 5 },
            },
        },
        new Hotel
        {
            Id = 7,
            Name = "Safari Lodge",
            Location = "Serengeti, Tanzania",
            Rating = 4.9,
            ImageUrl = "https://example.com/images/safari-lodge.jpg",
            DatesOfTravel = new List<string> { "2024-07-10", "2024-07-20" },
            BoardBasis = "Full Board",
            Rooms = new List<Room>
            {
                new() { RoomType = "Luxury Tent", Amount = 10 },
                new() { RoomType = "Family Suite", Amount = 3 },
            },
        },
        new Hotel
        {
            Id = 8,
            Name = "Ocean Breeze",
            Location = "Gold Coast, Australia",
            Rating = 4.3,
            ImageUrl = "https://example.com/images/ocean-breeze.jpg",
            DatesOfTravel = new List<string> { "2024-08-01", "2024-08-10" },
            BoardBasis = "Self Catering",
            Rooms = new List<Room>
            {
                new() { RoomType = "Ocean View Suite", Amount = 6 },
                new() { RoomType = "Family Room", Amount = 8 },
            },
        },
        new Hotel
        {
            Id = 9,
            Name = "Rainforest Retreat",
            Location = "Costa Rica",
            Rating = 4.7,
            ImageUrl = "https://example.com/images/rainforest-retreat.jpg",
            DatesOfTravel = new List<string> { "2024-09-01", "2024-09-15" },
            BoardBasis = "All Inclusive",
            Rooms = new List<Room>
            {
                new() { RoomType = "Jungle Bungalow", Amount = 7 },
                new() { RoomType = "Standard Room", Amount = 10 },
            },
        },
        new Hotel
        {
            Id = 10,
            Name = "Island Bliss",
            Location = "Hawaii, USA",
            Rating = 4.8,
            ImageUrl = "https://example.com/images/island-bliss.jpg",
            DatesOfTravel = new List<string> { "2024-10-01", "2024-10-10" },
            BoardBasis = "Full Board",
            Rooms = new List<Room>
            {
                new() { RoomType = "Beachfront Suite", Amount = 12 },
                new() { RoomType = "Standard Room", Amount = 15 },
            },
        },
    };

    public List<Hotel> GetList()
    {
        return Hotels;
    }

    public Hotel GetById(string id)
    {
        var hotel = Hotels.FirstOrDefault(hotel => hotel.Id.ToString() == id);
        return hotel;
    }
}

public class Hotel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
    public double Rating { get; set; }
    public required string ImageUrl { get; set; }
    public required List<string> DatesOfTravel { get; set; }
    public required string BoardBasis { get; set; }
    public required List<Room> Rooms { get; set; }
}

public class Room
{
    public required string RoomType { get; set; }
    public int Amount { get; set; }
}
