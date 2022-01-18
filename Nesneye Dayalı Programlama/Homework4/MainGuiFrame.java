package Homework4;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

@SuppressWarnings("serial")
public class MainGuiFrame extends JFrame {

  ResultSet selectResult = null;
  private static Connection conn;
  private static PreparedStatement insertLogistic;
  private static PreparedStatement updateLogistic;
  private static PreparedStatement searchLogistic;

  public static void ConnectDB() {
    try {
      String serverAddr = "Samata\\SQLEXPRESS";
      String UserName = "sa";
      String password = "test";
      String dbName = "BIP2007_2021";
      String URL = "jdbc:sqlserver://" + serverAddr + ";databaseName=" + dbName;

      //connection
      conn = DriverManager.getConnection(URL, UserName, password);
      insertLogistic =
        conn.prepareStatement(
          "INSERT INTO Logistics " +
          "(TrackNr, CustomerName, PackageContent, Size, Unit, City) " +
          "VALUES (?, ?, ?, ?, ?, ?) "
        );

      searchLogistic =
        conn.prepareStatement("SELECT * FROM Logistics WHERE TrackNr=?");

      updateLogistic =
        conn.prepareStatement(
          "UPDATE Logistics SET CustomerName = ?, PackageContent = ?, Size = ?,  Unit = ?, City = ? WHERE TrackNr=?"
        );
    } catch (SQLException e) {
      e.printStackTrace();
      System.exit(0);
    }
  }

  //Search in NorthPanel
  private final JPanel ButtonPanel;
  private final JButton newLogisticsButton;
  private final JButton saveFilCloseButton;

  //Center Panel
  private final JLabel LogisticReg;
  private final JLabel TrukcLabel;
  private final JLabel nameLabel;
  private final JLabel packageContLabel;
  private final JLabel packageSizeLabel;
  private final JLabel selectUnitLabel;
  private final JLabel deliveryCityLabel;

  private final JTextField nameText;
  private final JTextField TruckText;
  private final JTextField packageContText;
  private final JTextField packageSizeText;

  private final JRadioButton m3RButton;
  private final JRadioButton kgRButton;

  private final ButtonGroup radioGroup;
  private final JButton sendButton;

  private final JComboBox<?> deliveryCityComb;
  private final String cityList[] = {
    "",
    "İstanbul",
    "Ankara",
    "İzmir",
    "Adana",
    "Kocaeli",
    "Other",
  };
  public Component frame;

  public MainGuiFrame() {
    super("SCB HOMEWROK");
    ConnectDB();
    BorderLayout layout = new BorderLayout(1, 1);
    setLayout(layout);

    //Create panels
    JPanel northPanel = new JPanel();
    northPanel.setBackground(Color.darkGray);
    JPanel centerPanel = new JPanel();
    //Add panels to frame
    add(northPanel, BorderLayout.NORTH);

    add(centerPanel, BorderLayout.CENTER);
    //North Panel ------------------------------------------------------------------------
    BorderLayout layout1 = new BorderLayout(1, 1);

    northPanel.setLayout(layout1);
    //ButtonPanel in NorthPanel ---------------------------------------------------------
    ButtonPanel = new JPanel();

    newLogisticsButton = new JButton("New Logistic Record ");
    saveFilCloseButton = new JButton("Close Window ");

    ButtonPanel.add(newLogisticsButton);
    ButtonPanel.add(saveFilCloseButton);

    ButtonPanel.setBackground(Color.darkGray);
    northPanel.add(ButtonPanel, BorderLayout.WEST);
    //Center Panel -------------------------------------------------------------------------
    centerPanel.setLayout(null);
    //Label
    LogisticReg = new JLabel("Logistics Record");
    LogisticReg.setFont(new Font("Arial", Font.ROMAN_BASELINE, 20));
    LogisticReg.setForeground(Color.BLUE);
    LogisticReg.setBounds(10, 10, 150, 25);
    centerPanel.add(LogisticReg);

    //add Truck Num -------------------------------------------------------------------------
    TrukcLabel = new JLabel("Truck Num : ");
    TrukcLabel.setBounds(10, 50, 150, 15);
    centerPanel.add(TrukcLabel);
    //add Textfield
    TruckText = new JTextField(20);
    TruckText.setBounds(150, 45, 150, 25);
    centerPanel.add(TruckText);

    //add Name -------------------------------------------------------------------------
    nameLabel = new JLabel("Name and Surname : ");
    nameLabel.setBounds(10, 80, 150, 15);
    centerPanel.add(nameLabel);
    //add Textfield
    nameText = new JTextField(20);
    nameText.setBounds(150, 75, 150, 25);
    centerPanel.add(nameText);

    //add Package Content -------------------------------------------------------------------------
    packageContLabel = new JLabel("Package Content : ");
    packageContLabel.setBounds(10, 110, 150, 15);
    centerPanel.add(packageContLabel);
    //add Textfield
    packageContText = new JTextField(20);
    packageContText.setBounds(150, 105, 150, 25);
    centerPanel.add(packageContText);

    //add Package Size -------------------------------------------------------------------------
    packageSizeLabel = new JLabel("Package Size : ");
    packageSizeLabel.setBounds(10, 140, 150, 15);
    centerPanel.add(packageSizeLabel);
    //add Textfield
    packageSizeText = new JTextField(20);
    packageSizeText.setBounds(150, 135, 150, 25);
    centerPanel.add(packageSizeText);

    //add Select Unit -------------------------------------------------------------------------
    selectUnitLabel = new JLabel("Select Unit : ");
    selectUnitLabel.setBounds(10, 170, 150, 15);
    centerPanel.add(selectUnitLabel);
    //add Gender Radio Buttons

    m3RButton = new JRadioButton("m3", false);
    kgRButton = new JRadioButton("kg", false);

    m3RButton.setBounds(150, 165, 100, 25);
    kgRButton.setBounds(250, 165, 100, 25);

    centerPanel.add(m3RButton);
    centerPanel.add(kgRButton);

    //Create Button Group -------------------------------------------------------------------------
    radioGroup = new ButtonGroup();
    radioGroup.add(m3RButton);
    radioGroup.add(kgRButton);

    //add Delivery City -------------------------------------------------------------------------
    deliveryCityLabel = new JLabel("Delivery City : ");
    deliveryCityLabel.setBounds(10, 200, 150, 15);
    centerPanel.add(deliveryCityLabel);
    //add Combo Box

    deliveryCityComb = new JComboBox<Object>(cityList);
    deliveryCityComb.setBounds(150, 195, 150, 25);
    centerPanel.add(deliveryCityComb);

    //add Button -------------------------------------------------------------------------
    sendButton = new JButton("Add to File");
    sendButton.setBounds(150, 235, 150, 25);
    centerPanel.add(sendButton);

    //Events -------------------------------------------------------------------------

    NewLogisticRecordHender NewLogicHend = new NewLogisticRecordHender();
    newLogisticsButton.addActionListener(NewLogicHend);

    NameKeyListener NameKeyList = new NameKeyListener();
    nameText.addKeyListener(NameKeyList);

    PackageSizeKeyListener PackageKeyList = new PackageSizeKeyListener();
    packageSizeText.addKeyListener(PackageKeyList);

    SaveCloseHendler SaveCloseHend = new SaveCloseHendler();
    saveFilCloseButton.addActionListener(SaveCloseHend);

    SubmidButtonHender SubmitHend = new SubmidButtonHender();
    sendButton.addActionListener(SubmitHend);
  }

  public void Clear() {
    //Text Field
    TruckText.setText("");
    nameText.setText("");
    packageContText.setText("");
    packageSizeText.setText("");
    //Combo Boxes
    deliveryCityComb.setSelectedIndex(0);
    //RadioButton
    radioGroup.clearSelection();
  }

  //CLEAR   -------------------------------------------------------------------------
  public class NewLogisticRecordHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      Clear();
    }
  }

  //NAME   -------------------------------------------------------------------------
  private class NameKeyListener implements KeyListener {

    @Override
    public void keyTyped(KeyEvent e) {
      String filterInt = "0123456789.";
      char c = (char) e.getKeyChar();
      if (filterInt.indexOf(c) > 0) {
        e.consume();
      }
    }

    @Override
    public void keyPressed(KeyEvent e) {}

    @Override
    public void keyReleased(KeyEvent e) {}
  }

  //PACKAGE SIZE    -------------------------------------------------------------------------

  private class PackageSizeKeyListener implements KeyListener {

    @Override
    public void keyTyped(KeyEvent e) {
      String filterStr = "0123456789.";
      char c = (char) e.getKeyChar();
      if (filterStr.indexOf(c) < 0) {
        e.consume();
      }
    }

    @Override
    public void keyPressed(KeyEvent t) {}

    @Override
    public void keyReleased(KeyEvent t) {}
  }

  //SAVE CLOSE BUTTON   -------------------------------------------------------------------------
  private class SaveCloseHendler implements ActionListener {

    public void actionPerformed(ActionEvent e) {
      int result = JOptionPane.showConfirmDialog(
        frame,
        "Sure? You want to exit?",
        "Exit",
        JOptionPane.YES_NO_OPTION,
        JOptionPane.QUESTION_MESSAGE
      );
      if (result == JOptionPane.YES_OPTION) {
        System.exit(0);
      } else if (result == JOptionPane.NO_OPTION) {
        JOptionPane.showMessageDialog(
          null,
          "Okey ",
          "Info",
          getDefaultCloseOperation()
        );
      }
    }
  }

  //SUBMITED -------------------------------------------------------------------------
  private class SubmidButtonHender implements ActionListener {

    public void actionPerformed(ActionEvent e) {
      ConnectDB();
      String Unit = "";
      if (m3RButton.isSelected()) Unit = "m3";
      if (kgRButton.isSelected()) Unit = "kg";
      if (
        TruckText.getText().equals("") ||
        nameText.getText().equals("") ||
        packageContText.getText().equals("") ||
        packageSizeText.getText().equals("") ||
        deliveryCityComb.getSelectedItem() == ""
      ) {
        if (
          !m3RButton.isSelected() || !kgRButton.isSelected()
        ) System.out.println("Each field must be filled.");
      } else {
        try {
          //Search vehicle number in table
          searchLogistic.setString(1, TruckText.getText());
          selectResult = searchLogistic.executeQuery();
          //UPDATE row If there is a row returning from SELECT statement
          if (selectResult.next()) { //is there any row returning from SELECT
            //Prepare SQL Statement = Write the values for ?
            updateLogistic.setString(1, nameText.getText());
            updateLogistic.setString(2, packageContText.getText());
            updateLogistic.setString(3, packageSizeText.getText());
            updateLogistic.setString(4, Unit);
            updateLogistic.setString(
              5,
              (String) deliveryCityComb.getSelectedItem()
            );
            updateLogistic.setString(6, TruckText.getText());
            System.out.println("Veri Güncellendi");
            //update the entry
            //Execution
            updateLogistic.execute();
            conn.close();
            //Prepare SQL Statement = Write the values for ?
          } else {
            //INSERT if no data returned from SELECT
            insertLogistic.setString(1, TruckText.getText());
            insertLogistic.setString(2, nameText.getText());
            insertLogistic.setString(3, packageContText.getText());
            insertLogistic.setString(4, packageSizeText.getText());
            insertLogistic.setString(5, Unit);
            insertLogistic.setString(
              6,
              (String) deliveryCityComb.getSelectedItem()
            );
            System.out.println("Veri Yolladandı");
            //insert the new entry
            //Execution
            insertLogistic.execute();
            conn.close();
            Clear();
          }
        } catch (SQLException e1) {
          e1.printStackTrace();
          System.exit(1);
        }
      }
    }
  }
}
/* \    /\ 
		)  ( ')
		(  /  )
SCB  \(__)|
*/
