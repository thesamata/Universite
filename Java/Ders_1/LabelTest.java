package Ders_1;

import java.awt.FlowLayout;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

public class LabelTest {

	public static void main(String[] args) {
	
		//Create frame object
		JFrame labelFrame = new JFrame();
		
		labelFrame.setLayout(new FlowLayout());
		
		//add some components to frame
		//JLabel constructor with a string argument
		JLabel label1 = new JLabel("Label with text");
		label1.setToolTipText("This is label1");
		labelFrame.add(label1);
		
		//JLabel constructor with no text and then set the text
		JLabel label2 = new JLabel();
		label2.setText("Label set later");
		label2.setToolTipText("This is label2");
		labelFrame.add(label2);
		
		//JLabel with text and icon
		ImageIcon icon1 = new ImageIcon("C:\\Users\\Aysegul\\Documents\\Universite\\PiriReis\\Bilgisayar_Programcýlýðý\\BIP2007 Nesneye Dayalý Programlama II\\examples\\Week3\\success.png");
		JLabel label3 = new JLabel("Label with text and icon", icon1, SwingConstants.RIGHT);
		label3.setToolTipText("This is label3");
		labelFrame.add(label3);
		
		//when the frame is ready, show it on the screen
		
		labelFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		labelFrame.setSize(400, 700);
		labelFrame.setLocation(200, 200);
		labelFrame.setResizable(false);
		labelFrame.setTitle("Label Test Demo");
		labelFrame.setVisible(true);
		
		
		

	}

}
