namespace TechZoneBgWebProject.Services.PDF
{
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public interface ITemplateGenerator
    {
        string Generate(DeviceDetailsViewModel device);
    }
}
