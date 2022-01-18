package Ders_3;

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

public class GUIAllFrame3 extends JFrame {
  /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
private final JButton newMailButton;
  private final JButton button2;
  private final JButton button3;
  private final JButton button4;
  private final JButton inboxButton;
  private final JLabel label1;
  private final JTextField textfield1;
  private final JButton button21;
  private final JButton button31;
  private final JButton button41;
  private final JLabel footer;

  private final JLabel label2;
  private final JPasswordField pwfield1;
  private final JButton sendbutton;
  private final JCheckBox boldcheck;
  private final JCheckBox italiccheck;
  private final JRadioButton blackbutton;
  private final JRadioButton bluebutton;
  private final JRadioButton redbutton;
  private final JComboBox<?> citycombo;
  private final JTextField searchfield;
  private final String cityList[] = {
    "",
    "Ýstanbul",
    "Ankara",
    "Ýzmir",
    "Adana",
    "Kocaeli",
  };
  private final JLabel last_label;

  public GUIAllFrame3() {
    super("GUI All Frame");
    //Layer 1
    BorderLayout layout = new BorderLayout(1, 1);
    setLayout(layout);

    //Layer2
    //Create panels
    JPanel northPanel = new JPanel();
    northPanel.setBackground(Color.LIGHT_GRAY);
    JPanel southPanel = new JPanel();
    southPanel.setBackground(Color.LIGHT_GRAY);
    JPanel westPanel = new JPanel();
    westPanel.setBackground(Color.LIGHT_GRAY);
    JPanel centerPanel = new JPanel();

    //add panels to frame
    add(northPanel, BorderLayout.NORTH);
    add(southPanel, BorderLayout.SOUTH);
    add(westPanel, BorderLayout.WEST);
    add(centerPanel, BorderLayout.CENTER);

    //North Panel
    //set layout
    BorderLayout layout1 = new BorderLayout(1, 1);
    northPanel.setLayout(layout1);

    //ButtonPanel in NorthPanel
    //Layer 3
    JPanel buttonPanel = new JPanel();
    buttonPanel.setBackground(Color.LIGHT_GRAY);

    FlowLayout layout4 = new FlowLayout();
    buttonPanel.setLayout(layout4);
    layout4.setAlignment(FlowLayout.LEFT);

    //Layer 4
    button2 = new JButton("Reply");
    button3 = new JButton("Delete");
    button4 = new JButton("Forward");

    buttonPanel.add(button4);
    buttonPanel.add(button2);
    buttonPanel.add(button3);

    northPanel.add(buttonPanel, BorderLayout.CENTER);

    //SearchPanel in NorthPanel
    //Layer 3
    JPanel searchPanel = new JPanel();
    searchPanel.setBackground(Color.LIGHT_GRAY);

    FlowLayout layout5 = new FlowLayout();
    searchPanel.setLayout(layout5);
    layout5.setAlignment(FlowLayout.RIGHT);

    //Layer 4
    JLabel searchlabel = new JLabel("Search ");
    searchfield = new JTextField(10);

    searchPanel.add(searchlabel);
    searchPanel.add(searchfield);

    northPanel.add(searchPanel, BorderLayout.EAST);

    //West Panel
    //set layout
    //Layer 3
    GridLayout layout3 = new GridLayout(12, 1, 5, 5);
    westPanel.setLayout(layout3);

    newMailButton = new JButton("New Mail");
    inboxButton = new JButton("Inbox");
    button21 = new JButton("Sent");
    button31 = new JButton("Draft");
    button41 = new JButton("Trash");

    westPanel.add(newMailButton);
    westPanel.add(inboxButton);
    westPanel.add(button21);
    westPanel.add(button31);
    westPanel.add(button41);

    //South Panel
    //set layout
    //Layer 3
    FlowLayout layout2 = new FlowLayout();
    //layout2.setAlignment(FlowLayout.LEFT);
    southPanel.setLayout(layout2);

    footer = new JLabel("2020 ï¿½ PRU");
    footer.setFont(new Font("Serif", Font.ITALIC, 12));
    southPanel.add(footer);

    //Center Panel
    //set layout
    //Layer 3
    centerPanel.setLayout(null);

    label1 = new JLabel("Name and Surname: ");
    label1.setBounds(10, 20, 150, 15);
    centerPanel.add(label1);

    //add textfield
    textfield1 = new JTextField(20);
    textfield1.setBounds(150, 20, 150, 25);
    centerPanel.add(textfield1);

    //add label
    label2 = new JLabel("Password:");
    label2.setBounds(10, 50, 150, 25);
    centerPanel.add(label2);

    //add password
    pwfield1 = new JPasswordField(20);
    pwfield1.setBounds(150, 50, 150, 25);
    centerPanel.add(pwfield1);

    //add label
    JLabel label5 = new JLabel("Select City:");
    label5.setBounds(10, 80, 150, 25);
    centerPanel.add(label5);

    citycombo = new JComboBox<Object>(cityList);
    //citycombo.setPreferredSize(new Dimension(150, 25));
    citycombo.setBounds(150, 80, 150, 25);
    centerPanel.add(citycombo);

    //add label
    JLabel label3 = new JLabel("Select font style: ");
    label3.setBounds(10, 110, 150, 25);
    centerPanel.add(label3);

    //add bold and italic checkboxes
    boldcheck = new JCheckBox("Bold");
    italiccheck = new JCheckBox("Italic");
    boldcheck.setBounds(150, 110, 80, 25);
    italiccheck.setBounds(250, 110, 80, 25);
    centerPanel.add(boldcheck);
    centerPanel.add(italiccheck);

    //add label
    JLabel label4 = new JLabel("Select font color: ");
    label4.setBounds(10, 130, 150, 25);
    centerPanel.add(label4);

    //add radio buttons
    blackbutton = new JRadioButton("black", true);
    bluebutton = new JRadioButton("blue", false);
    redbutton = new JRadioButton("red", false);
    blackbutton.setBounds(150, 130, 100, 25);
    bluebutton.setBounds(250, 130, 100, 25);
    redbutton.setBounds(350, 130, 100, 25);
    centerPanel.add(blackbutton);
    centerPanel.add(bluebutton);
    centerPanel.add(redbutton);

    //add button
    sendbutton = new JButton("Submit");
    sendbutton.setBounds(150, 180, 150, 25);
    centerPanel.add(sendbutton);

    last_label = new JLabel("Text to change");
    last_label.setBounds(150, 250, 150, 15);
    centerPanel.add(last_label);

    //create button group
    ButtonGroup radioGroup = new ButtonGroup();
    radioGroup.add(blackbutton);
    radioGroup.add(bluebutton);
    radioGroup.add(redbutton);

    //Events

    FrameEventHandler handler1 = new FrameEventHandler();
    sendbutton.addActionListener(handler1);

    TextFrameEventHandler handler2 = new TextFrameEventHandler();
    textfield1.addActionListener(handler2);

    RCFrameEventHandler handler3 = new RCFrameEventHandler();
    boldcheck.addActionListener(handler3);
    italiccheck.addActionListener(handler3);
    blackbutton.addActionListener(handler3);
    bluebutton.addActionListener(handler3);
    redbutton.addActionListener(handler3);
    citycombo.addActionListener(handler3);

    NameKeyListener handler4 = new NameKeyListener();
    textfield1.addKeyListener(handler4);
  }

  private class FrameEventHandler implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent e) {
      JOptionPane.showMessageDialog(null, "Submit button clicked");
    }
  }

  private class TextFrameEventHandler implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent e) {
      JOptionPane.showMessageDialog(null, "Text entered");
    }
  }

  private class RCFrameEventHandler implements ActionListener {

    @Override
    public void actionPerformed(ActionEvent event) {
      Font font = null;
      if (event.getSource() == boldcheck || event.getSource() == italiccheck) {
        if (boldcheck.isSelected() && italiccheck.isSelected()) font =
          new Font(
            last_label.getFont().getFamily(),
            Font.BOLD + Font.ITALIC,
            last_label.getFont().getSize()
          ); else if (boldcheck.isSelected()) font =
          new Font(
            last_label.getFont().getFamily(),
            Font.BOLD,
            last_label.getFont().getSize()
          ); else if (italiccheck.isSelected()) font =
          new Font(
            last_label.getFont().getFamily(),
            Font.ITALIC,
            last_label.getFont().getSize()
          ); else font =
          new Font(
            last_label.getFont().getFamily(),
            Font.PLAIN,
            last_label.getFont().getSize()
          );
        last_label.setFont(font);
      } else if (
        event.getSource() == blackbutton ||
        event.getSource() == bluebutton ||
        event.getSource() == redbutton
      ) {
        if (blackbutton.isSelected()) last_label.setForeground(
          Color.black
        ); else if (bluebutton.isSelected()) last_label.setForeground(
          Color.blue
        ); else if (redbutton.isSelected()) last_label.setForeground(Color.red);
      } else if (event.getSource() == citycombo) {
        //set last_label text to selected city
        last_label.setText(cityList[citycombo.getSelectedIndex()]);
      } else JOptionPane.showMessageDialog(
        null,
        "Any other radio button or checkbox is clicked"
      );
    }
  }

  private class NameKeyListener implements KeyListener {
    String oldtext = "";

    @Override
    public void keyTyped(KeyEvent e) {
      // TODO Auto-generated method stub
      System.out.println("key typed: " + e.getKeyChar());
    }

    @Override
    public void keyPressed(KeyEvent e) {
      // TODO Auto-generated method stub
      //Store the current value of Name and Surname
      oldtext = textfield1.getText();
    }

    @Override
    public void keyReleased(KeyEvent e) {
      // TODO Auto-generated method stub
      if (
        e.getKeyChar() == '0' || e.getKeyChar() == '1' || e.getKeyChar() == '2'
      ) {
        System.out.println(
          "you cannot enter numeric values in Name and Surname field"
        );
        textfield1.setText(oldtext);
      }
    }
  }
}
