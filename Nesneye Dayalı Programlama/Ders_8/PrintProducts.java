package Ders_8;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class PrintProducts {
	
	private static Connection conn;
	private static PreparedStatement selectProduct;
	
	
	public static void ConnectDB()
	{
		try
		{
			String serverAddr = "localhost:1433";
			String UserName = "sa";
			String password = "clvr1212";
			String dbName = "Midterm_AA";
			String URL = "jdbc:sqlserver://" + serverAddr + ";databaseName=" + dbName;
			
			//connection
			conn = DriverManager.getConnection(URL, UserName, password) ;
						
			selectProduct = conn.prepareStatement("SELECT Product.ProductName, Product.ProductCode, Category.CategoryName, Vendor.VendorName " + 
					"FROM Product " + 
					"INNER JOIN Vendor ON Product.VendorID = Vendor.Id " + 
					"INNER JOIN Category ON Product.CategoryID = Category.Id");
		}
		catch (SQLException e)
		{
			e.printStackTrace();
			System.exit(1);
		}
		
	}

	public static void main(String[] args) {
		ResultSet selectResult = null;
		

		//Connect to database and prepare SQL Statements
		ConnectDB();
		
		try
		{
			//searchVehicle.setString(1, vehicle1.getVehicleNo());
			selectResult = selectProduct.executeQuery();
			System.out.printf("%s;%s;%s;%s\n","Product Name", "Product Code","Category name", "Vendor Name");
			
			while (selectResult.next())
			{
				System.out.printf("%s;%s;%s;%s\n",
						selectResult.getString("ProductName"), 
						selectResult.getString("ProductCode"),
						selectResult.getString("CategoryName"), 
						selectResult.getString("VendorName"));
				
			}
		}
		catch (SQLException sqlException)
		{
			sqlException.printStackTrace();
		} 
}

}
