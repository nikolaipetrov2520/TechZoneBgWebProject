namespace TechZoneBgWebProject.Services.Devices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public interface IDevicesService
    {
        Task<List<DevicesListingViewModel>> GetAllAsync(string search = null);

        Task<List<DevicesListingViewModel>> GetAllInspectingAsync();

        Task<List<DevicesListingViewModel>> GetAllInspectedAsync();

        Task<DeviceNotInspectedImputModel> GetNotInspectedByIdAsync(int id);

        Task<DeviceNotInspectedImputModel> GetNotInspectedWithNotWalidEmaiByIdAsync(int id);

        Task<DeviceDetailsViewModel> GetByIdAsync(int id);

        Task ChangeStatusByIdAsync(int id, int statusId);

        Task InspectAsync(DeviceNotInspectedImputModel input, string userId);

        Task CreateAsync(DeviceCreateInputModel input);

        Task<List<DevicesListingViewModel>> GetAllInSaleAsync();

        Task<List<DevicesListingViewModel>> GetAllNotBayedAsync();

        Task<List<DevicesListingViewModel>> GetAllComplaintAsync();

        Task<List<DevicesListingViewModel>> GetAllInRepairAsync();

        Task<List<DevicesListingViewModel>> GetAllArchiveAsync();

        Task<List<DevicesListingViewModel>> GetAllOutletAsync();

        Task<List<DevicesListingViewModel>> GetAllShootingAsync();

        Task<List<DevicesListingViewModel>> GetAllStatusChangedAsync();
    }
}
