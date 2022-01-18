package Ders_2;

import javax.swing.JFrame;

public class MouseTrackerTest {
	public static void main(String[] args)
	   { 
		MouseTrackerFrame Frame = new MouseTrackerFrame();  
	      Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	      Frame.setLocation(400, 200);
	      Frame.setSize(500, 500); 
	      Frame.setVisible(true); 
	   } 
}
