using CmdRepport.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdRepport
{
    public partial class Form1 : Form
    {
        private FuelTripController fuelTripController;
        private System.Windows.Forms.Label lbl_fuelConsumptionFromDB;

        public Form1()
        {
            InitializeComponent();
            Panel colorPanel = new Panel();
            colorPanel.BackColor = Color.DarkGray; 
            colorPanel.Dock = DockStyle.Top; 
            colorPanel.Height = 30;
            Controls.Add(colorPanel);

            string connectionString = "Data Source=sql5105.site4now.net;Initial Catalog=db_aa7f65_server3;User Id=db_aa7f65_server3_admin;Password=serverOAA3;";
            fuelTripController = new FuelTripController(connectionString);


        }


        private void btn_count_Click(object sender, EventArgs e)
        {
            // Обработка нажатия кнопки для расчета расхода топлива
            fuelTripController.CheckAndDisplayFuelConsumption(txtBox_valueFuel.Text, txtBox_valueDistance.Text, textBox1.Text, textBox2.Text, textBox3.Text, lbl_result);
        }


       
        private void txtBox_valueFuel_TextChanged(object sender, EventArgs e)
        {
            // Проверка и отображение расхода топлива при изменении значения топлива
            fuelTripController.CheckAndDisplayFuelConsumption(txtBox_valueFuel.Text, txtBox_valueDistance.Text, textBox1.Text, textBox2.Text, textBox3.Text, lbl_result);
        }

        private void txtBox_valueDistance_TextChanged(object sender, EventArgs e)
        {
            // Проверка и отображение расхода топлива при изменении значения расстояния
            fuelTripController.CheckAndDisplayFuelConsumption(txtBox_valueFuel.Text, txtBox_valueDistance.Text, textBox1.Text, textBox2.Text, textBox3.Text, lbl_result);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Проверка и отображение расхода топлива при изменении значения объема двигателя
            fuelTripController.CheckAndDisplayFuelConsumption(txtBox_valueFuel.Text, txtBox_valueDistance.Text, textBox1.Text, textBox2.Text, textBox3.Text, lbl_result);
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
    }



}
