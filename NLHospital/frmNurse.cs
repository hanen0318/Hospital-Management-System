using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NLHBaseWindow;
using NLHospitalLibrary;

namespace NLHospital
{
    public partial class frmNurse : NLHBase
    {
        DataSet m_oDS = new DataSet();
        public frmNurse()
        {
            InitializeComponent();
        }

        private void LoadPatients()
        {
            Patients oPatients = new Patients();
            dataGridViewPatients.DataBindings.Clear();
            m_oDS = oPatients.GetData();
            dataGridViewPatients.DataSource = m_oDS.Tables["Patients"];
        }
        private void frmNurse_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }
    }
}
