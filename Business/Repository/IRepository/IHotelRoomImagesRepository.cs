using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomImagesRepository
    {
        Task<int> CreateHotelRoomImage(HotelRoomImageDTO image);
        Task<int> DeleteHotelRoomImageByImageId(int imageId);
        Task<int> DeleteHotelRoomImageByRoomId(int roomId);
        Task<int> DeleteHotelRoomImageByImageUrl(string imageUrl);
        Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImages(int roomId);

    }
}
