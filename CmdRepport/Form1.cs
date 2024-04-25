using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdRepport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Panel colorPanel = new Panel();
            colorPanel.BackColor = Color.DarkGray; 
            colorPanel.Dock = DockStyle.Top; 
            colorPanel.Height = 30; 
            Controls.Add(colorPanel); 
                                      



        }
     
        public double CalculateFuelConsumption(double fuelValue, double distanceTraveled)
        {
            if (distanceTraveled <= 0)
            {
                return 0;
            }
            return (fuelValue / distanceTraveled) * 100;
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            double fuelValue;
            double distanceTraveled;

            if (double.TryParse(txtBox_valueFuel.Text, out fuelValue) &&
                double.TryParse(txtBox_valueDistance.Text, out distanceTraveled))
            {
                double consumption = CalculateFuelConsumption(fuelValue, distanceTraveled);
                lbl_result.Text = string.Format("Расход топлива составляет {0:0.00} л на 100 км", consumption);
                UpdateDatabase(consumption);
            }
            else
            {
                lbl_result.Text = "Ошибка: Введите корректные значения.";
            }
        }

        /*
          private void UpdateDatabase(double fuelConsumption)
          {
              string model = textBox1.Text;
              string brand = textBox2.Text;
              double engineVolume;
              if (!double.TryParse(textBox3.Text, out engineVolume))
              {
                  MessageBox.Show("Введите корректный объем двигателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
              }

              string connectionString =
                  "Data Source=sql5105.site4now.net;Initial Catalog=db_aa7f65_server3;User Id = db_aa7f65_server3_admin; Password = serverOAA3;";



              string insertQuery = @"
                  INSERT INTO Cars (Model, Brand, EngineVolume, Consumption)
                  VALUES (@Model, @Brand, @EngineVolume, @Consumption)";

              using (SqlConnection connection = new SqlConnection(connectionString))
              {
                  using (SqlCommand command = new SqlCommand(insertQuery, connection))
                  {
                      command.Parameters.AddWithValue("@Model", model);
                      command.Parameters.AddWithValue("@Brand", brand);
                      command.Parameters.AddWithValue("@EngineVolume", engineVolume);
                      command.Parameters.AddWithValue("@Consumption", fuelConsumption);

                      connection.Open();
                      command.ExecuteNonQuery();
                  }
              }
          }

          */

        private void UpdateDatabase(double fuelConsumption)
        {
            string model = textBox1.Text;
            string brand = textBox2.Text;
            double engineVolume;
            if (!double.TryParse(textBox3.Text, out engineVolume))
            {
                MessageBox.Show("Введите корректный объем двигателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=sql5105.site4now.net;Initial Catalog=db_aa7f65_server3;User Id=db_aa7f65_server3_admin;Password=serverOAA3;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = @"
        INSERT INTO Cars (Model, Brand, EngineVolume, FuelConsumption) 
        VALUES (@Model, @Brand, @EngineVolume, @FuelConsumption)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@EngineVolume", engineVolume);
                    command.Parameters.AddWithValue("@FuelConsumption", fuelConsumption);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }


        }
        private void txtBox_valueFuel_TextChanged(object sender, EventArgs e)
        {
            CheckAndDisplayFuelConsumption();
        }

        private void txtBox_valueDistance_TextChanged(object sender, EventArgs e)
        {
            CheckAndDisplayFuelConsumption();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CheckAndDisplayFuelConsumption();
        }

        private void CheckAndDisplayFuelConsumption()
        {
            string model = textBox1.Text;
            string brand = textBox2.Text;
            double engineVolume;
            if (!double.TryParse(textBox3.Text, out engineVolume))
            {
                lbl_result.Text = "Введите корректный объем двигателя";
                return;
            }

            string connectionString = "Data Source=sql5105.site4now.net;Initial Catalog=db_aa7f65_server3;User Id=db_aa7f65_server3_admin;Password=serverOAA3;";
            string selectQuery = @"
                        SELECT Consumption
                        FROM Cars
                        WHERE Model = @Model AND Brand = @Brand AND EngineVolume = @EngineVolume";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@EngineVolume", engineVolume);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        double consumption;
                        if (double.TryParse(result.ToString(), out consumption))
                        {
                            lbl_result.Text = string.Format("Расход топлива составляет {0:0.00} л на 100 км", consumption);
                        }
                        else
                        {
                            lbl_result.Text = "Ошибка при получении данных из базы данных";
                        }
                    }
                    else
                    {
                        lbl_result.Text = "Данные по указанным параметрам не найдены в базе данных";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.Black)
            {
                this.BackColor = System.Drawing.Color.White;
                lbl_result.ForeColor = System.Drawing.Color.Black;
                label2.ForeColor = System.Drawing.Color.Black;
                label3.ForeColor = System.Drawing.Color.Black;

                label6.ForeColor = System.Drawing.Color.Black;

            }
            else
            {
                this.BackColor = System.Drawing.Color.Black;
                lbl_result.ForeColor = System.Drawing.Color.White;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;

                label6.ForeColor = System.Drawing.Color.White;

            }
        }

       
    }

      
    
}
