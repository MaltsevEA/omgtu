/*

	Учебное заведение:	Омский Государственный технический университет (ОмГТУ)
	Факультет:			ФИТиКС
	Группа:				ЗАС-123
	Студент:			Мальцев Евгений Алексеевич

	Задача АС-2 №3:

	Дан набор целых чисел. Вычислить, какое число нужно добавить к этому набору, чтобы среднее арифметическое стало равно заданному значению.

*/

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<locale.h>

void main() {

	setlocale(LC_ALL, "Russian");

	srand(time(NULL));

	printf_s("Определение размерности набора...\n");

	int set_count;

	set_count = rand() % 9 + 1;

	printf_s("Размерность определена: %d\n\n", set_count);

	printf_s("Формирование набора целых чисел...\n");
	printf_s("Набор сформирован: ");

	int *set_of_integers = new int(set_count);

	for (int i = 0; i < set_count; i++) {
		set_of_integers[i] = rand() % 100 + 1;
		printf_s("%d ", set_of_integers[i]);
	}

	printf_s("\n\nВычесление среднее арифмитического значения набора целых чисел...\n");

	float amount = 0;

	for (int i = 0; i < set_count; i++) {
		amount = amount + set_of_integers[i];
	}

	float average;

	average = amount / set_count;

	printf_s("Среднее арифмитическое вычислено: %.2f\n\n", average);

	printf_s("Вычисление заданное значение...\n");

	int set_value;

	set_value = rand() % 100 + 1;

	printf_s("Заданное значение вычеслено: %d\n\n", set_value);

	printf_s("Вычисление необходимого числа для добавления к набору...\n");

	float number;

	number = (set_value * (set_count + 1)) - amount;

	printf_s("Необходимое число вычеслено: %.f\n\n", number);

	_getch();
}