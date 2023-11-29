
// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

string text = 
            "Hello, a2, world, :-)" +
			"1234, 156, -2, Ok, computer science," +
			"Russia, Denmark, Kazan";

Console.Write("["+ text +"] ->"); 

string phrase = text;
string[] words = phrase.Split(' ', ',');

foreach (var word in words)
if (word.Length <= 3) Console.Write(word +' ');