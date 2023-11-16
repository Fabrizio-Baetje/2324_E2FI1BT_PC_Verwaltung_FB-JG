using System;

public class DBAccess
{
	MySqlConnection con;
	public DBAccess 
	{
		con = new MySqlConnection(@"SERVER=localhost;DATABASE=pc_verwaltung;UID=root;PASSWORD=");
		con.Open();
	}
	public void DBclose()
	{ 
		con.close();
	}
	public MySqlConnection getCon()
	{
		return con;
	}

}
