using FavoriteColorDatabase.Models;

namespace FavoriteColorDatabase.Services;

    public interface IFavColor
    {
        List<FavoriteColor> GetData();

        List<FavoriteColor> AddFavColor(string name, string color);
    }
