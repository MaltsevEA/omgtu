package ru.omgtu.zivt132.lab2;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * 
 * Лабораторная работа №2 - Обработка строк, использование регулярных выражений в java-приложениях. 
 * Вариант №12: Проверить существуют ли в тексте цифры, за которыми не стоит "+" (пример правильных выражений: (3 + 5) – 9 * 4, пример неправильных выражений: 2 * 9 – 6 * 5)
 * 
 * @author Мальцев Евгений Алексеевич
 * @version 1.0 30.09.2015
 */
public class variant12 {

	private static Scanner console;


	/**
	 * 
	 * Проверка строки на соответствие
	 * @param inputString String
	 * @return Boolean
	 */
	public static boolean checkString(String inputString){	
        Pattern pattern = Pattern.compile("\\d.?\\+");  
        Matcher matcher = pattern.matcher(inputString);  
        return matcher.find();  
	} 	
	
	
	/**
	 * @param args String
	 */	
	public static void main(String[] args) {

		System.out.println("Enter text:\n");
		
		console = new Scanner(System.in);
		
		String enterString = console.nextLine();
			
		if (checkString(enterString)) {
			System.out.println("\nThe entered text is checked...");
		} else {
			System.out.println("\nThe text entered does not pass the test...");			
		}
	}
}
