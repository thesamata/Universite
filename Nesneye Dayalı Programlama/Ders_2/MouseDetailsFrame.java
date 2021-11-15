package Ders_2;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class MouseDetailsFrame  extends JFrame 
{
	   /**
	 * 
	 */
	private static final long serialVersionUID = 7603230092257223349L;
	@SuppressWarnings("unused")
	private String details; // String displayed in the statusBar
	   private final JLabel statusBar; // JLabel at bottom of window
	   private final JPanel mousePanel; // panel in which mouse events occur

	   // constructor sets title bar String and register mouse listener
	   public MouseDetailsFrame()
	   {
	      super("Mouse Clicks and Buttons");

	      mousePanel = new JPanel(); 
	      mousePanel.setBackground(Color.WHITE); 
	      add(mousePanel, BorderLayout.CENTER); // add panel to JFrame

	      statusBar = new JLabel("Mouse outside JPanel"); 
	      add(statusBar, BorderLayout.SOUTH); // add label to JFrame
	      
	      addMouseListener(new MouseClickHandler()); // add handler
	   }

	   // inner class to handle mouse events
	   private class MouseClickHandler extends MouseAdapter 
	   {
	      // handle mouse-click event and determine which button was pressed
		      @Override
		      public void mouseClicked(MouseEvent event)
		      {
		         statusBar.setText(String.format("Clicked at [%d, %d]", 
		            event.getX(), event.getY()));
		      } 

		      // handle event when mouse pressed
		      @Override
		      public void mousePressed(MouseEvent event)
		      {
		         statusBar.setText(String.format("Pressed at [%d, %d]", 
		            event.getX(), event.getY()));
		      }

		      // handle event when mouse released 
		      @Override
		      public void mouseReleased(MouseEvent event)
		      {
		         statusBar.setText(String.format("Released at [%d, %d]", 
		            event.getX(), event.getY()));
		      }

		      // handle event when mouse enters area
		      @Override
		      public void mouseEntered(MouseEvent event)
		      {
		         statusBar.setText(String.format("Mouse entered at [%d, %d]", 
		            event.getX(), event.getY()));
		         mousePanel.setBackground(Color.GREEN);
		      }

		      // handle event when mouse exits area
		      @Override
		      public void mouseExited(MouseEvent event)
		      {
		         statusBar.setText("Mouse outside JPanel");
		         mousePanel.setBackground(Color.WHITE);
		      }

		      // MouseMotionListener event handlers
		      // handle event when user drags mouse with button pressed
		      @Override
		      public void mouseDragged(MouseEvent event)
		      {
		         statusBar.setText(String.format("Dragged at [%d, %d]", 
		            event.getX(), event.getY()));
		      } 

		      // handle event when user moves mouse
		      @Override
		      public void mouseMoved(MouseEvent event)
		      {
		         statusBar.setText(String.format("Moved at [%d, %d]", 
		            event.getX(), event.getY()));
		      } 
	   } 
	} // end class MouseDetailsFrame
