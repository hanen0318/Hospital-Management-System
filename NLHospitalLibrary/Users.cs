using System;
using System.Data;
using System.Data.SqlClient ;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Users.
	/// </summary>
	public class Users
	{
		private SqlConnection m_oCn ;    
		private SqlDataAdapter m_oDA;
//		private string m_sClassName = "Users";
		private string sSQL;

		public Users()
		{
			//
			// TODO: Add constructor logic here
			//
			SqlCommand oSelCmd;

			InitializeConnection();

			sSQL = "SELECT UserName, Password, Position FROM Login " ;
			oSelCmd = null;
			oSelCmd = new SqlCommand(sSQL, m_oCn);
			oSelCmd.CommandType = CommandType.Text;

			m_oDA = new SqlDataAdapter();
			m_oDA.SelectCommand = oSelCmd;

			m_oCn = null;

		}
		

		public DataSet FindData(string ID, string pass)
		{
			InitializeConnection();
			m_oCn.Open();
			DataSet thisDataSet = new DataSet("Login");
			DataSet foundDataSet = new DataSet("Login");
			try
			{
				m_oDA.Fill (thisDataSet, "Login");
				for (int n = 0; n < thisDataSet.Tables["Login"].Rows.Count ; n++)
				{
					if (thisDataSet.Tables["Login"].Rows[n]["UserName"].ToString () == ID)
					{
						if (thisDataSet.Tables["Login"].Rows[n]["Password"].ToString () == pass)
						{
							m_oDA.Fill(foundDataSet,n,1,"Login");							
						}
					}
				}
			}
			catch 
			{
			}
			finally
			{
				m_oCn.Close();
				m_oCn = null;
			}
			return foundDataSet;
		}

		private void InitializeConnection()
		{
			m_oCn = new SqlConnection("Data Source=LAPTOP-MJQ0UB97\\SQLEXPRESS;Initial Catalog=NLH;Integrated Security=True;");
		}
	}
}
