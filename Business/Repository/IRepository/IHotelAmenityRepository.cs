using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelAmenityRepository
    {
        //Create
        Task<HotelAmenityDTO> CreateHotelAmenity(HotelAmenityDTO hotelAmenityDTO);

        //Get
        Task<HotelAmenityDTO> GetAmenityById(int amenityId);
        Task<IEnumerable<HotelAmenityDTO>> GetAllAmenities();

        //Update
        Task<HotelAmenityDTO> UpdateAmenity(HotelAmenityDTO updatedAmenityDTO, int amenityId);


        Task<bool> IsAmenityNameUnique(string name, int amenityId = 0);
    }
}
