package Homework1;

public class Laptop extends Product {
  private double screenSize;
  private String operatingSystem;

  public Laptop(
    String productName,
    String modelType,
    String brand,
    double price,
    double screenSize,
    String operatingSystem
  ) {
    super(productName, modelType, brand, price);
    this.screenSize = screenSize;
    this.operatingSystem = operatingSystem;
  }

  public double getScreenSize() {
    return screenSize;
  }

  public String getOperatingSystem() {
    return operatingSystem;
  }

  public String toString() {
    return String.format(
      "%s%s%s%n%s%s%n",
      super.toString(),
      "Screen Size: ",
      getScreenSize(),
      "Operatin System: ",
      getOperatingSystem()
    );
  }
}
