package Homework1;

public abstract class Product {
  private String productName;
  private String modelType;
  private String brand;
  private double price;

  public static int numberOfVehicles;

  public Product(
    String productName,
    String modelType,
    String brand,
    double price
  ) {
    this.productName = productName;
    this.modelType = modelType;
    this.brand = brand;
    this.setPrice(price);

    numberOfVehicles++;
  }

  public String getProductName() {
    return productName;
  }

  public String getModelType() {
    return modelType;
  }

  public String getBrand() {
    return brand;
  }

  public double getPrice() {
    return price;
  }

  public void setPrice(double price) {
    this.price = price;
  }

  public String toString() {
    return String.format(
      "%s%s%n%s%s%n%s%s%n%s%s%n",
      "Product Name: ",
      getProductName(),
      "Model Type: ",
      getModelType(),
      "Brand: ",
      getBrand(),
      "Price: ",
      getPrice()
    );
  }
}
