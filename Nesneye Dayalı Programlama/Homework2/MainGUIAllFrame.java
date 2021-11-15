package Homework2;

//Layout manager
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
//Handler Classes
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

public class MainGUIAllFrame extends JFrame {
  //West Panel
  private final JButton listDepartButton;
  private final JButton updateUserButton;
  private final JButton deletUserButton;
  private final JButton listUserButton;
  private final JButton addUserButton;
  //Search in NorthPanel
  private final JTextField searchText;
  private final JPanel searchPanel;
  private final JPanel userRegPanel;
  private final JLabel searchlabel;
  private final JLabel userReg;
  //South Panel
  private final JLabel appFooter;
  private final FlowLayout footLayout;

  //NORMAL Panel
  private final JLabel nameLabel;
  private final JLabel tcNumLabel;
  private final JLabel passwordLabel;
  private final JLabel cityLabel;
  private final JLabel titleLabel;
  private final JLabel languageLabel;
  private final JLabel genderLabel;

  private final JTextField nameText;
  private final JTextField tcText;
  private final JPasswordField passwordText;

  private final JComboBox<?> departCombo;
  private final String departList[] = {
    "Select",
    "Depart1",
    "Depart2",
    "Depart3",
    "Depart4",
    "Depart5",
  };

  private final JComboBox<?> titleCombo;
  private final String titleList[] = {
    "Select",
    "Test1",
    "Test2",
    "Test3",
    "Test4",
    "Test5",
  };

  private final JCheckBox EngCheck;
  private final JCheckBox GermanCheck;
  private final JCheckBox FrenchCheck;
  private final JCheckBox OtherCheck;

  private final JRadioButton maleRButton;
  private final JRadioButton femaleRButton;
  private final JRadioButton otherRButton;

  
  private final ButtonGroup radioGroup;
  private final JButton sendButton;

  public MainGUIAllFrame() {
    super("SCB HOMEWROK");
    BorderLayout layout = new BorderLayout(1, 1);
    setLayout(layout);

    //Create panels
    JPanel northPanel = new JPanel();
    northPanel.setBackground(Color.YELLOW);
    JPanel southPanel = new JPanel();
    southPanel.setBackground(Color.BLUE);
    JPanel westPanel = new JPanel();
    westPanel.setBackground(Color.RED);
    JPanel centerPanel = new JPanel();

    //Add panels to frame
    add(northPanel, BorderLayout.NORTH);
    add(southPanel, BorderLayout.SOUTH);
    add(westPanel, BorderLayout.WEST);
    add(centerPanel, BorderLayout.CENTER);

    //North Panel ------------------------------------------------------------------------

    BorderLayout layout1 = new BorderLayout(1, 1);
    northPanel.setLayout(layout1);

    //UserRegPanel in NorthPanel ---------------------------------------------------------
    userRegPanel = new JPanel();
    userReg = new JLabel("USER REGISTRATION ");
    userReg.setFont(new Font("Arial", Font.ROMAN_BASELINE, 20));
    userReg.setForeground(Color.BLUE);

    userRegPanel.add(userReg);
    northPanel.add(userRegPanel, BorderLayout.WEST);
    userRegPanel.setBackground(Color.YELLOW);

    //Search in NorthPanel ---------------------------------------------------------------
    searchPanel = new JPanel();
    searchPanel.setBackground(Color.YELLOW);

    searchlabel = new JLabel("Search : ");

    searchText = new JTextField(10);
    searchPanel.add(searchlabel);
    searchPanel.add(searchText);
    northPanel.add(searchPanel, BorderLayout.EAST);

    //West Panel -------------------------------------------------------------------------

    GridLayout layout3 = new GridLayout(13, 5, 5, 5);
    westPanel.setLayout(layout3);

    addUserButton = new JButton("Add User");
    JLabel space = new JLabel(""); 
    listUserButton = new JButton("List All User");
    listDepartButton = new JButton("List By Department");
    updateUserButton = new JButton("User Update");
    deletUserButton = new JButton("Delete User");

    westPanel.add(addUserButton);
    westPanel.add(space);
    westPanel.add(listUserButton);
    westPanel.add(listDepartButton);
    westPanel.add(updateUserButton);
    westPanel.add(deletUserButton);

    //South Panel -------------------------------------------------------------------------

    footLayout = new FlowLayout();
    footLayout.setAlignment(FlowLayout.LEFT);
    southPanel.setLayout(footLayout);

    appFooter = new JLabel("2020 © PRU");
    appFooter.setFont(new Font("Serif", Font.BOLD, 15));
    appFooter.setForeground(Color.WHITE);
    southPanel.add(appFooter);

    //Center Panel -------------------------------------------------------------------------

    centerPanel.setLayout(null);

    //add Name
    nameLabel = new JLabel("Name and Surname : ");
    nameLabel.setBounds(10, 20, 150, 15);
    centerPanel.add(nameLabel);

    //add Textfield
    nameText = new JTextField(20);
    nameText.setBounds(150, 20, 150, 25);
    centerPanel.add(nameText);

    //add TC Number
    tcNumLabel = new JLabel("TC ID Number : ");
    tcNumLabel.setBounds(10, 50, 150, 15);
    centerPanel.add(tcNumLabel);

    //add Textfield
    tcText = new JTextField(20);
    tcText.setBounds(150, 50, 150, 25);
    centerPanel.add(tcText);

    //add Password
    passwordLabel = new JLabel("Password : ");
    passwordLabel.setBounds(10, 80, 150, 15);
    centerPanel.add(passwordLabel);

    //add passwordText
    passwordText = new JPasswordField(20);
    passwordText.setBounds(150, 80, 150, 25);
    centerPanel.add(passwordText);

    //add Department
    cityLabel = new JLabel("Department : ");
    cityLabel.setBounds(10, 110, 150, 15);
    centerPanel.add(cityLabel);

    departCombo = new JComboBox<Object>(departList);
    departCombo.setBounds(150, 110, 150, 25);
    centerPanel.add(departCombo);

    //add Department
    titleLabel = new JLabel("Title : ");
    titleLabel.setBounds(10, 140, 150, 15);
    centerPanel.add(titleLabel);

    titleCombo = new JComboBox<Object>(titleList);
    titleCombo.setBounds(150, 140, 150, 25);
    centerPanel.add(titleCombo);

    //add Languages
    languageLabel = new JLabel("Languages : ");
    languageLabel.setBounds(10, 170, 150, 15);
    centerPanel.add(languageLabel);

    //add Languages checkboxes
    EngCheck = new JCheckBox("English");
    GermanCheck = new JCheckBox("German");
    FrenchCheck = new JCheckBox("French");
    OtherCheck = new JCheckBox("Other");
    EngCheck.setBounds(150, 170, 80, 25);
    GermanCheck.setBounds(250, 170, 80, 25);
    FrenchCheck.setBounds(350, 170, 80, 25);
    OtherCheck.setBounds(450, 170, 80, 25);
    centerPanel.add(EngCheck);
    centerPanel.add(GermanCheck);
    centerPanel.add(FrenchCheck);
    centerPanel.add(OtherCheck);

    //add Gender
    genderLabel = new JLabel("Select Gender : ");
    genderLabel.setBounds(10, 200, 150, 25);
    centerPanel.add(genderLabel);

    //add Gender Radio Buttons
    maleRButton = new JRadioButton("Male", false);
    femaleRButton = new JRadioButton("Female", false);
    otherRButton = new JRadioButton("Other", false);
    maleRButton.setBounds(150, 200, 100, 25);
    femaleRButton.setBounds(250, 200, 100, 25);
    otherRButton.setBounds(350, 200, 100, 25);
    centerPanel.add(maleRButton);
    centerPanel.add(femaleRButton);
    centerPanel.add(otherRButton);

    //Create Button Group
    radioGroup = new ButtonGroup();
    radioGroup.add(maleRButton);
    radioGroup.add(femaleRButton);
    radioGroup.add(otherRButton);

    //add Button
    sendButton = new JButton("Submit");
    sendButton.setBounds(150, 230, 150, 25);
    centerPanel.add(sendButton);

    //Events -------------------------------------------------------------------------

    SearchEventHender SearchHend = new SearchEventHender();
    searchText.addActionListener(SearchHend);

    NameEvetHender NameHend = new NameEvetHender();
    nameText.addActionListener(NameHend);

    NameKeyListener NameKeyList = new NameKeyListener();
    nameText.addKeyListener(NameKeyList);

    TcNumEventHender TcHend = new TcNumEventHender();
    tcText.addKeyListener(TcHend);

    DepartEvetHender DepartHend = new DepartEvetHender();
    departCombo.addActionListener(DepartHend);

    TitleEvetHender TitleHend = new TitleEvetHender();
    titleCombo.addActionListener(TitleHend);

    LanguagEventeHender LanguageHend = new LanguagEventeHender();
    EngCheck.addActionListener(LanguageHend);
    GermanCheck.addActionListener(LanguageHend);
    FrenchCheck.addActionListener(LanguageHend);
    OtherCheck.addActionListener(LanguageHend);

    GenderEventHender GenderHend = new GenderEventHender();
    maleRButton.addActionListener(GenderHend);
    femaleRButton.addActionListener(GenderHend);
    otherRButton.addActionListener(GenderHend);

    AdduserEventHender AddUserHend = new AdduserEventHender();
    addUserButton.addActionListener(AddUserHend);

    ListAllUserEventHender ListAllUserHend = new ListAllUserEventHender();
    listUserButton.addActionListener(ListAllUserHend);

    ListDepartmentHender ListDepartmentHend = new ListDepartmentHender();
    listDepartButton.addActionListener(ListDepartmentHend);

    SubmidButtonHender SubmitHend = new SubmidButtonHender();
    sendButton.addActionListener(SubmitHend);
  }

  // Search   -------------------------------------------------------------------------
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

  // Name   -------------------------------------------------------------------------
  private class NameEvetHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent e) {
      JOptionPane.showMessageDialog(
        null,
        nameText.getText(),
        "Name",
        getDefaultCloseOperation()
      );
    }
  }

  // Name   -------------------------------------------------------------------------
  private class NameKeyListener implements KeyListener {
    String oldNameText = "";

    @Override
    public void keyTyped(KeyEvent e) {}

    @Override
    public void keyPressed(KeyEvent e) {
      oldNameText = nameText.getText();
    }

    @Override
    public void keyReleased(KeyEvent e) {
      if (
        e.getKeyChar() == '0' ||
        e.getKeyChar() == '1' ||
        e.getKeyChar() == '2' ||
        e.getKeyChar() == '3' ||
        e.getKeyChar() == '4' ||
        e.getKeyChar() == '5' ||
        e.getKeyChar() == '6' ||
        e.getKeyChar() == '7' ||
        e.getKeyChar() == '8' ||
        e.getKeyChar() == '8' ||
        e.getKeyChar() == '9'
      ) {
        System.out.println("Don’t allow numeric values ");
        nameText.setText(oldNameText);
      }
    }
  }

  // TC   -------------------------------------------------------------------------

  private class TcNumEventHender implements KeyListener {
    String oldTcText = "";

    @Override
    public void keyTyped(KeyEvent t) {}

    @Override
    public void keyPressed(KeyEvent t) {
      oldTcText = tcText.getText();
    }

    @Override
    public void keyReleased(KeyEvent t) {
      try {
        int i = Integer.parseInt(tcText.getText());
      } catch (NumberFormatException e1) {
        tcText.setText(oldTcText);
        System.out.println(
          "Allow only numeric values and the length should be 11 chars "
        );
      }
      if (tcText.getText().length() > 11) {
        System.out.println(
          "Allow only numeric values and the length should be 11 chars "
        );
      }
    }
  }

  // DEPARTMENT -------------------------------------------------------------------------

  private class DepartEvetHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      if (departCombo.getSelectedIndex() != 0) JOptionPane.showMessageDialog(
        null,
        departCombo.getSelectedItem(),
        "Department",
        getDefaultCloseOperation()
      );
    }
  }

  // TITLE -------------------------------------------------------------------------
  private class TitleEvetHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      if (titleCombo.getSelectedIndex() != 0) JOptionPane.showMessageDialog(
        null,
        titleCombo.getSelectedItem(),
        "Title",
        getDefaultCloseOperation()
      );
    }
  }

  //LANGUAGES -------------------------------------------------------------------------

  private class LanguagEventeHender implements ActionListener {
    String selection = "";

    @Override
    public void actionPerformed(ActionEvent event) {
      if (EngCheck.isSelected()) selection += "English\n";
      if (GermanCheck.isSelected()) selection += "German\n";
      if (FrenchCheck.isSelected()) selection += "French\n";
      if (OtherCheck.isSelected()) selection += "OtherCheck\n";
      JOptionPane.showMessageDialog(
        null,
        selection,
        "Language",
        getDefaultCloseOperation()
      );
      if (selection != null) selection = "";
    }
  }

  //GENDER -------------------------------------------------------------------------
  private class GenderEventHender implements ActionListener {
    String Gender = "";

    @Override
    public void actionPerformed(ActionEvent event) {
      if (maleRButton.isSelected()) Gender = "Man";
      if (femaleRButton.isSelected()) Gender = "Famale";
      if (otherRButton.isSelected()) Gender = "Other";

      JOptionPane.showMessageDialog(
        null,
        Gender,
        "Gender",
        getDefaultCloseOperation()
      );
    }
  }

  //ADD USER -------------------------------------------------------------------------
  private class AdduserEventHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      //Text Field
      searchText.setText("");
      nameText.setText("");
      tcText.setText("");
      passwordText.setText("");
      //Combo Boxes
      departCombo.setSelectedIndex(0);
      titleCombo.setSelectedIndex(0);
      //Select Boxes
      EngCheck.setSelected(false);
      GermanCheck.setSelected(false);
      FrenchCheck.setSelected(false);
      OtherCheck.setSelected(false);
      //RadioButton
      radioGroup.clearSelection();
    }
  }

  //List All Users -------------------------------------------------------------------------
  private class ListAllUserEventHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      JOptionPane.showMessageDialog(
        null,
        "Show list of all users ",
        "List User",
        getDefaultCloseOperation()
      );
    }
  }

  //List All Users By Department -------------------------------------------------------------------------
  private class ListDepartmentHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      JOptionPane.showMessageDialog(
        null,
        "Show list of all users by department ",
        "List User Department",
        getDefaultCloseOperation()
      );
    }
  }

  //SUBMITED -------------------------------------------------------------------------
  private class SubmidButtonHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      JOptionPane.showMessageDialog(
        null,
        "Form submitted ",
        "Submited",
        getDefaultCloseOperation()
      );
    }
  }
}
