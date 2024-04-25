using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            colorPanel.BackColor = Color.DarkGray; // Устанавливаем цвет фона полоски
            colorPanel.Dock = DockStyle.Top; // Занимаем верхнюю часть формы
            colorPanel.Height = 30; // Устанавливаем высоту полоски
            Controls.Add(colorPanel); // Добавляем полоску на форму
                                      // Создание и настройка полоски в середине формы
            panel2.BackColor = Color.DarkGray;
            panel3.BackColor = Color.DarkGray;
          
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
