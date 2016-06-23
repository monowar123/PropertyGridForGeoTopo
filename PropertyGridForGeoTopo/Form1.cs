using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PropertyGridForGeoTopo
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = Settings.GetInstance();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnYesToAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYesToAll.Checked)
            {
                Settings.SetAllTrue();
                propertyGrid1.Refresh();
            }
        }

        private void rbtnNoToAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNoToAll.Checked)
            {
                Settings.SetAllFalse();
                propertyGrid1.Refresh();
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            rbtnYesToAll.Checked = false;
            rbtnNoToAll.Checked = false;
        }


       
    }
}
