package Ders_2;

import java.awt.Point;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionAdapter;
import java.util.ArrayList;
import javax.swing.JPanel;

public class PaintPanel extends JPanel 
{
   /**
	 * 
	 */
	private static final long serialVersionUID = -8928938254978186073L;
// list Point references
   private final ArrayList<Point> points = new ArrayList<>(); 

   // set up GUI and register mouse event handler
   public PaintPanel()
   {
      // handle frame mouse motion event
      addMouseMotionListener(
         new MouseMotionAdapter() // anonymous inner class
         {  
            // store drag coordinates and repaint
            @Override
            public void mouseDragged(MouseEvent event)
            {
            
               points.add(event.getPoint()); 
               //System.out.println(event.getPoint());
               repaint(); // repaint JFrame
            } 
         } 
      ); 
   }

   // draw ovals in a 4-by-4 bounding box at specified locations on window
   @Override
   public void paintComponent(Graphics g)
   {
      super.paintComponent(g); // clears drawing area

      // draw all 
      for (Point point : points)
         g.fillOval(point.x, point.y, 4, 4);
   } 
   public void clearDrawing()
   {
	  points.removeAll(points);
      repaint();
   } 
} // end class PaintPanel