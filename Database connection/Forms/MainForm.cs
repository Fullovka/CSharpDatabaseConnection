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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();

            if (!formAuthorization.TheAccess) 
            {
                this.Close();
            }
            else 
            {
                if (formAuthorization.TheAccountRole == "Администратор") 
                {
                    
                }
            }
        }
    }
}
