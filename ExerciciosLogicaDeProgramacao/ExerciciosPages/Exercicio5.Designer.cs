using Logica;

namespace FrontEnd.ExerciciosPages
{
    partial class Exercicio5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        TextBox text; Label rsult;

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
            this.Text = "Exercício 5";
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
            label.Text = "Digite uma palavra";
            label.AutoSize = true;
            label.Location = new Point(170, 278);
            label.Font = new System.Drawing.Font("Ubuntu", 28);
            label.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label);

            rsult = new Label();
            rsult.Text = "";
            rsult.AutoSize = true;
            rsult.Location = new Point(1031, 278);
            rsult.Font = new System.Drawing.Font("Ubuntu", 12);
            rsult.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(rsult);

            text = new TextBox();
            text.Text = "";
            text.Location = new Point(649, 278);
            text.Size = new Size(347, 42);


            this.Controls.Add(text);

            Button button = new Button();
            button.Text = "VERIFICAR";
            button.Location = new Point(510, 485);
            button.Size = new Size(278, 66);
            button.Cursor = Cursors.Hand;
            button.Click += new EventHandler(buttonClick);
            this.Controls.Add(button);
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (Exercicios.IsStringAPalindrome(text.Text))
            {
                rsult.Text = "É palíndromo";
            }
            else
            {
                rsult.Text = "Não é palíndromo";
            }
        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}