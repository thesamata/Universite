package Ders_2;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class PaintFrame extends JFrame {
  /**
   *
   */
  private static final long serialVersionUID = 8945509238190667728L;
  private final JButton clearbutton;
  private final PaintPanel panel;

  public PaintFrame() {
    super("Paint");
    panel = new PaintPanel();
    panel.setBackground(Color.WHITE);
    add(panel, BorderLayout.CENTER); // add panel to JFrame

    clearbutton = new JButton("Clear");
    clearbutton.addActionListener(
      new ActionListener() {

        @Override
        public void actionPerformed(ActionEvent event) {
          panel.clearDrawing();
        }
      }
    );
    add(clearbutton, BorderLayout.NORTH);
    add(new JLabel("Drag the mouse to draw"), BorderLayout.SOUTH);
  }
}
