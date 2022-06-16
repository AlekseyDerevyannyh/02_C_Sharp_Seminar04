// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B.
using System;
using static System.Console;

Clear();
int A, B;
Write("Введите число A: ");
if (!int.TryParse(ReadLine(), out A)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
Write("Введите число B: ");
if (!int.TryParse(ReadLine(), out B)) {
	WriteLine("Ошибка ввода числа!");
	return;
}
if (B < 1) {
	WriteLine("ОШИБКА: число В не натуральное!");
	return;
}

Write($"{A}^{B} = {Power(A, B)}");

int Power (int a, int b) {
	int result = 1;
	for (int i = 0; i < b; i ++) {
		result *= a;
	}
	return result;
}
