using DAL;
using DTO;
using System;

namespace BLL
{
    public class InstallationManager : IInstallationManager
    {

        private IInstallationDB InstallationDB { get; }

        public InstallationManager(IInstallationDB installationDB)
        {
            InstallationDB = installationDB;
        }

        public Installation GetInstallation(int registrationNumber)
        {
            return InstallationDB.getInstallationByRegisteredNumber(registrationNumber);
        }

        public int AddInstallation(string street, int number, int postcode, string city, string energy, string integration,
            String pvCells, double orientation, double roof, double length, double width, double area)
        {
            return InstallationDB.AddInstallation(street, number, postcode, city, energy, integration, pvCells, orientation, roof, length, width, area);
        }
    }
}
