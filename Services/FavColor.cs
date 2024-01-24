using FavoriteColorDatabase.Data;
using FavoriteColorDatabase.Models;

namespace FavoriteColorDatabase.Services;

public class FavColor : IFavColor
{
    private readonly DataContext _db;

    public FavColor(DataContext db)
    {
        _db = db;
    }

    public List<FavoriteColor> AddFavColor(string name, string color)
    {
        FavoriteColor sub = new();
        sub.Color = color;
        sub.Name = name;
        _db.FavoriteColors.Add(sub);

        return _db.FavoriteColors.ToList();
    }

    public List<FavoriteColor> GetData()
    {
        return _db.FavoriteColors.ToList();
    }
}
