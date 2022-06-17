// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
using System;
using static System.Console;

Clear();
int number;
Write("Введите число: ");
if (!int.TryParse(ReadLine(), out number)) {
	WriteLine("Ошибка ввода числа");
	return;
}
Write($"Сумма цифр числа = {SumOfNumbers(number)}");


int SumOfNumbers (int N) {
	int sum = 0;
	if (N < 0)	N = -N;
	while ( N != 0) {
		sum += N % 10;
		N /= 10;
	}
	return sum;
}
