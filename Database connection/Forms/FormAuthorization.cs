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
            
        }
    }
}
