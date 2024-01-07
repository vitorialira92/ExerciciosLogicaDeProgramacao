using Logica;

namespace FrontEnd.ExerciciosPages
{
    partial class Exercicio1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 832);
            this.Text = "Exercício 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            FormClosed += _FormClosed;

            InitScreen();
        }


          private void InitScreen()
          {
            Button homepageButton = new System.Windows.Forms.Button();
            homepageButton.Location = new Point(54, 46);
            homepageButton.Size = new Size(40, 43);
            homepageButton.FlatStyle = FlatStyle.Flat;
            homepageButton.FlatAppearance.BorderSize = 0;
            homepageButton.Cursor = Cursors.Hand;
            homepageButton.Image = Image.FromFile(@"ExerciciosPages\home.png");
            homepageButton.Click += new EventHandler((object sender, EventArgs e) =>
            {
                this.Hide();
                new HomePage().Show();
            });

            this.Controls.Add(homepageButton);

            Label label = new Label();
            label.Text = "Celsius";
            label.AutoSize = true;
            label.Location = new Point(170, 278);
            label.Font = new Font("Ubuntu", 28);
            label.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label);

            Label label2 = new Label();
            label2.Text = "Fahrenheint";
            label2.AutoSize = true;
            label2.Location = new Point(170, 348);
            label2.Font = new Font("Ubuntu", 28);
            label2.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label2);

            TextBox celsius = new TextBox();
            celsius.Text = "0";
            celsius.Location = new Point(649, 278);
            celsius.Size = new Size(347, 42);
            

            this.Controls.Add(celsius);

            TextBox fahrenheint = new TextBox();
            fahrenheint.Text = "0";
            fahrenheint.Location = new Point(649, 348);
            fahrenheint.Size = new Size(347, 42);
            fahrenheint.Leave += new EventHandler((object sender, EventArgs e) =>
            {
                if (Double.TryParse(fahrenheint.Text, out double fahrenheintTemp))
                {
                    double newCelcius = Exercicios.FromFahrenheitToCelsius(fahrenheintTemp);
                    celsius.Text = newCelcius.ToString();
                }
                else
                {
                    MessageBox.Show("Entrada inválida");
                    fahrenheint.Text = "0";
                    celsius.Text = "0";
                }

            });

            this.Controls.Add(fahrenheint);

            celsius.Leave += new EventHandler((object sender, EventArgs e) =>
            {
                if (Double.TryParse(celsius.Text, out double celsiusTemp))
                {
                    double newFahrenheit = Exercicios.FromCelsiusToFahrenheit(celsiusTemp);
                    fahrenheint.Text = newFahrenheit.ToString();
                }
                else
                {
                    MessageBox.Show("Entrada inválida");
                    celsius.Text = "0";
                    fahrenheint.Text = "0";
                }

            });
        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}