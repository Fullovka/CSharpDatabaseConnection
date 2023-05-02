using Database_connection.Context;
using Database_connection.Short;
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
        public MainDBContext _db;
        public PagePost pagePost;

        List <EmployeeShort> emplList = new List <EmployeeShort>();

        BaseFilter filter = new BaseFilter();

        public MainForm()
        {
            InitializeComponent();

            this.Hide();
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
                    pagePost = new PagePost();
                    TabPage tabPage = new TabPage();
                    tabPage2.Text = "Должности";

                    pagePost.Controls.Add(pagePost);
                    tabControl1.TabPages.Add(tabPage2);
                }

                _db = new MainDBContext();

                loadEmpl();
                this.Show();
            }
        }
    }
}
