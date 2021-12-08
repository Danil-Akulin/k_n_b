using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bumashka
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox picb;

        public Button but = new Button();
        private Control button;

        public Button but2 = new Button();
        private Control button2;

        private TextBox txt = new TextBox();
        private Control text;


        public Form1()
        {
            //отвечает за размер / цвет окна
            BackColor = Color.AntiqueWhite;
            this.Height = 900;
            this.Width = 1000;
            this.Text = "kivi paber käärid";
            this.Controls.Add(button);
            this.Controls.Add(button);


            //////////////////////////////////////////////////////////

            //кнопка для игры с другом
            InitializeComponent();
            but2.Text = "Начать играть с другом";
            but2.Size = new Size(100, 100);
            but2.Location = new Point(650, 300);

            //даём кнопке свойства
            but2.Click += new EventHandler(but2_Click);
            this.Controls.Add(but2);


            //////////////////////////////////////////////////////////

            //кнопка для игры одному
            InitializeComponent();
            but.Text = "Начать играть одному";
            but.Size = new Size(100, 100);
            but.Location = new Point(50, 300);

            //даём кнопке свойства
            but.Click += new EventHandler(but_Click);
            this.Controls.Add(but);
        }

        /////////////////////////////////////////////////////////
        public void CreateMyTextBoxControl()
        {
            // Create a new TextBox control using this constructor.
            TextBox textBox1 = new TextBox();
            // Assign a string of text to the new TextBox control.
            textBox1.Text = "Hello World!";
            // Code goes here to add the control to the form's control collection.
        }

        /////////////

        private void but2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обработкf");
            Form3 f3 = new Form3();   //переходна вторую форму
            f3.Show();
            this.Hide();
        }

        private void but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обработка");
            Form2 f2 = new Form2();    //переходна вторую форму
            f2.Show();
            this.Hide();
        }
    }
}