using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BookshelfForm : Form
    {
        public BookshelfForm()
        {
            InitializeComponent();
        }
        private void BookshelfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AuthorizationForm back = new AuthorizationForm();
            var reply = MessageBox.Show("Вернуться к авторизации?", "Завершение работы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (reply == DialogResult.Yes)
            {
                back.Show();
            }
            else if (reply == DialogResult.Cancel)
            {

                e.Cancel = true;
            }
            else
            {
                back.Close();
            }
        }
    }
}
