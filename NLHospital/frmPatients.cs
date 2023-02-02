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
    public partial class frmAdmin : NLHBase
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        DataSet m_oDS = new DataSet();



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void LoadPatientData()
        {
            Patients oPatients = new Patients();
            dataGridViewPatients.DataBindings.Clear();
            m_oDS = oPatients.GetData();
            dataGridViewPatients.DataSource = m_oDS.Tables["Patients"];
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string healthNumber = txtHealthNumber.Text;
            string dateOfBirth = txtDOB.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;
            string phone = txtPhone.Text;
            string insuranceCompany = txtInsuranceCompany.Text;
            string insuranceNumber = txtInsuranceNumber.Text;
            string nextOfKin = txtNextOfKin.Text;
            string nextOfKinRelation = txtNextOfKinRelationship.Text;
            string doctor = txtDoctor.Text;
            string s_msg = "";

            Patients oPatients = new Patients();

            try
            {
                s_msg = oPatients.AddData(lastName, firstName, healthNumber, dateOfBirth, address, city
                    , province, postalCode, phone, insuranceCompany, insuranceNumber, nextOfKin
                    , nextOfKinRelation, doctor);
            }
            catch
            {
                s_msg = "Error saving data." + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(s_msg, "Adding record", MessageBoxButtons.OK);
            }
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string healthNumber = txtHealthNumber.Text;
            string dateOfBirth = txtDOB.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string postalCode = txtPostalCode.Text;
            string phone = txtPhone.Text;
            string insuranceCompany = txtInsuranceCompany.Text;
            string insuranceNumber = txtInsuranceNumber.Text;
            string nextOfKin = txtNextOfKin.Text;
            string nextOfKinRelation = txtNextOfKinRelationship.Text;
            string doctor = txtDoctor.Text;
            string s_msg = "";

            Patients oPatients = new Patients();

            try
            {
                s_msg = oPatients.UpdateData(lastName, firstName, healthNumber, dateOfBirth, address, city
                    , province, postalCode, phone, insuranceCompany, insuranceNumber, nextOfKin
                    , nextOfKinRelation, doctor);
            }
            catch
            {
                s_msg = "Error saving data." + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(s_msg, "Update Data", MessageBoxButtons.OK);
                LoadPatientData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Patients oPatient = new Patients();
            string healthNum = txtHealthNumber.Text;
            string s_msg = "";
            try
            {
                s_msg = oPatient.DeleteData(healthNum);
            }
            catch
            {
                s_msg = "Error Deleting data\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(s_msg, "Deleting Data", MessageBoxButtons.OK);
                LoadPatientData();
            }

            
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadPatientData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Patients oPatient = new Patients();
            DataSet o_find = new DataSet();

            string healthNum = txtSearchID.Text;
            string o_msg = "";

            try
            {
                o_find = oPatient.FindData(healthNum);

                txtHealthNumber.Text = o_find.Tables["Patients"].Rows[0]["HealthNumber"].ToString();
                txtLastName.Text = o_find.Tables["Patients"].Rows[0]["LastName"].ToString();
                txtFirstName.Text = o_find.Tables["Patients"].Rows[0]["FirstName"].ToString();
                txtAddress.Text = o_find.Tables["Patients"].Rows[0]["Address"].ToString();
                txtCity.Text = o_find.Tables["Patients"].Rows[0]["City"].ToString();
                txtProvince.Text = o_find.Tables["Patients"].Rows[0]["Province"].ToString();
                txtPostalCode.Text = o_find.Tables["Patients"].Rows[0].ToString();
                txtPhone.Text = o_find.Tables["Patients"].Rows[0]["Phone"].ToString();
                txtInsuranceCompany.Text = o_find.Tables["Patients"].Rows[0]["InsuranceComapny"].ToString();
                txtHealthNumber.Text = o_find.Tables["Patients"].Rows[0]["InsuranceNumber"].ToString();
                txtDOB.Text = o_find.Tables["Patients"].Rows[0]["DateOfBirth"].ToString();
                //dateTimePicker1 = o_find.Tables["Patients"].Rows[0].ToString();
                txtNextOfKin.Text = o_find.Tables["Patients"].Rows[0]["NextOfKin"].ToString();
                txtNextOfKinRelationship.Text = o_find.Tables["Patients"].Rows[0]["NextOfKinRelationship"].ToString();
                txtDoctor.Text = o_find.Tables["Patients"].Rows[0]["Doctor"].ToString();
                o_msg = "Patient Found!";

            }
            catch
            {
                o_msg = "Can't find the data";
                
            }
            finally
            {
                MessageBox.Show(o_msg, "Finding Patient", MessageBoxButtons.OK);
            }

        }
    }
}
