using Domain;

namespace GraphQL;

[QueryType]
public static class Query
{
    public static IQueryable<Amenity> GetAmenities()
        => new List<Amenity>
        {
            new() { Id = 1, Name = "Swimming Pool", Description = "Outdoor pool for swimming" },
            new() { Id = 2, Name = "Gym", Description = "Fully equipped gym with modern equipment" }
        }.AsQueryable();
}