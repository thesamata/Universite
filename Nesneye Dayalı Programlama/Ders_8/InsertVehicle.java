package Ders_8;

import java.io.File;
import java.io.FileNotFoundException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

public class InsertVehicle {

  private static Connection conn;
  private static PreparedStatement insertVehicle;
  private static PreparedStatement updateVehicle;
  private static PreparedStatement searchVehicle;
  private static PreparedStatement deleteVehicle;

  public static void ConnectDB() {
    try {
      String serverAddr = "localhost:1433";
      String UserName = "sa";
      String password = "clvr1212";
      String dbName = "BIP2007_2021";
      String URL = "jdbc:sqlserver://" + serverAddr + ";databaseName=" + dbName;

      //connection
      conn = DriverManager.getConnection(URL, UserName, password);

      insertVehicle =
        conn.prepareStatement(
          "INSERT INTO VehicleMaster " +
          "(VehicleNo, ProdStartDate, VStatus, DeliveryDate, CustomerName, Country, DeliveryCity, VDescription) " +
          "VALUES (?, ?, ?, ?, ?, ?, ? , ?) "
        );

      updateVehicle =
        conn.prepareStatement(
          "UPDATE VehicleMaster SET " +
          "VStatus=?, DeliveryDate=?, CustomerName=?, DeliveryCity=?, VDescription=? " +
          "WHERE VehicleNo=?"
        );

      searchVehicle =
        conn.prepareStatement("SELECT * FROM VehicleMaster WHERE VehicleNo=?");

      deleteVehicle =
        conn.prepareStatement("DELETE FROM VehicleMaster WHERE VehicleNo=?");
    } catch (SQLException e) {
      e.printStackTrace();
      System.exit(1);
    }
  }

  public static void main(String[] args) {
    String fileName = "C:\\Users\\Aysegul\\Desktop\\BIP2007\\VehicleData.txt";
    String v1;
    int result = 0;
    ResultSet selectResult = null;
    Vehicle vehicle1 = null;

    //check whether file exists
    File myObj = new File(fileName);
    if (!myObj.exists()) { //if the file does not exist
      System.out.println("File does not exist.");
      System.exit(0);
    }

    //Connect to database and prepare SQL Statements
    ConnectDB();

    try {
      //open file
      Scanner fileInput = new Scanner(myObj);

      //read file until end of file (marker)
      while (fileInput.hasNextLine()) { //while there is more to read / not reached end of file
        v1 = fileInput.nextLine();
        //length
        if (v1.length() < 51) {
          System.out.println("Vehicle data should be min 51 chars: " + v1);
        } else {
          vehicle1 = new Vehicle(v1);
          System.out.println("-----------------------------------------------");
          System.out.println("--------           VEHICLE INFO     -----------");
          System.out.println("-----------------------------------------------");

          System.out.println(vehicle1);

          //Search vehicle number in table
          searchVehicle.setString(1, vehicle1.getVehicleNo());
          selectResult = searchVehicle.executeQuery();

          //UPDATE row If there is a row returning from SELECT statement
          if (selectResult.next()) { //is there any row returning from SELECT
            if (vehicle1.getStatus() == "Deleted") {
              //Prepare SQL Statement = Write the values for ?
              deleteVehicle.setString(1, vehicle1.getVehicleNo());

              //delete the entry
              //Execution
              result = deleteVehicle.executeUpdate();
            } else {
              //Prepare SQL Statement = Write the values for ?
              updateVehicle.setString(1, vehicle1.getStatus());
              updateVehicle.setString(2, vehicle1.getDeliveryDate());
              updateVehicle.setString(3, vehicle1.getCustomerName());
              updateVehicle.setString(4, vehicle1.getDeliveryCity());
              updateVehicle.setString(5, vehicle1.getDesc());
              updateVehicle.setString(6, vehicle1.getVehicleNo());

              //update the entry
              //Execution
              result = updateVehicle.executeUpdate();
            }
          }
          //INSERT if no data returned from SELECT
          else {
            //Prepare SQL Statement = Write the values for ?
            insertVehicle.setString(1, vehicle1.getVehicleNo());
            insertVehicle.setString(2, vehicle1.getProdStart());
            insertVehicle.setString(3, vehicle1.getStatus());
            insertVehicle.setString(4, vehicle1.getDeliveryDate());
            insertVehicle.setString(5, vehicle1.getCustomerName());
            insertVehicle.setString(
              6,
              vehicle1.isTurkeyPlant() ? "Turkey" : "Other"
            );
            insertVehicle.setString(7, vehicle1.getDeliveryCity());
            insertVehicle.setString(8, vehicle1.getDesc());

            //insert the new entry
            //Execution
            result = insertVehicle.executeUpdate();
          }
        }
      }
    } catch (FileNotFoundException e) {
      System.out.println("File does not exist.");
    } catch (SQLException e) {
      e.printStackTrace();
      System.exit(1);
    }
  }
}
