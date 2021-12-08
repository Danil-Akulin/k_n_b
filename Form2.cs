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
    public partial class Form2 : Form
    {
        public Button but = new Button();
        private Control button;

        public Form2()
        {
            BackColor = Color.AntiqueWhite;
            this.Height = 900;
            this.Width = 1000;

            this.Controls.Add(button);

            //кнопка для перехода на прошлую форму

            but.Text = "Назад";
            but.Size = new Size(70, 70);
            but.Location = new Point(850, 20);

            //даём кнопке свойства
            but.Click += new EventHandler(but_Click);
            this.Controls.Add(but);






        }

        private void but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обработка");
            Form1 f1 = new Form1();    //переходна вторую форму
            f1.Show();
            this.Hide();
        }

    }
}
