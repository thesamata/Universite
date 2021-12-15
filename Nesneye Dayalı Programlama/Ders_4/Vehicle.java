package Ders_4;

public class Vehicle {
  private String vehicleNo;
  private String prodStart;
  private char vStatus;
  private String deliveryDate;
  private String customerName;
  private String desc;

  //constructor
  public Vehicle(String dataInput) {
    //fixed length data
    //Vehicle No (10 chars) - first 5 chars = vehicle type
    //Prod Start date (10 chars)
    //Status of vehicle (1 char, C:Completed W:Waiting D:On Delivery
    //Delivery date (10 chars)
    //Name of Customer (20 chars)
    //Description (remaining chars)

    //substring & charAt
    vehicleNo = dataInput.substring(0, 10);
    prodStart = dataInput.substring(10, 20);
    vStatus = dataInput.charAt(20);
    deliveryDate = dataInput.substring(21, 31);
    customerName = dataInput.substring(31, 51);
    desc = dataInput.substring(51); //from 51 to the end of string
  }

  public String toString() {
    return String.format(
      "%s: %s%n%s: %s%n%s: %c%n%s: %s%n%s: %s%n%s: %s%n",
      "Vehicle Nr",
      vehicleNo,
      "Prod Start Date",
      prodStart,
      "Status",
      vStatus,
      "Delivery Date",
      deliveryDate,
      "Customer Name",
      customerName,
      "Description",
      desc
    );
  }

  public String getVehicleNo() {
    return vehicleNo;
  }

  public String getCustomerName() {
    return customerName;
  }

  public String getDesc() {
    return desc;
  }

  public boolean isTurkeyPlant() {
    //startsWith Example
    //581 = Turkey
    if (vehicleNo.startsWith("581", 2)) return true; else return false;
  }

  public boolean isDeliveredOnTime(int redDelYear) {
    //valueof
    String reqDelYearString = String.valueOf(redDelYear);
    //substring
    String delYearString = deliveryDate.substring(6, 10);

    //equals
    return delYearString.equals(reqDelYearString);
  }

  public boolean validateCustomerName() {
    //split
    String[] nameparts = customerName.split(" ");
    boolean returnvalue = false;

    //Regular Expression - matches Example
    for (String namepart : nameparts) {
      if (namepart.matches("[a-zA-Z]*")) returnvalue = true;
    }
    return returnvalue;
  }
}
