package ru.omgtu.zivt132.lab1;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * 
 * Вариант 12: Найти такую точку заданного на плоскости множества точек, сумма расстояний от которой до остальных минимальна.
 * 
 * @author Мальцев Евгений Алексеевич, ОмГТУ, ЗИВТ-132    
 * @version 1.0 15/09/2015
 */
public class variant12 {
	
	/**
	 * 
	 * @param filename String
	 * @return Scanner
	 * @throws FileNotFoundException The system can not find the path specified
	 */	
	public static Scanner getScanner (String filename) throws FileNotFoundException {
		return new Scanner(new File(filename));
	}
	
	/**
	 * 
	 * @param s Scanner
	 * @return Two-dimensional array of integers
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
	 * @param xy Two-dimensional array of integers
	 * @return Null
	 */	
	public static int[][] showArray(int[][] xy) {
        for(int i = 0; i < 10; i++) {
        	System.out.println("Point " + i + ": " + xy[i][0] + "," + xy[i][1]);           
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
        	showArray(xy);
		}        
        catch (InputMismatchException e) {
        	e.printStackTrace();
        }
	}
}
