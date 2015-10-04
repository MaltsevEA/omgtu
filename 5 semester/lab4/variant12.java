package ru.omgtu.zivt132.lab4;

import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import javax.swing.*;

/**
 * 
 * Лабораторная работа №4 - Swing и AWT, графический интерфейс пользователя. 
 * Вариант №12: Промоделировать вращение спутника вокруг планеты по эллиптической орбите. Когда скрывается за планетой – спутник не виден.
 * 
 * @author Мальцев Евгений Алексеевич
 * @version 1.0 04.10.2015
 */
public class variant12 {

	public static void main(String[] args) {

		JFrame jFrame = new JFrame("Вращение спутника вокруг планенты по элиптической орбите");
		
		jFrame.setPreferredSize(new Dimension(600, 600));
		
		final JPanel pan = new JPanel();
		
		jFrame.add(pan);
		jFrame.setVisible(true);
		jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jFrame.pack();
			
		Timer tm = new Timer(50, new ActionListener() {
			
			// x и y - координаты спутника, t - текущее положение спутника во времени
			int t = 0, x, y;
			
			// a и b - радиусы эллипса
			double a = 200, b = 130, alpha = Math.PI / 180;
			
			@Override			
		
			public void actionPerformed(ActionEvent arg0) {
			
				t++;
				
				// расчет координат спутника с помощью параметрического уравнения элипса
				x = (int)Math.round(200 + a * Math.sin(t * alpha));
				y = (int)Math.round(200 + b * Math.cos(t * alpha));

				if (t >= 360) t = 0;                 	
				
				Graphics2D graphics = (Graphics2D)pan.getRootPane().getGraphics();
				pan.update(graphics);
				GeneralPath path = new GeneralPath();
				
				graphics.setColor(Color.blue);
				graphics.fillRoundRect(x, y, 50, 50, 50, 50);
				
				graphics.setColor(Color.green);
				graphics.fillRoundRect(200, 200, 200, 200, 200, 200);
				graphics.draw(path);
			}
		});
		
		tm.start();				
	}
}
