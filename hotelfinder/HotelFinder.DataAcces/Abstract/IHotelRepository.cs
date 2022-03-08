using hotelfinder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAcces.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();

        Hotel GetHotelById(int id);
        Hotel CreateHotel(Hotel hotel);

        Hotel UpdateHotel(Hotel hotel);

        void DeleteHotelById(int id);
        void DeleteHotel(int id);
    }
}
