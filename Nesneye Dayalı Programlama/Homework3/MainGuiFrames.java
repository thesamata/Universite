package Homework3;

//Layout manager
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;

import java.awt.Font;

import java.awt.event.ActionEvent;
//Handler Classes
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.io.File;
import java.io.FileWriter;

import javax.swing.ButtonGroup;
import javax.swing.JButton;

import javax.swing.JComboBox;
import javax.swing.JFrame;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import javax.swing.JRadioButton;
import javax.swing.JTextField;

public class MainGuiFrames extends JFrame {
  /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
//Search in NorthPanel
  private final JPanel ButtonPanel;
  private final JButton newLogisticsButton;
  private final JButton saveFilCloseButton;

  //Center Panel
  private final JLabel LogisticReg;
  private final JLabel nameLabel;
  private final JLabel packageContLabel;
  private final JLabel packageSizeLabel;
  private final JLabel selectUnitLabel;
  private final JLabel deliveryCityLabel;

  private final JTextField nameText;
  private final JTextField packageContText;
  private final JTextField packageSizeText;

  private final JRadioButton m3RButton;
  private final JRadioButton kgRButton;

  private final ButtonGroup radioGroup;
  private final JButton sendButton;

  private final JComboBox<?> deliveryCityComb;
  private final String cityList[] = {
    "",
    "Ýstanbul",
    "Ankara",
    "Ýzmir",
    "Adana",
    "Kocaeli",
    "Other",
  };
  public Component frame;

  public MainGuiFrames() {
    super("SCB HOMEWROK");
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
    saveFilCloseButton = new JButton("Save File and Close Window ");

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

    //add Name -------------------------------------------------------------------------
    nameLabel = new JLabel("Name and Surname : ");
    nameLabel.setBounds(10, 50, 150, 15);
    centerPanel.add(nameLabel);
    //add Textfield
    nameText = new JTextField(20);
    nameText.setBounds(150, 45, 150, 25);
    centerPanel.add(nameText);

    //add Package Content -------------------------------------------------------------------------
    packageContLabel = new JLabel("Package Content : ");
    packageContLabel.setBounds(10, 80, 150, 15);
    centerPanel.add(packageContLabel);
    //add Textfield
    packageContText = new JTextField(20);
    packageContText.setBounds(150, 75, 150, 25);
    centerPanel.add(packageContText);

    //add Package Size -------------------------------------------------------------------------
    packageSizeLabel = new JLabel("Package Size : ");
    packageSizeLabel.setBounds(10, 110, 150, 15);
    centerPanel.add(packageSizeLabel);
    //add Textfield
    packageSizeText = new JTextField(20);
    packageSizeText.setBounds(150, 105, 150, 25);
    centerPanel.add(packageSizeText);

    //add Select Unit -------------------------------------------------------------------------
    selectUnitLabel = new JLabel("Select Unit : ");
    selectUnitLabel.setBounds(10, 140, 150, 15);
    centerPanel.add(selectUnitLabel);
    //add Gender Radio Buttons

    m3RButton = new JRadioButton("m3", false);
    kgRButton = new JRadioButton("kg", false);

    m3RButton.setBounds(150, 135, 100, 25);
    kgRButton.setBounds(250, 135, 100, 25);

    centerPanel.add(m3RButton);
    centerPanel.add(kgRButton);

    //Create Button Group -------------------------------------------------------------------------
    radioGroup = new ButtonGroup();
    radioGroup.add(m3RButton);
    radioGroup.add(kgRButton);

    //add Delivery City -------------------------------------------------------------------------
    deliveryCityLabel = new JLabel("Delivery City : ");
    deliveryCityLabel.setBounds(10, 170, 150, 15);
    centerPanel.add(deliveryCityLabel);
    //add Combo Box

    deliveryCityComb = new JComboBox<Object>(cityList);
    deliveryCityComb.setBounds(150, 165, 150, 25);
    centerPanel.add(deliveryCityComb);

    //add Button -------------------------------------------------------------------------
    sendButton = new JButton("Add to File");
    sendButton.setBounds(150, 200, 150, 25);
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

  //CLEAR   -------------------------------------------------------------------------
  public class NewLogisticRecordHender implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      //Text Field
      nameText.setText("");
      packageContText.setText("");
      packageSizeText.setText("");
      //Combo Boxes
      deliveryCityComb.setSelectedIndex(0);
      //RadioButton
      radioGroup.clearSelection();
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
        String outputfilename =
          System.getProperty("java.io.tmpdir") + "\\Logistics_20190108028.csv";
        try {
          FileWriter csvwriter = new FileWriter(outputfilename, true);
          csvwriter.close();
          System.out.println("CSV SAVED AND CLOSED");
          System.exit(0);
        } catch (Exception e1) {
          System.out.println("exception :" + e1.getMessage());
        }
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
    String outputfilename =
      System.getProperty("java.io.tmpdir") + "\\Logistics_20190108028.csv";

    public void actionPerformed(ActionEvent e) {
      if (
        nameText.getText().equals("") ||
        packageContText.getText().equals("") ||
        packageSizeText.getText().equals("") ||
        deliveryCityComb.getSelectedItem() == ""
      ) {
        if (
          !m3RButton.isSelected() || !kgRButton.isSelected()
        ) System.out.println("Each field must be filled.");
      } else {
        File myObj = new File(outputfilename);

        //Check whether file exists
        if (!myObj.exists()) System.out.println("File not exists"); else {
          String Unit = "";
          try {
            FileWriter csvwriter = new FileWriter(outputfilename, true);
            csvwriter.append(nameText.getText());
            csvwriter.append(";");
            csvwriter.append(packageContText.getText());
            csvwriter.append(";");
            csvwriter.append(packageSizeText.getText());
            csvwriter.append(";");

            if (m3RButton.isSelected()) Unit = "m3";
            if (kgRButton.isSelected()) Unit = "kg";

            csvwriter.append(Unit);

            csvwriter.append(";");
            csvwriter.append((CharSequence) deliveryCityComb.getSelectedItem());
            csvwriter.append(";");
            csvwriter.append("\n");
            csvwriter.close();
            System.out.println("CSV file created succesfully.");
            //Text Field
            nameText.setText("");
            packageContText.setText("");
            packageSizeText.setText("");
            //Combo Boxes
            deliveryCityComb.setSelectedIndex(0);
            //RadioButton
            radioGroup.clearSelection();
          } catch (Exception e1) {
            System.out.println("exception :" + e1.getMessage());
          }
        }
      }
    }
  }
}
/*     \    /\
		)  ( ')
		(  /  )
SCB   	 \(__)|
*/
