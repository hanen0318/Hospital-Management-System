using System;
using System.Data;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Beds.
	/// </summary>
	public class Beds
	{
		private DataSet m_oDS ; 
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
		private string m_sClassName = "Bed";
		private string sSQL;

		public Beds()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;

			InitializeConnection();

			sSQL = "SELECT BedNumber, BedType, Occupied, WardName "  +
				" FROM	Beds " +
				" ORDER BY BedNumber ";
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;

			m_oCn = null;

		}

		public DataSet GetData()
		{
			m_oDS = new DataSet();
			m_oDA.Fill(m_oDS, m_sClassName);
			return m_oDS;
		}

		public string SetOccuppiedToTrue(string bedNum)
        {
			string msg = "";
            try
            {
				m_oCn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "UPDATE Beds SET Occuppied = '" + true + "' WHERE BedNumber = '" + bedNum + "'";
				cmd.ExecuteNonQuery();
                msg = "Bed "+ bedNum + " is now available";
            }
            catch
            {
				msg = "Error! Bed is already available";
            }
            finally
            {
				m_oCn.Close();
				
            }
			return msg;
        }

		private void InitializeConnection()
		{
			m_oCn = new SqlConnection("Data Source=LAPTOP-MJQ0UB97\\SQLEXPRESS;Initial Catalog=NLH;Integrated Security=True;");

		}

		public string GetBed(string ward)
		{
			string bednumber = "none available";
			string tempbed;
			bool occupied = true;

			DataSet thisDataSet = new DataSet();

			m_oDA.Fill (thisDataSet, m_sClassName);

			for (int n = 0; n < thisDataSet.Tables["Beds"].Rows.Count ; n++)
			{
				tempbed = thisDataSet.Tables["Beds"].Rows[n]["BedNumber"].ToString ();
				if (tempbed.StartsWith(ward))
				{
					occupied = Convert.ToBoolean (thisDataSet.Tables["Beds"].Rows[n]["Occupied"]);
				}
			
			}
			return bednumber;
		}
	}
}
