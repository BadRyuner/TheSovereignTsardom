using MGSC;

namespace TheSovereignTsardom;

public static class Extensions
{
    public static ContentDropRecord CDR(this string itemId, int weight, int points) => new()
    {
        TechLevel = 0,
        ContentIds = [itemId],
        Weight = weight,
        Points = points
    };
}