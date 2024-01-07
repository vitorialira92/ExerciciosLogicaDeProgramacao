
using FrontEnd.ExerciciosPages;

namespace FrontEnd
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox options;
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
            this.Text = "ExercíciosLP";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            FormClosed += _FormClosed;

            InitScreen();
        }

        private void InitScreen()
        {
            Label label = new Label();
            label.Text = "Escolha um exercício";
            label.AutoSize = true;
            label.Location = new Point(400, 268);
            label.Font = new Font("Ubuntu", 28);
            label.ForeColor = ColorTranslator.FromHtml("#7DA5FA");

            this.Controls.Add(label);

           options = new ComboBox();
            options.Location = new Point(560, 359);
            for(int i = 0; i < 10; i++)
            {
                options.Items.Add($"Exercício {i+1}");
            }
            options.SelectedIndex = 0;
            options.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Controls.Add(options);

            Button button = new Button();
            button.Text = "ABRIR";
            button.Location = new Point(510,485);
            button.Size = new Size(278, 66);
            button.Cursor = Cursors.Hand;
            button.Click += new EventHandler(buttonClick);
            this.Controls.Add(button);

        }

        private void buttonClick(object sender, EventArgs e)
        {
            switch (options.SelectedIndex)
            {
                case 0:
                    new Exercicio1().Show();
                    this.Hide();
                    break;
                case 1:
                    new Exercicio2().Show();
                    this.Hide();
                    break;
                case 2:
                    new Exercicio3().Show();
                    this.Hide();
                    break; 
                case 3:
                    new Exercicio4().Show();
                    this.Hide();
                    break;
                case 4:
                    new Exercicio5().Show();
                    this.Hide();
                    break; 
                case 5:
                    new Exercicio6().Show();
                    this.Hide();
                    break;
                case 6:
                    new Exercicio7().Show();
                    this.Hide();
                    break;
                case 7:
                    new Exercicio8().Show();
                    this.Hide();
                    break;
                case 8:
                    new Exercicio9().Show();
                    this.Hide();
                    break;
                case 9:
                    new Exercicio10().Show();
                    this.Hide();
                    break;
            }

        }

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
