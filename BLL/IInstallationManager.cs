using DTO;

namespace BLL
{
    public interface IInstallationManager
    {
        int AddInstallation(string street, int number, int postcode, string city, string energy, string integration, string pvCells, double orientation, double roof, double length, double width, double area);
        Installation GetInstallation(int registrationNumber);
    }
}