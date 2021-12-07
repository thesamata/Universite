package Ders_4;

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
		//Vehicle 2
		//155822788910.05.2021D10.06.2021AYÞEGÜL AKTEKÝN     Description can be any length here there.þþþððððýýýÝÝÝ
		
		Scanner keyboard = new Scanner(System.in);
		
		String v1 = "155812788810.05.2021C10.06.2021  Ayþegül Aktekin2  This vehicle will be delivered to Istanbul on 2022 Istanbul";
		String v2 = "155822788910.05.2021D10.06.2021AYÞEGÜL AKTEKÝN     This is for Ankara";
		
		//length
		if (v1.length() < 51 || v2.length() < 51)
		{
			System.out.println("Vehicle data should be min 51 chars.");
			System.exit(0);
		}
		
		Vehicle vehicle1 = new Vehicle(v1);
		Vehicle vehicle2 = new Vehicle(v2);
		System.out.println(vehicle1);
		System.out.println(vehicle2);
		
		System.out.println("Please enter ecpected delivery year between 2021 and 2022.");
		int reqDelYear = keyboard.nextInt();
		
		if (vehicle1.isDeliveredOnTime(reqDelYear))
			System.out.println("Vehicle 1 will be delivered on requested year.");
		else
			System.out.println("Vehicle 1 will be delivered early or late.");
		
		//equalsIgnoreCase
		if (vehicle1.getCustomerName().equalsIgnoreCase(vehicle2.getCustomerName())) //Ayþegül Aktekin - AYÞEGÜL AKTEKÝN
			System.out.println("Same customer.");
		else
			System.out.println("Different customer");
		
		
		//regionMatches
		if (vehicle1.getVehicleNo().regionMatches(0, vehicle2.getVehicleNo(), 0, 5)) //15581 - 15582
			System.out.println("Same vehicle type.");
		else
			System.out.println("Different vehicle type.");
		
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
