package Fina_SCB;

//Layout manager
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
//Handler Classes
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
import javax.swing.JPasswordField;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

public class FinalGuiFrame extends JFrame {

  /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
public Component frame;
  ResultSet selectResult = null;
  private static Connection conn;
  private static PreparedStatement insertUser;
  private static PreparedStatement updateUser;
  private static PreparedStatement searchUser;

  public static void ConnectDB() {
    try {
      String serverAddr = "Samata\\SQLEXPRESS";
      String UserName = "sa";
      String password = "test";
      String dbName = "BIP2007_2021";
      String URL = "jdbc:sqlserver://" + serverAddr + ";databaseName=" + dbName;

      //connection
      conn = DriverManager.getConnection(URL, UserName, password);
      insertUser =
        conn.prepareStatement(
          "INSERT INTO Users " +
          "(TCIDNumber, UserName, UserPassword, Department, Title, Gender) " +
          "VALUES (?, ?, ?, ?, ?, ?) "
        );

      searchUser =
        conn.prepareStatement("SELECT * FROM Users WHERE TCIDNumber=?");

      updateUser =
        conn.prepareStatement(
          "UPDATE Users SET UserName = ?, UserPassword = ?, Department = ?,  Title = ?, Gender = ? WHERE TCIDNumber=?"
        );
    } catch (SQLException e) {
      e.printStackTrace();
      System.exit(0);
    }
  }

  //West Panel
  private final JButton newUserButton;
  private final JButton deletUserButton;
  private final JButton listUserButton;
  private final JButton listByDepartment;
  private final JButton closeWindow;

  //------------------------------------------------------------------------

  //Search in NorthPanel
  private final JTextField searchText;
  private final JPanel searchPanel;
  private final JPanel userRegPanel;
  private final JLabel searchlabel;
  private final JLabel userReg;

  //------------------------------------------------------------------------

  //South Panel
  private final JLabel appFooter;
  private final FlowLayout footLayout;

  //------------------------------------------------------------------------

  //NORMAL Panel
  private final JLabel nameLabel;
  private final JLabel tcNumLabel;
  private final JLabel passwordLabel;
  private final JLabel cityLabel;
  private final JLabel titleLabel;
  private final JLabel genderLabel;

  private final JTextField nameText;
  private final JTextField tcText;
  private final JPasswordField passwordText;

  private final JComboBox<?> departCombo;
  private final String departList[] = {
    "",
    "Finance",
    "Sales",
    "Accounting",
    "HR",
    "Logistics",
  };

  private final JComboBox<?> titleCombo;
  private final String titleList[] = {
    "",
    "CEO",
    "Manager",
    "Programmer",
    "Analyst",
    "Specialist",
  };
  private final JRadioButton maleRButton;
  private final JRadioButton femaleRButton;
  private final JRadioButton otherRButton;

  private final ButtonGroup genderRadioGroup;
  private final JButton sendButton;

  public FinalGuiFrame() {
    super("SCB HOMEWROK");
    BorderLayout layout = new BorderLayout(1, 1);
    setLayout(layout);

    //Create panels
    JPanel northPanel = new JPanel();
    northPanel.setBackground(Color.BLUE);
    //------------------------------------------------------------------------
    JPanel westPanel = new JPanel();
    westPanel.setBackground(Color.YELLOW);
    //------------------------------------------------------------------------
    JPanel southPanel = new JPanel();
    southPanel.setBackground(Color.RED);
    //------------------------------------------------------------------------
    JPanel centerPanel = new JPanel();

    //Add Panels to Frame ------------------------------------------------------------------------
    add(northPanel, BorderLayout.NORTH);
    add(southPanel, BorderLayout.SOUTH);
    add(westPanel, BorderLayout.WEST);
    add(centerPanel, BorderLayout.CENTER);

    //North Panel ------------------------------------------------------------------------

    BorderLayout nortLayout = new BorderLayout(1, 1);
    northPanel.setLayout(nortLayout);

    //UserRegPanel in NorthPanel ---------------------------------------------------------
    userRegPanel = new JPanel();
    userReg = new JLabel("USER REGISTRATION ");
    userReg.setFont(new Font("Arial", Font.ROMAN_BASELINE, 20));
    userReg.setForeground(Color.WHITE);

    userRegPanel.add(userReg);
    northPanel.add(userRegPanel, BorderLayout.WEST);
    userRegPanel.setBackground(Color.BLUE);
    //Search in NorthPanel ---------------------------------------------------------------
    searchPanel = new JPanel();
    searchPanel.setBackground(Color.BLUE);

    searchlabel = new JLabel("Search : ");
    searchlabel.setFont(new Font("Arial", Font.BOLD, 14));
    searchlabel.setForeground(Color.WHITE);
    searchText = new JTextField(10);
    searchPanel.add(searchlabel);
    searchPanel.add(searchText);
    northPanel.add(searchPanel, BorderLayout.EAST);

    //West Panel -------------------------------------------------------------------------

    GridLayout westLeyout = new GridLayout(14, 5, 5, 5);
    westPanel.setLayout(westLeyout);

    newUserButton = new JButton("New User");
    deletUserButton = new JButton("Delete User");
    listUserButton = new JButton("List All User");
    listByDepartment = new JButton("List By Deparment");
    closeWindow = new JButton("Close Window");

    westPanel.add(newUserButton);
    westPanel.add(deletUserButton);
    westPanel.add(listUserButton);
    westPanel.add(listByDepartment);
    westPanel.add(closeWindow);

    //South Panel -------------------------------------------------------------------------

    footLayout = new FlowLayout();
    footLayout.setAlignment(FlowLayout.CENTER);
    southPanel.setLayout(footLayout);

    appFooter = new JLabel("2021 © PRU");
    appFooter.setFont(new Font("Arial", Font.BOLD, 15));
    appFooter.setForeground(Color.WHITE);
    southPanel.add(appFooter);

    //Center Panel -------------------------------------------------------------------------
    centerPanel.setLayout(null);

    //add TC Number
    tcNumLabel = new JLabel("TC ID Number : ");
    tcNumLabel.setBounds(10, 20, 150, 15);
    centerPanel.add(tcNumLabel);

    //add Textfield
    tcText = new JTextField(20);
    tcText.setBounds(150, 20, 150, 25);
    centerPanel.add(tcText);
    //------------------------------------------------------------------------
    //add Name
    nameLabel = new JLabel("Name and Surname : ");
    nameLabel.setBounds(10, 50, 150, 15);
    centerPanel.add(nameLabel);

    //add Textfield
    nameText = new JTextField(20);
    nameText.setBounds(150, 50, 150, 25);
    centerPanel.add(nameText);
    //------------------------------------------------------------------------
    //add Password
    passwordLabel = new JLabel("Password : ");
    passwordLabel.setBounds(10, 80, 150, 15);
    centerPanel.add(passwordLabel);

    //add passwordText
    passwordText = new JPasswordField(20);
    passwordText.setBounds(150, 80, 150, 25);
    centerPanel.add(passwordText);
    //------------------------------------------------------------------------
    //add Department
    cityLabel = new JLabel("Department : ");
    cityLabel.setBounds(10, 110, 150, 15);
    centerPanel.add(cityLabel);

    departCombo = new JComboBox<Object>(departList);
    departCombo.setBounds(150, 110, 150, 25);
    centerPanel.add(departCombo);
    //------------------------------------------------------------------------
    //add Title
    titleLabel = new JLabel("Title : ");
    titleLabel.setBounds(10, 140, 150, 15);
    centerPanel.add(titleLabel);

    titleCombo = new JComboBox<Object>(titleList);
    titleCombo.setBounds(150, 140, 150, 25);
    centerPanel.add(titleCombo);
    //------------------------------------------------------------------------
    //add Gender
    genderLabel = new JLabel("Select Gender : ");
    genderLabel.setBounds(10, 170, 150, 25);
    centerPanel.add(genderLabel);

    //add Gender Radio Buttons
    maleRButton = new JRadioButton("Male", false);
    femaleRButton = new JRadioButton("Female", false);
    otherRButton = new JRadioButton("Other", false);
    femaleRButton.setBounds(150, 170, 100, 25);
    maleRButton.setBounds(250, 170, 100, 25);
    otherRButton.setBounds(350, 170, 100, 25);
    centerPanel.add(maleRButton);
    centerPanel.add(femaleRButton);
    centerPanel.add(otherRButton);

    //Create Button Group
    genderRadioGroup = new ButtonGroup();
    genderRadioGroup.add(maleRButton);
    genderRadioGroup.add(femaleRButton);
    genderRadioGroup.add(otherRButton);
    //------------------------------------------------------------------------
    //add Button
    sendButton = new JButton("Add to Database");
    sendButton.setBounds(150, 200, 150, 25);
    centerPanel.add(sendButton);

    //Events -------------------------------------------------------------------------

    SearchEventHender SearchHend = new SearchEventHender();
    searchText.addActionListener(SearchHend);

    NewUserHender NewLogicHend = new NewUserHender();
    newUserButton.addActionListener(NewLogicHend);

    NameKeyListener NameKeyList = new NameKeyListener();
    nameText.addKeyListener(NameKeyList);

    TCKeyListener TCKeyList = new TCKeyListener();
    tcText.addKeyListener(TCKeyList);

    CloseWindowHendler SaveCloseHend = new CloseWindowHendler();
    closeWindow.addActionListener(SaveCloseHend);

    SubmidButtonHender SubmitHend = new SubmidButtonHender();
    sendButton.addActionListener(SubmitHend);
  }

  // Clear Fon ------------------------------------------------------------------------
  public void Clear() {
    //Text Field
    tcText.setText("");
    nameText.setText("");
    passwordText.setText("");
    //Combo Boxes
    departCombo.setSelectedIndex(0);
    titleCombo.setSelectedIndex(0);
    //RadioButton
    genderRadioGroup.clearSelection();
  }

  //Search User   -------------------------------------------------------------------------
  private class SearchEventHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent e) {
      JOptionPane.showMessageDialog(
        null,
        searchText.getText(),
        "Search",
        getDefaultCloseOperation()
      );
    }
  }

  //New User   -------------------------------------------------------------------------
  public class NewUserHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      Clear();
    }
  }

  //Name Control   -------------------------------------------------------------------------
  private class NameKeyListener implements KeyListener {

    @Override
    public void keyTyped(KeyEvent e) {
      String filterInt = "0123456789";
      char c = (char) e.getKeyChar();
      if (filterInt.indexOf(c) > 0) { // without string value
        e.consume();
      }
    }

    @Override
    public void keyPressed(KeyEvent e) {}

    @Override
    public void keyReleased(KeyEvent e) {}
  }

  //Tc Control    -------------------------------------------------------------------------
  private class TCKeyListener implements KeyListener {

    @Override
    public void keyTyped(KeyEvent e) {
      String filterStr = "0123456789";
      char c = (char) e.getKeyChar();
      if (filterStr.indexOf(c) < 0) { // without int value
        e.consume();
      }
      if (tcText.getText().length() >= 11) e.consume(); // limit textfield to 11 characters
    }

    @Override
    public void keyPressed(KeyEvent t) {}

    @Override
    public void keyReleased(KeyEvent t) {}
  }

  //Close Window   -------------------------------------------------------------------------
  private class CloseWindowHendler implements ActionListener {

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

  //Add to Database    -------------------------------------------------------------------------
  private class SubmidButtonHender implements ActionListener {

    public void actionPerformed(ActionEvent e) {
      ConnectDB();
      String Gender = "";
      // Selection Gender
      if (maleRButton.isSelected()) Gender = "Man";
      if (femaleRButton.isSelected()) Gender = "Famale";
      if (otherRButton.isSelected()) Gender = "Other";
      // All fields are required
      if (
        tcText.getText().equals("") ||
        tcText.getText().length() < 11 ||
        nameText.getText().equals("") ||
        passwordText.getPassword().length == 0 ||
        departCombo.getSelectedItem() == "" ||
        titleCombo.getSelectedItem() == "" ||
        Gender == ""
      ) {
        System.out.println("All fields are required");
      } else {
        try {
          //Search vehicle number in table
          searchUser.setString(1, tcText.getText());
          selectResult = searchUser.executeQuery();
          //UPDATE row If there is a row returning from SELECT statement
          if (selectResult.next()) { //is there any row returning from SELECT
            //Prepare SQL Statement = Write the values for ?
            updateUser.setString(1, nameText.getText());
            updateUser.setString(2, new String(passwordText.getPassword()));
            updateUser.setString(3, (String) departCombo.getSelectedItem());
            updateUser.setString(4, (String) titleCombo.getSelectedItem());
            updateUser.setString(5, Gender);
            updateUser.setString(6, tcText.getText());
            System.out.println("Update the record");
            //update the entry
            //Execution
            updateUser.execute();
            conn.close();
            //Prepare SQL Statement = Write the values for ?
          } else {
            //INSERT if no data returned from SELECT
            insertUser.setString(1, tcText.getText());
            insertUser.setString(2, nameText.getText());
            insertUser.setString(3, new String(passwordText.getPassword()));
            insertUser.setString(4, (String) departCombo.getSelectedItem());
            insertUser.setString(5, (String) titleCombo.getSelectedItem());
            insertUser.setString(6, Gender);
            System.out.println("Insert new record to Users table");
            //insert the new entry
            //Execution
            insertUser.execute();
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
