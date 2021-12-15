package Homework1;

public class Main {

  // BU �DEV'� HAZIRLAYANLAR
  //�AFAK CAN BAV 20190108028
  //MUSA KARTAL 20190108050
  public static void main(String[] args) {
    Product.numberOfVehicles = 0;
    double totalPriceOfAllProducts = 0;
    Product[] myProduct = new Product[6];

    //LAPTOP PART
    Product[] myLepTop = new Laptop[2];
    myLepTop[0] =
      new Laptop(
        "Lenovo Legion 5 15 Gaming Laptop",
        "Gaming Laptop",
        "Lenovo",
        4000.0,
        15.60,
        "Windows 10"
      );
    myLepTop[1] =
      new Laptop(
        "Asus Chromebook CX1",
        "Smart LED TV",
        "ASUS",
        5500.0,
        11.60,
        "Chrome OS"
      );

    //CellPhone Part
    Product[] myCellPhone = new CellPhone[2];
    myCellPhone[0] =
      new CellPhone(
        "Samsung Galaxy S21 Ultra",
        "S21 Ultra",
        "Samsung",
        12000.0,
        128.00,
        "Android"
      );
    myCellPhone[1] =
      new CellPhone(
        "Apple Iphone 11 Pro Max",
        "11",
        "Apple",
        10000.0,
        256.00,
        "IOS12"
      );

    //Television Part
    Product[] myTelevision = new Television[2];
    myTelevision[0] =
      new Television(
        "LG Electronics 24LM530S-PU 24-Inch HD webOS 3.5",
        "Smart Tv",
        "LG",
        1000.0,
        24.00,
        720.00
      );
    myTelevision[1] =
      new Television(
        "
		SAMSUNG Electronics UN32M4500A 32-Inch 720p",
        "Smart LED Tv",
        "Samsung",
        1500.0,
        32.00,
        720.00
      );

    //Last Part
    myProduct[0] = myLepTop[0];
    myProduct[1] = myLepTop[1];
    myProduct[2] = myCellPhone[0];
    myProduct[3] = myCellPhone[1];
    myProduct[4] = myTelevision[0];
    myProduct[5] = myTelevision[1];

    for (int i = 0; i < myProduct.length; i++) {
      System.out.println(myProduct[i].getClass().getSimpleName());
      System.out.println("--------------------------------");
      System.out.println(myProduct[i].toString());

      totalPriceOfAllProducts += myProduct[i].getPrice();
    }
    System.out.println(
      "Number of Vehicles Created: " + Product.numberOfVehicles
    );
    System.out.println(
      "Total Price of All Products: " + totalPriceOfAllProducts + "TL"
    );
  }
}
