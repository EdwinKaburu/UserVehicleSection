using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserVehicleSection.Models;
using UserVehicleSection.Models.APIAcess;

namespace UserVehicleSection.Services
{
    public interface IUserServices
    {
        IQueryable<AssignedTechDb> GetAssignedTechDbs { get; }
        IQueryable<MessageDb> GetMessages { get; }
        IQueryable<ServicedHistDb> GetServicedHists { get; }
        IQueryable<ServiceReqDb> GetServiceReqs { get; }
        IQueryable<ShopServicesDb> GetShopServices { get; }
        IQueryable<ShopServicesDb> GetShopServicesDbs { get; }
        IQueryable<ShopTechDb> GetShopTeches { get; }
        IQueryable<ShopTechDb> GetTechDbs { get; }
        IQueryable<UserDb> GetUserDbs { get; }
        IQueryable<UserImgDb> GetUserImgs { get; }
        IQueryable<UserVehDb> GetUserVehs { get; }
        IQueryable<VehReqDb> GetVehReqs { get; }

        Task<bool> CreateAssignedTech(AssignedTechDb assignedTech);
        Task<bool> CreateMessage(MessageDb message);
        Task<bool> CreateServiceHist(ServicedHistDb servicedHist);
        Task<bool> CreateServiceReq(ServiceReqDb serviceReq);
        Task<bool> CreateShopServices(ShopServicesDb shopServices);
        Task<bool> CreateShopTeches(ShopTechDb shopTeches);
        Task<bool> CreateUserImgAsync(UserImgDb userImg);
        Task<bool> CreateUserVeh(UserVehDb userVeh);
        Task<bool> CreateVehReq(VehReqDb vehReq);
        Task<bool> DelMessageObject(MessageDb messageDb);
        Task<bool> DelServiceReqObject(ServiceReqDb serviceReq);
        Task<List<Result>> GetVehichleMakesAsync();
    }
}