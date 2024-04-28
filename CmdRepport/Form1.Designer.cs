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
        /// 
        /*
        private double CalculateFuelConsumption(double fuelValue, double distanceTraveled)
        {
            if (distanceTraveled <= 0)
            {
                return 0;
            }
            return (fuelValue / distanceTraveled) * 100;
        }*/

        /*
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
        */
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_count = new System.Windows.Forms.Button();
            this.txtBox_valueFuel = new System.Windows.Forms.TextBox();
            this.txtBox_valueDistance = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_theme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_fuelConsumptionFromDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(389, 374);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(75, 23);
            this.btn_count.TabIndex = 0;
            this.btn_count.Text = "Расчитать";
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
            this.txtBox_valueDistance.Location = new System.Drawing.Point(364, 161);
            this.txtBox_valueDistance.Name = "txtBox_valueDistance";
            this.txtBox_valueDistance.Size = new System.Drawing.Size(100, 20);
            this.txtBox_valueDistance.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(335, 411);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите кол-во топлива, которое вы заправили во второй раз:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во километров проехали с момента последней заправки:";
            // 
            // btn_theme
            // 
            this.btn_theme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_theme.BackgroundImage")));
            this.btn_theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_theme.Location = new System.Drawing.Point(647, 12);
            this.btn_theme.Name = "btn_theme";
            this.btn_theme.Size = new System.Drawing.Size(131, 24);
            this.btn_theme.TabIndex = 6;
            this.btn_theme.Text = "День/Ночь";
            this.btn_theme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_theme.UseVisualStyleBackColor = true;
            this.btn_theme.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(501, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(501, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(354, 374);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 23);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Укажите марку авто:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 154);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(229, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Можно расчитать при необходимости*";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Укажите объем двигателя:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(1, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Укажите модель авто:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Средний ";
            // 
            // lbl_fuelConsumptionFromDB
            // 
            this.lbl_fuelConsumptionFromDB.AutoSize = true;
            this.lbl_fuelConsumptionFromDB.Location = new System.Drawing.Point(169, 425);
            this.lbl_fuelConsumptionFromDB.Name = "lbl_fuelConsumptionFromDB";
            this.lbl_fuelConsumptionFromDB.Size = new System.Drawing.Size(0, 13);
            this.lbl_fuelConsumptionFromDB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_fuelConsumptionFromDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_theme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txtBox_valueDistance);
            this.Controls.Add(this.txtBox_valueFuel);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Honda Forever";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}

