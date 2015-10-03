/*	

	Учебное заведение:	Омский Государственный технический университет (ОмГТУ)
	Факультет:			ФИТиКС
	Группа:				ЗАС-123
	Студент:			Мальцев Евгений Алексеевич

	Задача АС-РГР

	Дан файл координат точек на плоскости. Переписать в файл G все точки, попадающие в окружность радиуса R и с координатами центра (x, y). 
	Реализовать на двоичных файлах с помощью структур данных (struct).

*/

#include<stdio.h>
#include<conio.h>
#include<time.h>
#include<fstream>
#include<locale.h>

struct points
{
	int x, y;
};

struct circle
{
   int r, x, y;
};

void main()
{
	setlocale(LC_ALL, "Russian");

	printf_s("Создаем двоичный файл файл с координатами...\n");

	FILE *f;
	errno_t err;

	err = fopen_s(&f, "points.dat", "wb");

	if(err == 0) {
		points spoints[10000];

		int x = 1, y = 1;

		for(int i = 0; i < 10000; i++) {
			spoints[i].x = x;
			spoints[i].y = y;

			if (x == 100) {
				x = 1;
				y++;
			} else {
				x++;
			}
		}

		fwrite(&spoints, sizeof(points), 10000, f);

		printf_s("Файл создан успешно.\n\n");

		fclose(f);

		memset(&spoints, 0, sizeof(points)*10000);

		circle scircle;

		printf_s("Задаем параметры круга...\n\n");

		printf_s("Укажите радиус круга R (r < 50): ");
		scanf_s("%d", &scircle.r);
		printf_s("Укажите координаты центра круга X (x > %d or x < %d): ", scircle.r, 100 - scircle.r);
		scanf_s("%d", &scircle.x);
		printf_s("Укажите координаты центра круга Y (y > %d or y < %d): ", scircle.r, 100 - scircle.r);
		scanf_s("%d", &scircle.y);

		printf_s("\nЗадан круг с координатами (%d,%d) и радиусом (%d).\n\n", scircle.x, scircle.y, scircle.r);

		printf_s("Открываем двоичный файл файл с координатами...\n");

		FILE *f;

		err = fopen_s(&f, "points.dat", "rb");

		if(err == 0) {
			fread(&spoints, sizeof(points), 10000, f);

			printf_s("Файл открыт успешно.\n");

			fclose(f);

			x = 0;
			
			printf_s("\nВычисляем и записываем координаты точек попадающих в окружность...\n");

			FILE *f;

			err = fopen_s(&f, "points_result.dat", "wb");

			if(err == 0) {
				for(int i = 0; i < 10000; i++) {
					if (sqrt(pow((scircle.x - spoints[i].x), 2) + pow((scircle.y - spoints[i].y), 2)) <= scircle.r) {
						fwrite(&spoints[i].x, sizeof(int), 1, f);
						fwrite(&spoints[i].y, sizeof(int), 1, f);
						x++;
					} 
				}

				fclose(f);

				printf_s("В окружность с координатами (%d,%d) и радиусом (%d) попадает %d точек и они успешно записаны.", scircle.x, scircle.y, scircle.r, x);
			} else {
				printf_s("Создать файл не удалось. Программа завершает работу...\n");
			}
		} else {
			printf_s("Открыть файл не удалось. Программа завершает работу...\n");
		}
	} else {
		printf_s("Создать файл не удалось. Программа завершает работу...\n");
	}

	_getch();
}