package Ders_3;

import javax.swing.JFrame;

public class GUIAllTest {

  public static void main(String[] args) {
    GUIAllFrame3 Frame = new GUIAllFrame3(); //Layer 1 - Create Frame
    Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    Frame.setLocation(300, 100);
    Frame.setSize(600, 500);
    Frame.setVisible(true);
  }
}
