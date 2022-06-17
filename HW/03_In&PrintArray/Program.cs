﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// Не до конца понял условие задачи в плане заполнения массива. Автоматическое
// заполнение элементов массива случайными значениями мы подробно
// рассматривали на семинаре, поэтому решил сделать ручное заполнение
// элементов массива из консоли
using System;
using static System.Console;

Clear();
int[] array = new int[8];
WriteLine("Введите 8 элементов массива array");
if (ReadArray(array) == -1)		return;		// Если метод возвращает код ошибки, выходим из программы
WriteLine($"[{String.Join(", ", array)}]");

int ReadArray (int[] _array) {
	for (int i = 0; i < _array.Length; i ++) {
		Write($"array[{i}] = ");
		if (!int.TryParse(ReadLine(), out _array[i])) {
			WriteLine("Ошибка ввода числа");
			return -1;	// В случае некорректного ввода возвращаем код ошибки
		}
	}
	return 0;
}
