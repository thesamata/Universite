package Ders_5;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Formatter;
import java.util.Scanner;

public class StringDemo2 {

  public static void main(String[] args) {
    //Created by Aysegul at 20.10.2020

    //fixed length data
    //Vehicle No (10 chars) - first 5 chars = vehicle type
    //Prod Start date (10 chars)
    //Status of vehicle (1 char, C:Completed W:Waiting D:On Delivery
    //Delivery date (10 chars)
    //Name of Customer (20 chars)
    //Description (remaining chars)

    //Vehicle 1
    //155812788810.05.2021C10.06.2021Ay�eg�l Aktekin     Description can be any length here there.�������������
    //Vehicle 2 - Data is separated with semicolons ";"
    //Vehicle No - first value
    //Prod Start date - second value
    //Status of vehicle - third value
    //Delivery date - fourth
    //Name of Customer - fifth
    //Description (remaining chars)
    //1558227889;10.05.2021;D;10.06.2021;AY�EG�L AKTEK�N;Description can be any length here there.�������������

    String inputfileName = "VehicleData.txt";
    String outputfileName = "report2021.csv";
    String v1;
    int reqDelYear = 2021;
    Formatter output = null;

    //check whether file exists
    File myObj = new File(inputfileName);
    if (
      !myObj.exists()
    ) { //if the file does not exist
      System.out.println("File does not exist. Terminating");
      System.exit(0);
    }
    try {
      output = new Formatter(outputfileName);
    } catch (SecurityException se) {
      System.out.println("Write permission denied. Terminating.");
      System.exit(0);
    } catch (FileNotFoundException fe) {
      System.out.println("Error opening the file. Terminating.");
      System.exit(0);
    }
    output.format(
      "%s;%s;%s;%s;%s;%s\n",
      "Vehicle No",
      "Prod Start Date",
      "Status",
      "Delivery Date",
      "Owner of Vehicle",
      "Delivery City"
    );

    try {
      //open file
      Scanner fileInput = new Scanner(myObj);

      //read file until end of file (marker)
      while (
        fileInput.hasNextLine()
      ) { //while there is more to read / not reached end of file
        v1 = fileInput.nextLine();
        //length
        if (v1.length() < 51) {
          System.out.println("Vehicle data should be min 51 chars: " + v1);
        } else {
          Vehicle vehicle1 = new Vehicle(v1);
          System.out.println("-----------------------------------------------");
          System.out.println("--------           VEHICLE INFO     -----------");
          System.out.println("-----------------------------------------------");
          System.out.println(vehicle1);

          //write to output file
          output.format(
            "%s;%s;%s;%s;%s;%s\n",
            vehicle1.getVehicleNo(),
            vehicle1.getProdStart(),
            vehicle1.getStatus(),
            vehicle1.getDeliveryDate(),
            vehicle1.isTurkeyPlant() ? "Turkey" : "Other Country",
            vehicle1.getDeliveryCity()
          );
        }
      }
      fileInput.close();
      //the file will not updated if you don't close it
      output.close();
    } catch (FileNotFoundException e) {
      System.out.println("File does not exist.");
    }
  }
}
