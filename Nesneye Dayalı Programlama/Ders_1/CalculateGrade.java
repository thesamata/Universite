package Ders_1;

import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

public class CalculateGrade {

  public static void main(String[] args) {
    int midterm1;
    int midterm2;
    int final1;

    String smidterm1;
    String smidterm2;
    String sfinal1;

    do {
      smidterm1 = JOptionPane.showInputDialog("Please enter Midterm1 grade.");
      midterm1 = Integer.parseInt(smidterm1);
    } while (midterm1 < 0 || midterm1 > 100);

    do {
      smidterm2 = JOptionPane.showInputDialog("Please enter Midterm2 grade.");
      midterm2 = Integer.parseInt(smidterm2);
    } while (midterm2 < 0 || midterm2 > 100);

    do {
      sfinal1 = JOptionPane.showInputDialog("Please enter Final grade.");
      final1 = Integer.parseInt(sfinal1);
    } while (final1 < 0 || final1 > 100);

    int result = (midterm1 * 20 + midterm2 * 20 + final1 * 60) / 100;
    String fmessage = "";
    String iconpath;

    if (result >= 45) {
      fmessage = "Your grade is " + result + " YOU PASSED !!!!!";
      iconpath =
        "C:\\Users\\Aysegul\\Documents\\Universite\\PiriReis\\Bilgisayar_Programc�l���\\BIP2007 Nesneye Dayal� Programlama II\\examples\\Week3\\success.png";
    } else {
      fmessage = "Your grade is " + result + " YOU FAILED :(";
      iconpath =
        "C:\\Users\\Aysegul\\Documents\\Universite\\PiriReis\\Bilgisayar_Programc�l���\\BIP2007 Nesneye Dayal� Programlama II\\examples\\Week3\\fail.png";
    }

    ImageIcon icon1 = new ImageIcon(iconpath);

    JOptionPane.showMessageDialog(
      null,
      fmessage,
      "Result",
      JOptionPane.WARNING_MESSAGE,
      null
    );
    JOptionPane.showMessageDialog(
      null,
      fmessage,
      "Result",
      JOptionPane.WARNING_MESSAGE,
      icon1
    );
  }
}
