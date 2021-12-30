package Ders_7;

public class Vehicle {
	private String vehicleNo;
	private String prodStart;
	private char vStatus;
	private String deliveryDate;
	private String customerName;
	private String desc;
	
	//constructor
	public Vehicle(String dataInput)
	{
		//fixed length data
		//Vehicle No (10 chars) - first 5 chars = vehicle type
		//Prod Start date (10 chars)
		//Status of vehicle (1 char, C:Completed W:Waiting D:On Delivery 
		//Delivery date (10 chars)
		//Name of Customer (20 chars)
		//Description (remaining chars)
		
		if (dataInput.indexOf(";") < 0)
		{
			//substring & charAt
			vehicleNo = dataInput.substring(0,10);
			prodStart = dataInput.substring(10,20);
			vStatus = dataInput.charAt(20);
			deliveryDate = dataInput.substring(21,31);
			customerName = dataInput.substring(31,51);
			desc = dataInput.substring(51); //from 51 to the end of string
		}
		else
		{
			//split tokenizing example
			String[] vData = dataInput.split(";");
			
			vehicleNo = vData[0];
			prodStart = vData[1];
			vStatus = vData[2].charAt(0);
			deliveryDate = vData[3];
			customerName = vData[4];
			desc = vData[5];
			
		}
		
	}
	public String toString()
	{
		return String.format("%s: %s%n%s: %s%n%s: %c%n%s: %s%n%s: %s%n%s: %s%n",    
		         "Vehicle Nr", vehicleNo,                     
		         "Prod Start Date", prodStart,                
		         "Status", vStatus,                                     
		         "Delivery Date", deliveryDate,
		         "Customer Name", customerName,
		         "Description", desc);	
	}
	
	public String getVehicleNo()
	{
		return vehicleNo;
	}
	
	public String getProdStart()
	{
		return prodStart;
	}
	
	public String getStatus()
	{
		if (vStatus == 'C')
			return "Completed";
		else if (vStatus == 'D')
			return "On Delivery";
		else if (vStatus == 'W')
			return "Waiting";
		else
			return "Not known";
		
	}
	public String getDeliveryDate()
	{
		return deliveryDate;
	}
	
	public String getCustomerName()
	{
		return customerName;
	}
	
	public String getDesc()
	{
		return desc;
	}
	
	public String getDeliveryCity()
	{
		if (desc.indexOf("Istanbul") > 0)
			return "Istanbul";
		else if (desc.indexOf("Ankara") > 0)
			return "Ankara";
		else
			return "Other City";
	}
	
	public boolean isTurkeyPlant()
	{
		//startsWith Example
		//581 = Turkey
		if (vehicleNo.startsWith("581", 2))
			return true;
		else
			return false;
	}
	
	public boolean isDeliveredOnTime(int redDelYear)
	{
		//valueof
		String reqDelYearString = String.valueOf(redDelYear);
		//substring
		String delYearString = deliveryDate.substring(6,10);
		
		//equals
		return delYearString.equals(reqDelYearString);
	}
	
	public boolean validateCustomerName()
	{
		//split
		String[] nameparts = customerName.split(" ");
		boolean returnvalue = false;
		
		//Regular Expression - matches Example
		for (String namepart : nameparts)
		{
			if (namepart.matches("[a-zA-Z]*"))
					returnvalue = true;
		}
		return returnvalue;
	}

}
