using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void PassCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (PassCheckBox.Checked)
            {
                PassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            BookshelfForm login = new BookshelfForm();
            if (LoginTextBox.Text == "admin" && PassTextBox.Text == "1")
            {
                this.Hide();
                login.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль","Ошибка");
            }
        }
    }
}
