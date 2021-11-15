package Homework1;

public class Television extends Product {
	private double screenSize;
	private double resolution;
	
	
	
	public Television(
			String productName, 
			String modelType, 
			String brand, 
			double price, 
			double screenSize, 
			double resolution) {
		super(productName, modelType, brand, price);
		this.screenSize = screenSize;
		this.resolution = resolution;
		
	}

	public double getScreenSize() {
		return screenSize;
	}



	public double getResolution() {
		return resolution;
	}

	public String toString() {
		return String.format("%s%s%s%n%s%s%n",
				super.toString(),
				"Screen Size: ", getScreenSize(),
				"Resolution: ", getResolution());
	}

}
