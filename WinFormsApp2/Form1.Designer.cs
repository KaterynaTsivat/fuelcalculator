using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        static double length = 0;
        static double avFuelConsumption = 0;
        static double price = 0;
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Онлайн калькулятор";
            this.BackColor = System.Drawing.Color.FromArgb(241, 212, 212);
            this.Size = new System.Drawing.Size(400, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.MaximumSize = this.Size;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Icon = new Icon("logo.ico");

            color = new Label();
            this.color.Location = new System.Drawing.Point(0, 0);
            this.color.Size = new System.Drawing.Size(400, 45);
            this.color.BackColor = System.Drawing.Color.FromArgb(172, 141, 175);
            Controls.Add(color);

            Text_online_label = new Label();
            this.Text_online_label.Text = "Онлайн калькулятор \n  по расходу топлива";
            this.Text_online_label.Font = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            this.Text_online_label.ForeColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.Text_online_label.Location = new System.Drawing.Point(90, 55);
            this.Text_online_label.Size = new System.Drawing.Size(400, 45);
            Controls.Add(Text_online_label);

            how_label = new Label();
            this.how_label.Text = "Сколько хотите проехать \n(км)";
            this.how_label.Location = new System.Drawing.Point(20, 120);
            this.how_label.Size = new System.Drawing.Size(200, 50);
            this.how_label.ForeColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.how_label.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Pixel);
            Controls.Add(how_label);

            how_TextBox = new TextBox();
            how_TextBox.Location = new System.Drawing.Point(250, 125);
            how_TextBox.TextChanged += UserName_TextBox_TextChanged;
            this.Controls.Add(how_TextBox);

            average_label = new Label();
            this.average_label.Text = "Средний расход топлива \n(л /100 км)";
            this.average_label.Location = new System.Drawing.Point(20, 185);
            this.average_label.Size = new System.Drawing.Size(200, 50);
            this.average_label.ForeColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.average_label.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Pixel);
            Controls.Add(average_label);

            average_TextBox = new TextBox();
            average_TextBox.Location = new System.Drawing.Point(250, 190);
            average_TextBox.TextChanged += UserName_TextBox_TextChanged;
            this.Controls.Add(average_TextBox);

            price_label = new Label();
            this.price_label.Text = "Стоимость 1л топлива \n(руб)";
            this.price_label.Location = new System.Drawing.Point(20, 250);
            this.price_label.Size = new System.Drawing.Size(200, 50);
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.price_label.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Pixel);
            Controls.Add(price_label);

            price_TextBox = new TextBox();
            price_TextBox.Location = new System.Drawing.Point(250, 255);
            price_TextBox.TextChanged += UserName_TextBox_TextChanged;
            this.Controls.Add(price_TextBox);

            this.button.Location = new System.Drawing.Point(40, 300);
            this.button.Text = "Рассчитать";
            this.button.Enabled = false;
            this.button.BackColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.button.ForeColor = System.Drawing.Color.FromArgb(241, 212, 212);
            this.button.Font = new Font("Times New Roman", 18, FontStyle.Bold, GraphicsUnit.Pixel);
            this.button.Size = new Size(150, 50);
            this.button.Click += (sender, e) =>
            { 
                if(!double.TryParse(how_TextBox.Text, out length) ||
                !double.TryParse(average_TextBox.Text, out avFuelConsumption) ||
                !double.TryParse(price_TextBox.Text, out price))
                {
                    color2.Text = "Некорректный ввод";
                    color2.Font = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
                    color2.ForeColor = Color.Black;
                }
                else
                {
                    length = Convert.ToDouble(how_TextBox.Text);    
                    avFuelConsumption = Convert.ToDouble(average_TextBox.Text);
                    price = Convert.ToDouble(price_TextBox.Text);
                    if (length <= 0 || avFuelConsumption <= 0 || price <= 0)
                    {
                        color2.Text = "Некорректный ввод \nчисло не может быть меньше 0";
                        color2.Font = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
                        color2.ForeColor = Color.Black;
                    }
                    else
                    {
                        double FuelNeed = ((avFuelConsumption * length) / 100);
                        need_label2.Text = FuelNeed.ToString();
                        double costFuel = FuelNeed * price;
                        cost_label2.Text = costFuel.ToString();
                    }
                }
            };
            this.Controls.Add(this.button);

            
            this.buttonClear.Location = new System.Drawing.Point(190, 300);
            this.buttonClear.Text = "Очистить";
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(241, 212, 212);
            this.buttonClear.Font = new Font("Times New Roman", 18, FontStyle.Bold, GraphicsUnit.Pixel);
            this.buttonClear.Size = new Size(150, 50);
            this.buttonClear.Click += (sender, e) =>
            {
                price_TextBox.Clear();
                average_TextBox.Clear();
                how_TextBox.Clear();
                if(color2.Text.Length != 0)
                {
                    color2.Text = " "; 
                }
            };
            this.Controls.Add(this.buttonClear);


            need_label = new Label();
            this.need_label.Text = "Потребуется топлива \n(л)";
            this.need_label.Location = new System.Drawing.Point(20, 375);
            this.need_label.Size = new System.Drawing.Size(200, 50);
            this.need_label.ForeColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.need_label.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Pixel);
            Controls.Add(need_label);


            need_label2 = new Label();
            this.need_label2.Text = String.Empty;
                // $"{FuelNeed}";
            this.need_label2.Location = new System.Drawing.Point(250, 375);
            this.need_label2.Size = new System.Drawing.Size(100, 25);
            this.need_label2.BackColor = Color.White;
            Controls.Add(need_label2);

            cost_label = new Label();
            this.cost_label.Text = "Стоимость топлива \n(руб)";
            this.cost_label.Location = new System.Drawing.Point(20, 440);
            this.cost_label.Size = new System.Drawing.Size(200, 50);
            this.cost_label.ForeColor = System.Drawing.Color.FromArgb(72, 76, 127);
            this.cost_label.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Pixel);
            Controls.Add(cost_label);

            cost_label2 = new Label();
            this.cost_label2.Text = String.Empty;
            this.cost_label2.Location = new System.Drawing.Point(250, 440);
            this.cost_label2.Size = new System.Drawing.Size(100, 25);
            this.cost_label2.BackColor = Color.White;
            Controls.Add(cost_label2);

            color2 = new Label();
            this.color2.Location = new System.Drawing.Point(0, 508);
            this.color2.Size = new System.Drawing.Size(400, 45);
            this.color2.BackColor = System.Drawing.Color.FromArgb(172, 141, 175);
            Controls.Add(color2);
        }

        private void UserName_TextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (how_label.Text.Length >= 1 && average_TextBox.Text.Length >= 1 && price_TextBox.Text.Length >= 1)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }



        Label Text_online_label;
        Label color;
        Label how_label;
        Label average_label;
        Label price_label;
        Label color2;
        TextBox how_TextBox;
        TextBox average_TextBox;
        TextBox price_TextBox;
        Label need_label;
        Label cost_label;
        Label need_label2;
        Label cost_label2;
        Button button = new Button();
        Button buttonClear = new Button(); 
        #endregion
    }
}
