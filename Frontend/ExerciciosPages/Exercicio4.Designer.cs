using Logica;

namespace FrontEnd.ExerciciosPages
{
    partial class Exercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        TextBox text; Label rsult; Label currentList;

        List<int> numbers = new List<int>();

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
            this.Text = "Exercício 4";
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
            label.Text = "Digite um número: ";
            label.AutoSize = true;
            label.Location = new Point(170, 278);
            label.Font = new System.Drawing.Font("Ubuntu", 28);
            label.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label);

            rsult = new Label();
            rsult.Text = "";
            rsult.AutoSize = true;
            rsult.Location = new Point(170, 580);
            rsult.Font = new System.Drawing.Font("Ubuntu", 12);
            rsult.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(rsult);

            text = new TextBox();
            text.Text = "";
            text.Location = new Point(649, 278);
            text.Size = new Size(347, 42);
            text.KeyPress += new KeyPressEventHandler((object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            });

            this.Controls.Add(text);

            currentList = new Label();
            currentList.Text = "Lista atual:";
            currentList.AutoSize = true;
            currentList.Location = new Point(170, 135);
            currentList.Font = new System.Drawing.Font("Ubuntu", 12);
            currentList.ForeColor = ColorTranslator.FromHtml("#7DA5FA");
            this.Controls.Add(currentList);

            Button add = new Button();
            add.Text = "Add";
            add.Location = new Point(1044, 278);
            add.Size = new Size(104, 43);
            add.Cursor = Cursors.Hand;
            add.Click += new EventHandler(buttonAddClick);
            this.Controls.Add(add);

            Button button = new Button();
            button.Text = "ORDENAR";
            button.Location = new Point(510, 485);
            button.Size = new Size(278, 66);
            button.Cursor = Cursors.Hand;
            button.Click += new EventHandler(buttonClick);
            this.Controls.Add(button);
        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            if(int.TryParse(text.Text, out int number))
            {
                numbers.Add(number);
                if (numbers.Count == 1)
                    currentList.Text += number;
                else
                    currentList.Text += ", " + number;
                text.Text = "";
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            List<int> orderedList = Exercicios.OrderListOfNumber(numbers);
            rsult.Text = "Lista ordenada: ";
            foreach(var n in orderedList)
            {
                rsult.Text += n +", ";
            }
            rsult.Text = rsult.Text.Substring(0, rsult.Text.Length - 2);
        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}