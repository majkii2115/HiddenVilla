using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelAmenityRepository : IHotelAmenityRepository
    {
        #region Variables
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public HotelAmenityRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<HotelAmenityDTO> CreateHotelAmenity(HotelAmenityDTO hotelAmenityDTO)
        {
            HotelAmenity hotelAmenity = _mapper.Map<HotelAmenityDTO, HotelAmenity>(hotelAmenityDTO);
            hotelAmenity.CreateDate = DateTime.Now;
            hotelAmenity.CreatedBy = "";

            var createdAmenity = await _db.HotelAmenities.AddAsync(hotelAmenity);
            await _db.SaveChangesAsync();

            return _mapper.Map<HotelAmenity, HotelAmenityDTO>(createdAmenity.Entity);
        }

        public async Task<IEnumerable<HotelAmenityDTO>> GetAllAmenities()
        {
            IEnumerable<HotelAmenityDTO> amenitiesDTO = _mapper.Map<IEnumerable<HotelAmenity>, IEnumerable<HotelAmenityDTO>>(_db.HotelAmenities);
            return amenitiesDTO;
        }

        public async Task<HotelAmenityDTO> GetAmenityById(int amenityId)
        {
            var amenity = await _db.HotelAmenities.FindAsync(amenityId);
            if (amenity == null) return null;
            return _mapper.Map<HotelAmenity, HotelAmenityDTO>(amenity);
        
        }

        public async Task<bool> IsAmenityNameUnique(string name, int amenityId = 0)
        {
            if (amenityId != 0)
            {
                var isNameTaken = await _db.HotelAmenities.AnyAsync(x => x.Name == name && x.Id != amenityId);
                return !isNameTaken;
            }
            else
            {
                var isNameTaken = await _db.HotelAmenities.AnyAsync(x => x.Name == name);
                return !isNameTaken;
            }
        }

        public async Task<HotelAmenityDTO> UpdateAmenity(HotelAmenityDTO updatedAmenityDTO, int amenityId)
        {
            var amenity = await _db.HotelAmenities.FindAsync(amenityId);
            var amenityToUpdate = _mapper.Map<HotelAmenityDTO, HotelAmenity>(updatedAmenityDTO, amenity);
            amenityToUpdate.UpdateTime = DateTime.Now;
            amenityToUpdate.UpdatedBy = "";

            //nie zapisuje w bazie danych!
            var updatedAmenity = _db.HotelAmenities.Update(amenityToUpdate);
            await _db.SaveChangesAsync();
            return _mapper.Map<HotelAmenity, HotelAmenityDTO>(updatedAmenity.Entity);
        }
        #endregion
    }
}
