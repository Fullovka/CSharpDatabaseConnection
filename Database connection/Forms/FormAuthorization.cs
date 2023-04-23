using Database_connection.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_connection
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            _db = new MainDBContext();
        }

        public MainDBContext _db;

        public bool TheAccess = false;
        public string TheAccountRole;

        private void PasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = PasswordVisibility.Checked ? '\0' : '*';
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            string Login = textBoxLogin.Text;
            string Password = textBoxPassword.Text;

            bool isAuthenticated = users.Any(u => u.Login == login && u.Password == password);

            if (isAuthenticated)
            {
                // Если пользователь найден, открываем главную форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Если пользователь не найден, выводим сообщение об ошибке
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
