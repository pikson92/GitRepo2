using EasyArchive.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyArchive
{
    public partial class mainForm1 : Form
    {

        ActivityLogger _activityLogger;
        public mainForm1()
        {
            InitializeComponent();

            _activityLogger = new ActivityLogger(new LabelDisplay(lblStatus));
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnCancelclicked");
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _activityLogger.Show("btnAddclicked");

            if (string.IsNullOrEmpty(textLogin.Text))
            {

                MessageBox.Show("Login is required", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /*
             * 
             *   add user to archive
             */

            if (!CheckLoginUniqeless())
            {
                MessageBox.Show("Given login is not unique. Change it!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public bool CheckLoginUniqeless ()
        {
            return true;
       }

    }
}