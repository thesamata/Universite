package Ders_8;

import java.util.Scanner;

import javax.swing.JOptionPane;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;


public class PrintVehicleTwoTable {
	private static Connection connection;
	private static PreparedStatement selectAllVehicles; 
	private static PreparedStatement selectVehiclesByNo; 


	public static void ConnectDb()
	{
		try 
		{
			String dbName = "BIP2005";
			String serverip="localhost:1433";
			String serverport="1433";
		   	String URL = "jdbc:sqlserver://"+serverip +";databaseName="+dbName;
			String USERNAME = "sa";
			String PASSWORD = "clvr1212"; 
			String driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
			
			 // String connectionUrl = "jdbc:sqlserver://<server>:<port>;databaseName=AdventureWorks;user=<user>;password=<password>";    
	        
			connection = DriverManager.getConnection(URL, USERNAME, PASSWORD);

			// create insert that adds a new entry into the database
			selectAllVehicles = connection.prepareStatement(
					"SELECT VehicleMaster.VehicleNo, VehicleMaster.ProdStartDate, VehicleMaster.DeliveryDate," +
					"VehicleMaster.CustomerName, VehicleMaster.Country, VehicleMaster.DeliveryCity, " + 
					"VehicleMaster.Description, Status.Status AS StatusDesc FROM VehicleMaster " + 
					"INNER JOIN Status ON VehicleMaster.Status = Status.Code");
		
			
			selectVehiclesByNo = connection.prepareStatement(
					"SELECT VehicleMaster.VehicleNo, VehicleMaster.ProdStartDate, VehicleMaster.DeliveryDate," +
					"VehicleMaster.CustomerName, VehicleMaster.Country, VehicleMaster.DeliveryCity, " + 
					"VehicleMaster.Description, Status.Status AS StatusDesc FROM VehicleMaster " + 
					"INNER JOIN Status ON VehicleMaster.Status = Status.Code " +
					"WHERE (VehicleMaster.VehicleNo =  ?)");
			System.out.println("Connected successfully");
		}
		catch (SQLException sqlException)
		{
			sqlException.printStackTrace();
			System.exit(1);
		}

	} 
	public static int PrintVehicles(String searchvalue)
	{
		int result = 0;
		ResultSet resultSet = null;
			
		try 
		{
			if (searchvalue.equals(""))
				resultSet = selectAllVehicles.executeQuery(); 
			else
			{
				selectVehiclesByNo.setString(1, searchvalue); 
				resultSet = selectVehiclesByNo.executeQuery(); 
			}
			System.out.printf("%-12s%-12s%-12s%-12s%-30s%-20s%-20s%-100s\n","Vehicle No","Prod.Date","Status","Del.Date","Customer","Country","City","Description");
            
			while (resultSet.next())
	         {
				System.out.printf("%-12s%-12s%-12s%-12s%-30s%-20s%-20s%-100s\n",
						resultSet.getString("VehicleNo"),
						resultSet.getString("ProdStartDate"),
						resultSet.getString("StatusDesc"),
						resultSet.getString("DeliveryDate"),
						resultSet.getString("CustomerName"),
						resultSet.getString("Country"),
						resultSet.getString("DeliveryCity"),
						resultSet.getString("Description"));
	         } 
	        
		}
		catch (SQLException sqlException)
		{
			sqlException.printStackTrace();
			close();
		} 

		return result;
	} 

	// close the database connection
	public static void close()
	{
		try 
		{
			connection.close();
		} 
		catch (SQLException sqlException)
		{
			sqlException.printStackTrace();
		} 
	} 

	public static void main(String[] args)
	{
		
		ConnectDb();
		
		String VehicleNo = JOptionPane.showInputDialog(null,"Please enter Vehicle Number to display. To display all vehicles just press enter.");
		
		PrintVehicles(VehicleNo);
		
		close();
		System.out.println("File operation completed successfully");


	}	
}
