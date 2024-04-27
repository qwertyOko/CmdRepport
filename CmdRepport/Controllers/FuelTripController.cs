using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CmdRepport.Controllers
{
    public class FuelTripController
    {
        private readonly FuelTripDBController dbController;
        private readonly string connectionString;

        public FuelTripController(string connectionString)
        {
            this.connectionString = connectionString;
            dbController = new FuelTripDBController();
        }

        public void btn_displayFromDB_Click(string model, string brand, double engineVolume, Label lbl_fuelConsumptionFromDB)
        {
            double fuelConsumptionFromDB = dbController.GetFuelConsumptionFromDatabase(brand, model, engineVolume);

            if (fuelConsumptionFromDB != -1)
            {
                lbl_fuelConsumptionFromDB.Text = $"Расход топлива из базы данных: {fuelConsumptionFromDB:0.00} л на 100 км";
            }
            else
            {
                lbl_fuelConsumptionFromDB.Text = "Данные в базе данных не найдены";
            }
        }

        public double CalculateFuelConsumption(double fuelValue, double distanceTraveled, string brand, string model, double engineVolume)
        {
            if (distanceTraveled <= 0)
            {
                return 0;
            }

            double fuelConsumption = (fuelValue / distanceTraveled) * 100;

            double fuelConsumptionFromDB = dbController.GetFuelConsumptionFromDatabase(brand, model, engineVolume);
            if (fuelConsumptionFromDB != -1)
            {
                // Здесь не выводим на форму, а просто возвращаем значение из базы данных
                return fuelConsumptionFromDB;
            }
            else
            {
                return fuelConsumption;
            }
        }

        private void UpdateDatabase(string brand, string model, double engineVolume, double fuelConsumption)
        {
            string insertQuery = @"
                INSERT INTO Cars (Brand, Model, EngineVolume, FuelConsumption) 
                VALUES (@Brand, @Model, @EngineVolume, @FuelConsumption)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@EngineVolume", engineVolume);
                command.Parameters.AddWithValue("@FuelConsumption", fuelConsumption);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CheckAndDisplayFuelConsumption(string fuelValueText, string distanceTraveledText, string model, string brand, string engineVolumeText, Label lbl_result)
        {
            if (double.TryParse(fuelValueText, out double fuelValue) &&
                double.TryParse(distanceTraveledText, out double distanceTraveled) &&
                double.TryParse(engineVolumeText, out double engineVolume))
            {
                // Рассчитываем средний расход топлива на 100 км
                double averageFuelConsumption = CalculateFuelConsumption(fuelValue, distanceTraveled, brand, model, engineVolume);

                // Получаем расход топлива из базы данных
                double fuelConsumptionFromDB = dbController.GetFuelConsumptionFromDatabase(brand, model, engineVolume);

                // Проверяем, получено ли значение из базы данных
                if (fuelConsumptionFromDB != -1)
                {
                    lbl_result.Text = string.Format("Расход топлива: {0:0.00} л/100 км (из базы данных: {1:0.00} л/100 км)", averageFuelConsumption, fuelConsumptionFromDB);
                }
                else
                {
                    lbl_result.Text = string.Format("Расход топлива: {0:0.00} л/100 км (рассчитанное значение)", averageFuelConsumption);

                    // Обновляем базу данных только если данные успешно получены из CalculateFuelConsumption
                    UpdateDatabase(brand, model, engineVolume, averageFuelConsumption);
                }
            }
            else
            {
                lbl_result.Text = "Введите корректные значения.";
            }
        }
    }
}