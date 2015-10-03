package ru.omgtu.zivt132.lab3;

import java.util.Vector;

/**
 * 
 * Лабораторная работа №3 - Структуры данных, коллекции Java. 
 * Вариант №12: Программа получает N параметров	вызова (аргументы командной строки). Эти параметры – элементы вектора.	Строится массив типа double, а на базе этого массива – объект класса DoubleVector. Далее программа выводит в консоль значения элементов вектора в виде: Вектор: 2.3 5.0 7.3.
 * 
 * @author Мальцев Евгений Алексеевич
 * @version 1.0 15/09/2015
 */

class DoubleVector {
	
	public void showVector(Vector<Double> iVector) {
		System.out.println("Вектор: " + iVector.toString().replaceAll("[\\[\\]\\,]", ""));
	}
}

public class variant12 {

	/**
	 * @param args String
	 */
	public static void main(String[] args) {
	
		Vector<Double> myDoubleArgs = new Vector<Double>();
		
		try {
			for (int i = 0; i < args.length; i++) {
				myDoubleArgs.add(i, Double.parseDouble(args[i]));
			}
			
			DoubleVector myDoubleVector = new DoubleVector();
			
			myDoubleVector.showVector(myDoubleArgs);			
		} catch (NumberFormatException e) {
        	e.printStackTrace();
        }		
	}		
}
