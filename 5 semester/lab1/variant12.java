package ru.omgtu.zivt132.lab1;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * 
 * Лабораторная работа №1 - Разработка консольных java-приложений.
 * Вариант №12: Найти такую точку заданного на плоскости множества точек, сумма расстояний от которой до остальных минимальна.
 * 
 * @author Мальцев Евгений Алексеевич
 * @version 1.0 29.09.2015
 */
public class variant12 {
	
	/**
	 * 
	 * Создание объекта класса Scanner
	 * @param filename String
	 * @return Scanner
	 * @throws FileNotFoundException The system can not find the path specified
	 */	
	public static Scanner getScanner (String filename) throws FileNotFoundException {
		return new Scanner(new File(filename));
	}
	
	/**
	 * 
	 * Заполнение массива данными из объекта класса Scanner
	 * @param s Scanner
	 * @return xy Two-dimensional array of integer
	 */	
	public static int[][] getArray (Scanner s) {		
        int[][] xy = new int[10][10];
        
        for(int i = 0; s.hasNext(); i++) {
        	xy[i][0] = s.nextInt();         	
            if (s.hasNext()) { 
            	xy[i][1] = s.nextInt();
            }
        }
        
        return xy; 		
	}

	/**
	 * 
	 * Вывод на консоль массива Integer
	 * @param iarray Two-dimensional array of Integer
	 * @return Null
	 */
	public static int[][] showIntArray(int[][] iarray) {
        for(int i = 0; i < 10; i++) {
        	System.out.println("Point " + i + ": " + iarray[i][0] + "," + iarray[i][1]);           
        }		
        
		return null;		
	}
	
	/**
	 * 
	 * Вывод на консоль массива Double
	 * @param marray Two-dimensional array of Double
	 * @return Null
	 */
	public static int[][] showDoubleArray(double[][] marray) {
        for(int i = 0; i < 10; i++) {
        	System.out.println("Point " + (int)marray[i][1] + ": " + marray[i][0]);           
        }		
        
		return null;		
	}	

	/**
	 * 
	 * @param args String
	 * @throws FileNotFoundException The system can not find the path specified
	 */	
	public static void main(String[] args) throws FileNotFoundException {
        
        try {
        	Scanner s = getScanner("res/points.txt");       	
        	int[][] xy = getArray(s);
        	
        	System.out.println("Loading points from file:\n");
        	
        	showIntArray(xy);
      	
        	double[][] ranges = new double[10][10];        	
       	
        	for(int i = 0; i < 10; i++) {
        		ranges[i][1] = i;
        		
        		for(int j = 0; j < 10; j++) {
        			ranges[i][0] = ranges[i][0] + Math.sqrt(Math.pow((xy[i][0] - xy[j][0]),2) + Math.pow((xy[i][1] - xy[j][1]), 2));
        		}
        	}
        	
        	System.out.println("\nCalculation of the sum of the distance from the other points:\n");
        	
        	showDoubleArray(ranges);       	
            
            double min = ranges[0][0];
            double point = 0;
            
            for(int i = 0; i < 10; i++) {
            	if(ranges[i][0] < min) {
            		min = ranges[i][0];
            		point = ranges[i][1]; 
            	}
            }

        	System.out.println("\nThese points, the sum of the distances from which to others is minimal:\n");
        	System.out.println("Point " + (int)point + ": " + xy[(int)point][0] + "," + xy[(int)point][1] + ", " + min);                        
		}        
        catch (InputMismatchException e) {
        	e.printStackTrace();
        }
	}
}
