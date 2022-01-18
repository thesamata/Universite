package Ders_6;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.nio.file.Path;
import java.util.Scanner;

import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;

public class StringDemo3 {

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
		
		String v1;
		@SuppressWarnings("unused")
		int reqDelYear = 2021;
		PrintWriter output = null;
		
		//get input file path and name from GUI - JFileChooser
		JFileChooser fc = new JFileChooser();
		fc.setFileSelectionMode(JFileChooser.FILES_ONLY);
		fc.setDialogTitle("Please select the input file");
		FileNameExtensionFilter filter = new FileNameExtensionFilter("TEXT FILES","txt","text");
		fc.setFileFilter(filter);
		int result = fc.showOpenDialog(null);
		
		//if user clicked Cancel then exit
		if (result == JFileChooser.CANCEL_OPTION)
			System.exit(0);
		
		File myObj = fc.getSelectedFile();
		//check whether file exists
		if (!myObj.exists()) //if the file does not exist
		{
			System.out.println("File does not exist. Terminating");
			System.exit(0);
		}
		
		//get output file path from GUI - JFileChooser
		fc.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
		fc.setDialogTitle("Please select the folder (directory) for output file");
		result = fc.showOpenDialog(null);
		
		//if user clicked Cancel then exit
		if (result == JFileChooser.CANCEL_OPTION)
			System.exit(0);
		
		Path pathObj = fc.getSelectedFile().toPath();
		
		String outputfileName = pathObj.toString() + "\\report2021.csv";
		System.out.println(outputfileName);
	
		
		try
		{
			//open file and write with PrintWriter
			output = new PrintWriter(outputfileName);
		}
		catch (SecurityException se)
		{
			System.out.println("Write permission denied. Terminating.");
			System.exit(0);
		}
		catch (FileNotFoundException fe)
		{
			System.out.println("Error opening the file. Terminating.");
			System.exit(0);
		}
		output.printf("%s;%s;%s;%s;%s;%s\n",
							"Vehicle No",
							"Prod Start Date",
							"Status",
							"Delivery Date",
							"Owner of Vehicle",
							"Delivery City");
		
		try {
			//open file read with scanner
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
				
					//write to output file
					output.printf("%s;%s;%s;%s;%s;%s\n",
						vehicle1.getVehicleNo(),
						vehicle1.getProdStart(),
						vehicle1.getStatus(),
						vehicle1.getDeliveryDate(),
						vehicle1.isTurkeyPlant() ? "Turkey" : "Other Country",
						vehicle1.getDeliveryCity());
					
					/*output.println(vehicle1.getVehicleNo() + ";"+ 
							vehicle1.getProdStart()+";"+
							vehicle1.getStatus()+";"+
							vehicle1.getDeliveryDate()+";" + 
							(vehicle1.isTurkeyPlant() ? "Turkey" : "Other Country")+";" + 
							vehicle1.getDeliveryCity()); */
				}
				
			}
			fileInput.close();
			//the file will not updated if you don't close it
			output.close();
		}
		catch (FileNotFoundException e)
		{
			System.out.println("File does not exist.");
		}
		
		
		
		
		
			
	}

}
