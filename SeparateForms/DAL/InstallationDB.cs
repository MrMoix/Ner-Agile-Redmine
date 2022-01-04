using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class InstallationDB : IInstallationDB
    {

        private IConfiguration Configuration { get; }
        private String ConnectionString { get; }

        public InstallationDB(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("MyConnection");

        }

        public Installation getInstallationByRegisteredNumber(int registrationNumber)
        {
            Installation installation = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = "Select * from Installation where RegistrationNumber = @registrationNumber";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            installation = new Installation();
                            installation.RegistrationNumber = (int)dr["registrationNumber"];

                            if (dr["street"] != DBNull.Value)
                                installation.Street = (string)dr["street"];
                            if (dr["number"] != DBNull.Value)
                                installation.Number = (int)dr["number"];
                            if (dr["postcode"] != DBNull.Value)
                                installation.Postcode = (int)dr["postcode"];
                            if (dr["city"] != DBNull.Value)
                                installation.City = (String)dr["city"];
                            if (dr["energy"] != DBNull.Value)
                                installation.Energy = (String)dr["energy"];
                            if (dr["integration"] != DBNull.Value)
                                installation.Integration = (String)dr["integration"];
                            if (dr["pvCells"] != DBNull.Value)
                                installation.PVCells = (string)dr["pvCells"];
                            if (dr["fieldOrientation"] != DBNull.Value)
                                installation.FieldOrientation = (double)dr["fieldOrientation"];
                            if (dr["slopRoof"] != DBNull.Value)
                                installation.SlopRoof = (double)dr["slopRoof"];
                            if (dr["length"] != DBNull.Value)
                                installation.Length = (double)dr["length"];
                            if (dr["width"] != DBNull.Value)
                                installation.Width = (double)dr["width"];
                            if (dr["area"] != DBNull.Value)
                                installation.Area = (double)dr["area"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return installation;
        }


        public int AddInstallation(String street, int number, int postcode, String city, String energy, String integration,
            String pvCells, double orientation, double roof, double length, double width, double area)
        {


            int result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = "insert into Installation (street, number, postcode, city, energy, integration, pvCells, fieldOrientation, SlopRoof, length, width, area) " +
                        "values(@street, @number, @postcode, @city,@energy,@integration,@pvCells,@orientation,@roof,@length,@width,@area); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@postcode", postcode);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@energy", energy);
                    cmd.Parameters.AddWithValue("@integration", integration);
                    cmd.Parameters.AddWithValue("@pvCells", pvCells);
                    cmd.Parameters.AddWithValue("@orientation", orientation);
                    cmd.Parameters.AddWithValue("@roof", roof);
                    cmd.Parameters.AddWithValue("@length", length);
                    cmd.Parameters.AddWithValue("@width", width);
                    cmd.Parameters.AddWithValue("@area", area);


                    cn.Open();

                    result = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }

    }
}
