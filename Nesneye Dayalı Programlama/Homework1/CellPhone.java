package Homework1;

public class CellPhone extends Product {
	private double memoryCapacity;
	private String operatingSystem;

	public CellPhone(
			String productName, 
			String modelType, 
			String brand, 
			double price, 
			double memoryCapacity, 
			String operatingSystem) {
		super(productName, modelType, brand, price);
		
		this.memoryCapacity = memoryCapacity;
		this.operatingSystem = operatingSystem;
	}

	public double getMemoryCapaacity() {
		return memoryCapacity;
	}

	public String getOperatingSystem() {
		return operatingSystem;
	}
	
	public String toString() {
		return String.format("%s%s%s%n%s%s%n",
				super.toString(),
				"Memory Capactiy: ", getMemoryCapaacity(),
				"Operatin System: ", getOperatingSystem());
	}
}
