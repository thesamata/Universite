package Ders_5;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class StringDemo {

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
		//155812788810.05.2021C10.06.2021Ayþegül Aktekin     Description can be any length here there.þþþððððýýýÝÝÝ
		//Vehicle 2 - Data is separated with semicolons ";"
		//Vehicle No - first value
		//Prod Start date - second value
		//Status of vehicle - third value
		//Delivery date - fourth
		//Name of Customer - fifth
		//Description (remaining chars)
		//1558227889;10.05.2021;D;10.06.2021;AYÞEGÜL AKTEKÝN;Description can be any length here there.þþþððððýýýÝÝÝ
		
		String fileName = "C:\\Users\\Aysegul\\Desktop\\BIP2007\\VehicleData.txt";
		String v1;
		int reqDelYear = 2021;
		
		//check whether file exists
		File myObj = new File(fileName);
		if (!myObj.exists()) //if the file does not exist
		{
			System.out.println("File does not exist.");
			System.exit(0);
		}
		
		try {
			//open file
			Scanner fileInput = new Scanner(myObj);
			
			//read file until end of file (marker)
			while (fileInput.hasNextLine())  //while there is more to read / not reached end of file
			{
				v1 = fileInput.nextLine();
				//length
				if (v1.length() < 51)
				{
					System.out.println("Vehicle data should be min 51 chars: " + v1);
				}
				else
				{
					Vehicle vehicle1 = new Vehicle(v1);
					System.out.println("-----------------------------------------------");
					System.out.println("--------           VEHICLE INFO     -----------");
					System.out.println("-----------------------------------------------");
					
					System.out.println(vehicle1);
				
					if (vehicle1.isDeliveredOnTime(reqDelYear))
						System.out.println("Vehicle 1 will be delivered on requested year.");
					else
						System.out.println("Vehicle 1 will be delivered early or late.");
					
					if (vehicle1.isTurkeyPlant())
						System.out.println("Vehicle 1 will be delivered to Turkey.");
					
					//indexOf
					String deliveryCity;
					if (vehicle1.getDesc().indexOf("Istanbul") >= 0)
						deliveryCity = "Ýstanbul";
					else if (vehicle1.getDesc().indexOf("Ankara") >= 0)
						deliveryCity = "Ankara";
					else
						deliveryCity = "Not known";
					System.out.println("Vehicle will be delivered to " + deliveryCity);
						
					int posOfIst = vehicle1.getDesc().indexOf("Istanbul");
					System.out.println("Position of Ýstanbul in description: " + posOfIst);
					
					if (posOfIst >= 0)
					{
						System.out.println("Description after Ýstanbul: " + vehicle1.getDesc().substring(posOfIst + 9));
						System.out.println("Description before Ýstanbul: " + vehicle1.getDesc().substring(0,posOfIst));
					}
					
					//lastIndexOf
					posOfIst = vehicle1.getDesc().lastIndexOf("Istanbul");
					System.out.println("Position of last Ýstanbul in description: " + posOfIst);
					
				
					//trim
					System.out.println("Customer Name without trim: *" + vehicle1.getCustomerName() + "*");
					System.out.println("Customer Name with trim: *" + vehicle1.getCustomerName().trim() + "*");
					
					if (!vehicle1.validateCustomerName())
						System.out.println("Invalid Customer Name");
				}
				
			}
		}
		catch (FileNotFoundException e)
		{
			System.out.println("File does not exist.");
		}
		
		
		
		
		
			
	}

}
