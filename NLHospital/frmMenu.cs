using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NLHospitalLibrary;
using NLHBaseWindow;


namespace NLHospital
{
	/// <summary>
	/// Summary description for frmMenu.
	/// </summary>
	public class frmMenu : NLHBase
	{
		private System.Windows.Forms.Label lblAdministrator;
		private System.Windows.Forms.Button btnDoctors;
		private System.Windows.Forms.Label lblAdmin;
		private System.Windows.Forms.Panel pnlAdministrator;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDischarge;
		private System.Windows.Forms.Button btnSurgery;
		private System.Windows.Forms.Label lblNurses;
		private System.Windows.Forms.Button btnForSurgery;
		private System.Windows.Forms.Button btnBilling;
		private System.Windows.Forms.Button btnPatientList;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Panel pnlDoctors;
		private System.Windows.Forms.Panel pnlNurses;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPatientID;
		private System.Windows.Forms.Label label1;
        private Button btnPatient;
        public CurrentUser oCurrent = new CurrentUser();

		public frmMenu()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSurgery = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNurses = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.btnForSurgery = new System.Windows.Forms.Button();
            this.lblNurses = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.pnlAdministrator.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.pnlNurses.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.Controls.Add(this.btnPatient);
            this.pnlAdministrator.Controls.Add(this.btnBilling);
            this.pnlAdministrator.Controls.Add(this.lblAdmin);
            this.pnlAdministrator.Controls.Add(this.btnDoctors);
            this.pnlAdministrator.Controls.Add(this.lblAdministrator);
            this.pnlAdministrator.Location = new System.Drawing.Point(26, 12);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(512, 175);
            this.pnlAdministrator.TabIndex = 0;
            this.pnlAdministrator.Visible = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(256, 117);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(218, 34);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "Bill Patient";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(26, 47);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(248, 20);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Please select one of the following:";
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(13, 117);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(217, 34);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Manage Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(26, 12);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(149, 25);
            this.lblAdministrator.TabIndex = 0;
            this.lblAdministrator.Text = "Administration";
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.Controls.Add(this.label1);
            this.pnlDoctors.Controls.Add(this.txtPatientID);
            this.pnlDoctors.Controls.Add(this.label3);
            this.pnlDoctors.Controls.Add(this.btnSurgery);
            this.pnlDoctors.Controls.Add(this.btnDischarge);
            this.pnlDoctors.Controls.Add(this.label2);
            this.pnlDoctors.Location = new System.Drawing.Point(550, 12);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(512, 175);
            this.pnlDoctors.TabIndex = 2;
            this.pnlDoctors.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.AcceptsTab = true;
            this.txtPatientID.Location = new System.Drawing.Point(128, 82);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(115, 26);
            this.txtPatientID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please elect one of the following:";
            // 
            // btnSurgery
            // 
            this.btnSurgery.Location = new System.Drawing.Point(269, 117);
            this.btnSurgery.Name = "btnSurgery";
            this.btnSurgery.Size = new System.Drawing.Size(217, 34);
            this.btnSurgery.TabIndex = 2;
            this.btnSurgery.Text = "Surgery Report";
            this.btnSurgery.Click += new System.EventHandler(this.btnSurgery_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(26, 117);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(217, 34);
            this.btnDischarge.TabIndex = 1;
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctors";
            // 
            // pnlNurses
            // 
            this.pnlNurses.Controls.Add(this.label4);
            this.pnlNurses.Controls.Add(this.btnPatientList);
            this.pnlNurses.Controls.Add(this.btnForSurgery);
            this.pnlNurses.Controls.Add(this.lblNurses);
            this.pnlNurses.Location = new System.Drawing.Point(26, 199);
            this.pnlNurses.Name = "pnlNurses";
            this.pnlNurses.Size = new System.Drawing.Size(512, 175);
            this.pnlNurses.TabIndex = 3;
            this.pnlNurses.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select one of the following:";
            // 
            // btnPatientList
            // 
            this.btnPatientList.Location = new System.Drawing.Point(26, 117);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(217, 34);
            this.btnPatientList.TabIndex = 2;
            this.btnPatientList.Text = "Patient List";
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            // 
            // btnForSurgery
            // 
            this.btnForSurgery.Location = new System.Drawing.Point(269, 117);
            this.btnForSurgery.Name = "btnForSurgery";
            this.btnForSurgery.Size = new System.Drawing.Size(217, 34);
            this.btnForSurgery.TabIndex = 1;
            this.btnForSurgery.Text = "Surgery Report";
            // 
            // lblNurses
            // 
            this.lblNurses.AutoSize = true;
            this.lblNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurses.Location = new System.Drawing.Point(51, 12);
            this.lblNurses.Name = "lblNurses";
            this.lblNurses.Size = new System.Drawing.Size(80, 25);
            this.lblNurses.TabIndex = 0;
            this.lblNurses.Text = "Nurses";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(346, 468);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 33);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(13, 77);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(217, 34);
            this.btnPatient.TabIndex = 6;
            this.btnPatient.Text = "Manage Patients";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(1081, 470);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.pnlAdministrator);
            this.Controls.Add(this.pnlNurses);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlAdministrator.ResumeLayout(false);
            this.pnlAdministrator.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlNurses.ResumeLayout(false);
            this.pnlNurses.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnDoctors_Click(object sender, System.EventArgs e)
		{
			frmDoctors doctorsForm = new frmDoctors ();
			doctorsForm.Visible = true;
			doctorsForm.Activate();
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit ();
		}

		private void frmMenu_Load(object sender, System.EventArgs e)
		{
		}

		public void SelectUser()
		{
			switch (oCurrent.UserName )
			{
				case "admin":
					pnlAdministrator.Visible = true;
					break;
				case "Doctor":
					pnlDoctors.Visible = true;
					break;
				case "Nurse":
					pnlNurses.Visible = true;
					break;
			}
			
		}

		private void btnDischarge_Click(object sender, System.EventArgs e)
		{
            Admissions admissions = new Admissions();
            Beds bed = new Beds();
            DataSet m_ds = new DataSet();
            string m_msg = "";
            string p_id = txtPatientID.Text;
            

            try
            {
                m_ds = admissions.FindData(p_id);
                string bedNumber = m_ds.Tables["Admissions"].Rows[0]["BedNumber"].ToString();
                m_msg = bed.SetOccuppiedToTrue(bedNumber);

            }
            catch
            {
                m_msg = "Error\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(m_msg, "Dischage Patient", MessageBoxButtons.OK);
            }

		}

		private void btnBilling_Click(object sender, System.EventArgs e)
		{
			frmBillPatient billForm = new frmBillPatient ();
			billForm.Visible = true;
			billForm.Activate();
		}

        private void btnSurgery_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Visible = true;
            admin.Activate();
        }
    }
}
