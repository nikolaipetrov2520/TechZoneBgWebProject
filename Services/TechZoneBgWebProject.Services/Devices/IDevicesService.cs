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
        Task<List<DevicesListingViewModel>> GetAllAsync();
    }
}
