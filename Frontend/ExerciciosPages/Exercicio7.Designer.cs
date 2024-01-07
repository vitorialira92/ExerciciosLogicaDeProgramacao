using Logica;
using static System.Net.Mime.MediaTypeNames;

namespace FrontEnd.ExerciciosPages
{
    partial class Exercicio7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.Text = "Exercício 7";
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
            homepageButton.Image = System.Drawing.Image.FromFile(@"ExerciciosPages\home.png");
            homepageButton.Click += new EventHandler((object sender, EventArgs e) =>
            {
                this.Hide();
                new HomePage().Show();
            });

            this.Controls.Add(homepageButton);

            Label label = new Label();
            label.Text = "Valor em real";
            label.AutoSize = true;
            label.Location = new Point(170, 278);
            label.Font = new System.Drawing.Font("Ubuntu", 28);
            label.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label);

            Label label2 = new Label();
            label2.Text = "Cotação dolar";
            label2.AutoSize = true;
            label2.Location = new Point(170, 348);
            label2.Font = new System.Drawing.Font("Ubuntu", 28);
            label2.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label2);

            Label text = new Label();
            text.Text = "";
            text.Location = new Point(382, 154);
            text.AutoSize = true;
            text.Font = new System.Drawing.Font("Ubuntu", 28);
            text.ForeColor = ColorTranslator.FromHtml("#7DA5FA");
            this.Controls.Add(text);

            TextBox real = new TextBox();
            real.Text = "0";
            real.Location = new Point(649, 278);
            real.Size = new Size(347, 42);


            this.Controls.Add(real);

            TextBox cotacao = new TextBox();
            cotacao.Text = "0";
            cotacao.Location = new Point(649, 348);
            cotacao.Size = new Size(347, 42);
            this.Controls.Add(cotacao);

            Button button = new Button();
            button.Text = "CALCULAR";
            button.Location = new Point(510, 485);
            button.Size = new Size(278, 66);
            button.Cursor = Cursors.Hand;
            button.Click += new EventHandler((object sender, EventArgs e) =>
            {
                if (Double.TryParse(real.Text, out double realValor) && Double.TryParse(cotacao.Text, out double cotacaoValor))
                {
                    double newDolar = Exercicios.HowManyDolarsFromReal(realValor, cotacaoValor);
                    text.Text = $"R${realValor} é equivalente a U${newDolar}";
                }
                else
                {
                    MessageBox.Show("Entrada inválida");
                    text.Text = "";
                }
            });
            this.Controls.Add(button);
        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }
}