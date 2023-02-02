using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data ;
using System.Data .SqlClient ;
using NLHospitalLibrary;
using NLHBaseWindow;



namespace NLHospital
{
	/// <summary>
	/// Summary description for BillPatient.
	/// </summary>
	public class frmBillPatient : NLHBase
	{
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblRPhone;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblRTV;
		private System.Windows.Forms.Label lblTotalTV;
		private System.Windows.Forms.Label lblTotalPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblGrandTotal;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnRetrieve;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lblHealth;
		private System.Windows.Forms.Label lblDays;
		private System.Windows.Forms.Label lblPatient;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTotalSemi;
		private System.Windows.Forms.Label lblPRate;
		private System.Windows.Forms.Label lblTotalPrivate;
		private System.Windows.Forms.Label lblRSemi;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBillPatient()
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRTV = new System.Windows.Forms.Label();
            this.lblTotalTV = new System.Windows.Forms.Label();
            this.lblRPhone = new System.Windows.Forms.Label();
            this.lblTotalPhone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRSemi = new System.Windows.Forms.Label();
            this.lblTotalSemi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPRate = new System.Windows.Forms.Label();
            this.lblTotalPrivate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(38, 70);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Health Number:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(38, 105);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(63, 20);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Patient:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(704, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length of stay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Daily Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chargeable:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "TV";
            // 
            // lblRTV
            // 
            this.lblRTV.AutoSize = true;
            this.lblRTV.Location = new System.Drawing.Point(397, 199);
            this.lblRTV.Name = "lblRTV";
            this.lblRTV.Size = new System.Drawing.Size(58, 20);
            this.lblRTV.TabIndex = 8;
            this.lblRTV.Text = "$42.50";
            this.lblRTV.Visible = false;
            this.lblRTV.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalTV
            // 
            this.lblTotalTV.AutoSize = true;
            this.lblTotalTV.Location = new System.Drawing.Point(627, 199);
            this.lblTotalTV.Name = "lblTotalTV";
            this.lblTotalTV.Size = new System.Drawing.Size(51, 20);
            this.lblTotalTV.TabIndex = 9;
            this.lblTotalTV.Text = "label3";
            this.lblTotalTV.Visible = false;
            // 
            // lblRPhone
            // 
            this.lblRPhone.AutoSize = true;
            this.lblRPhone.Location = new System.Drawing.Point(397, 234);
            this.lblRPhone.Name = "lblRPhone";
            this.lblRPhone.Size = new System.Drawing.Size(49, 20);
            this.lblRPhone.TabIndex = 10;
            this.lblRPhone.Text = "$7.50";
            this.lblRPhone.Visible = false;
            // 
            // lblTotalPhone
            // 
            this.lblTotalPhone.AutoSize = true;
            this.lblTotalPhone.Location = new System.Drawing.Point(627, 234);
            this.lblTotalPhone.Name = "lblTotalPhone";
            this.lblTotalPhone.Size = new System.Drawing.Size(51, 20);
            this.lblTotalPhone.TabIndex = 11;
            this.lblTotalPhone.Text = "label9";
            this.lblTotalPhone.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Semi-Private Room";
            // 
            // lblRSemi
            // 
            this.lblRSemi.AutoSize = true;
            this.lblRSemi.Location = new System.Drawing.Point(397, 269);
            this.lblRSemi.Name = "lblRSemi";
            this.lblRSemi.Size = new System.Drawing.Size(67, 20);
            this.lblRSemi.TabIndex = 13;
            this.lblRSemi.Text = "$267.00";
            this.lblRSemi.Visible = false;
            // 
            // lblTotalSemi
            // 
            this.lblTotalSemi.AutoSize = true;
            this.lblTotalSemi.Location = new System.Drawing.Point(627, 269);
            this.lblTotalSemi.Name = "lblTotalSemi";
            this.lblTotalSemi.Size = new System.Drawing.Size(60, 20);
            this.lblTotalSemi.TabIndex = 14;
            this.lblTotalSemi.Text = "label12";
            this.lblTotalSemi.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total now due:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(627, 374);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(51, 20);
            this.lblGrandTotal.TabIndex = 17;
            this.lblGrandTotal.Text = "label3";
            this.lblGrandTotal.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(512, 444);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 34);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(653, 444);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 34);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Admission ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(166, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 26);
            this.txtID.TabIndex = 20;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(499, 12);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(256, 33);
            this.btnRetrieve.TabIndex = 22;
            this.btnRetrieve.Text = "Retrieve Patient Information";
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(192, 70);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(51, 20);
            this.lblHealth.TabIndex = 24;
            this.lblHealth.Text = "label9";
            this.lblHealth.Visible = false;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(614, 70);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(60, 20);
            this.lblDays.TabIndex = 25;
            this.lblDays.Text = "label11";
            this.lblDays.Visible = false;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(128, 105);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(60, 20);
            this.lblPatient.TabIndex = 26;
            this.lblPatient.Text = "label12";
            this.lblPatient.Visible = false;
            this.lblPatient.Click += new System.EventHandler(this.lblPatient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Private Room";
            // 
            // lblPRate
            // 
            this.lblPRate.AutoSize = true;
            this.lblPRate.Location = new System.Drawing.Point(397, 304);
            this.lblPRate.Name = "lblPRate";
            this.lblPRate.Size = new System.Drawing.Size(67, 20);
            this.lblPRate.TabIndex = 28;
            this.lblPRate.Text = "$571.00";
            this.lblPRate.Visible = false;
            // 
            // lblTotalPrivate
            // 
            this.lblTotalPrivate.AutoSize = true;
            this.lblTotalPrivate.Location = new System.Drawing.Point(627, 304);
            this.lblTotalPrivate.Name = "lblTotalPrivate";
            this.lblTotalPrivate.Size = new System.Drawing.Size(60, 20);
            this.lblTotalPrivate.TabIndex = 29;
            this.lblTotalPrivate.Text = "label11";
            this.lblTotalPrivate.Visible = false;
            this.lblTotalPrivate.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmBillPatient
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(815, 342);
            this.Controls.Add(this.lblTotalPrivate);
            this.Controls.Add(this.lblPRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalSemi);
            this.Controls.Add(this.lblRSemi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalPhone);
            this.Controls.Add(this.lblRPhone);
            this.Controls.Add(this.lblTotalTV);
            this.Controls.Add(this.lblRTV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Name = "frmBillPatient";
            this.Text = "BillPatient";
            this.Load += new System.EventHandler(this.frmBillPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.Close ();
		}


		private void btnRetrieve_Click(object sender, System.EventArgs e)
		{
			string pID;
			string ID;
			int days = 0;
			decimal grandTotal = 0.0M;

			DataSet pDataSet = new DataSet();
			DataSet eDataSet = new DataSet();

			Extras oExtras = new Extras();
			Patients oPatients = new Patients();
			Rates oRates = new Rates();
			Admissions oAdmissions = new Admissions ();

			ID = txtID.Text;
			eDataSet = oExtras.FindData(ID);

			pID = eDataSet.Tables["Extras"].Rows[0]["PatientID"].ToString ();
			oPatients.GetPatientInfo (pID);
			
			oRates.GetRates();

			lblHealth.Text = pID;
			lblHealth.Visible = true;

			lblPatient.Text = oPatients.pFirst + " " + oPatients.pLast;
			lblPatient.Visible = true;

			lblDays.Text = (oAdmissions.GetDays (ID)).ToString ();
			lblDays.Visible = true;
			days = Convert.ToInt32 (lblDays.Text);

			if(Convert.ToBoolean (eDataSet.Tables ["Extras"].Rows[0]["TV"]) == true)
			{
				lblRTV.Text = Convert.ToString (oRates.TVRate);
				lblRTV.Visible = true;
				lblTotalTV.Text = Convert.ToString (days * oRates.TVRate);
				lblTotalTV.Visible = true;
				grandTotal = Convert.ToDecimal (lblTotalTV.Text);
			}

			if(Convert.ToBoolean (eDataSet.Tables ["Extras"].Rows[0]["Phone"]) == true)
			{
				lblRPhone.Text = Convert.ToString (oRates.PhoneRate) ;
				lblRPhone.Visible = true;
				lblTotalPhone.Text = Convert.ToString (days * oRates.PhoneRate);
				lblTotalPhone.Visible = true;
				grandTotal += Convert.ToDecimal (lblTotalPhone.Text);
			}

			if(Convert.ToBoolean (eDataSet.Tables ["Extras"].Rows[0]["SemiPrivate"]) == true)
			{
				lblRSemi.Text = Convert.ToString (oRates.SemiRate);
				lblRSemi.Visible = true;
			}

			if(Convert.ToBoolean (eDataSet.Tables ["Extras"].Rows[0]["Private"]) == true)
			{
				lblPRate.Text = Convert.ToString (oRates.PrivateRate );
				lblPRate.Visible = true;
			}




		}

		private void lblPatient_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label11_Click(object sender, System.EventArgs e)
		{
		
		}

        private void frmBillPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
