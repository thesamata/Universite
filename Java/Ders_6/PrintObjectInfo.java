package Ders_6;

import java.io.EOFException;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.nio.file.Files;
import java.nio.file.Paths;

public class PrintObjectInfo {
	public static void main(String[] args)
	{
		ObjectInputStream input = null;
		try // open file
		{
			input = new ObjectInputStream(Files.newInputStream(Paths.get("C:\\Users\\Aysegul\\Desktop\\BIP2007\\report2021_1.ser")));

		} 
		catch (IOException ioException)
		{
			System.err.println("Error opening file.");
			ioException.printStackTrace();
			System.exit(0);
		}
		
		try
		{
			while (true)
			{
				Vehicle2 vehicle1 = (Vehicle2) input.readObject();
				System.out.println("-----------------------------------------------");
				System.out.println("--------           VEHICLE INFO     -----------");
				System.out.println("-----------------------------------------------");
				System.out.println(vehicle1);
				
			}
		}
		catch (EOFException endOfFileException)
		{
			System.out.printf("%nNo more records%n");
		} 
		catch (ClassNotFoundException classNotFoundException)
		{
			System.err.println("Invalid object type. Terminating.");
		} 
		catch (IOException ioException)
		{
			System.err.println("Error reading from file. Terminating.");
		} 
		
		
	}
}
