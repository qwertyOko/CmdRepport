using System;

namespace CmdRepport
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 

        /// <param name="fuelValue">Amount of fuel refilled (in liters)</param>
        /// <param name="distanceTraveled">Distance traveled since last refill (in kilometers)</param>
        /// <returns>Fuel consumption in liters per 100 kilometers</returns>
        private double CalculateFuelConsumption(double fuelValue, double distanceTraveled)
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
                lbl_result.Text = String.Format("Расход топлива составляет {0:0.00} л на 100км", consumption); 
            }
            else
            {
                this.lbl_result.Text = "Ошибка: Введите корректные значения.";
            }
        }

        private void InitializeComponent()
        {
            this.btn_count = new System.Windows.Forms.Button();
            this.txtBox_valueFuel = new System.Windows.Forms.TextBox();
            this.txtBox_valueDistance = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_theme = new System.Windows.Forms.Button();
            btn_theme.Click += new System.EventHandler(this.button2_Click);
            this.SuspendLayout();
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(389, 339);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(75, 23);
            this.btn_count.TabIndex = 0;
            this.btn_count.Text = "Расчитать.";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // txtBox_valueFuel
            // 
            this.txtBox_valueFuel.Location = new System.Drawing.Point(364, 112);
            this.txtBox_valueFuel.Name = "txtBox_valueFuel";
            this.txtBox_valueFuel.Size = new System.Drawing.Size(100, 20);
            this.txtBox_valueFuel.TabIndex = 1;
            // 
            // txtBox_valueDistance
            // 
            this.txtBox_valueDistance.Location = new System.Drawing.Point(364, 183);
            this.txtBox_valueDistance.Name = "txtBox_valueDistance";
            this.txtBox_valueDistance.Size = new System.Drawing.Size(100, 20);
            this.txtBox_valueDistance.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(329, 396);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите кол-во топлива, которое вы заправили во второй раз:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во километров проехали с момента последней заправки:";
            // 
            // btn_theme
            // 
            this.btn_theme.Location = new System.Drawing.Point(703, 12);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(75, 23);
            this.btn_theme.TabIndex = 6;
            this.btn_theme.Text = "День/Ночь";
            this.btn_theme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_theme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txtBox_valueDistance);
            this.Controls.Add(this.txtBox_valueFuel);
            this.Controls.Add(this.btn_count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.TextBox txtBox_valueFuel;
        private System.Windows.Forms.TextBox txtBox_valueDistance;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_theme;
    }
}

