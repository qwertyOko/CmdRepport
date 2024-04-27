using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CmdRepport.Controllers
{
    public class FuelTripDBController
    {
        private readonly string connectionString = "Data Source=sql5105.site4now.net;Initial Catalog=db_aa7f65_server3;User Id=db_aa7f65_server3_admin;Password=serverOAA3;";

        public double GetFuelConsumptionFromDatabase(string brand, string model, double engineVolume)
        {
            string query = "SELECT FuelConsumption FROM Cars WHERE Model = @Model AND Brand = @Brand AND EngineVolume = @EngineVolume";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@EngineVolume", engineVolume);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result != null) ? Convert.ToDouble(result) : -1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }

   
}

