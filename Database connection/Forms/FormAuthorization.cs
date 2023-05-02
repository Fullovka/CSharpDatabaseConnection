using Database_connection.Context;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

            if (_db.Accounts.Any(u => u.Login == Login))
            {
                var accountList = _db.Account_Roles.Where(s => s.Account.Login == Login).Select(u => new
                {
                    u.Account.Email,
                    u.Role.Name,
                    EmployeeName = u.Account.Employee.Name,
                    u.Account.Employee.Surname,
                    u.Account.Employee.Patronymic,
                    u.Account.Employee.HireDate
                }).ToList();

                var hireDate = accountList[0].HireDate.ToString("D");
                string forHash = $"{accountList[0].Email}{Login}{Password}{accountList[0].Name}" + 
                                 $"{accountList[0].Surname}{accountList[0].Patronymic}{hireDate}";

                byte[] passwordByte = SHA512.Create().ComputeHash(Encoding.BigEndianUnicode.GetBytes(forHash));

                if (_db.Accounts.Any(u => u.Login == Login && u.Password == passwordByte))
                {
                    MessageBox.Show("Вход подтверждён");
                    TheAccess = true;
                    TheAccountRole = accountList[0].Name;

                    this.Close();
                }
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
                MessageBox.Show("Неверный логин");
        }
    }
}
