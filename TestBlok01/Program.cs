// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

// Вариант 1

string text = 
            "Hello, a2, world, :-)" +
			"1234, 156, -2, Ok, computer science," +
			"Russia, Denmark, Kazan";

Console.Write("["+ text +"] ->"); 

string phrase = text;
string[] words = phrase.Split(' ', ',');

foreach (var word in words)
if (word.Length <= 3) Console.Write(word +' ');


// Вариант 2 

string txt = "Hello, 2, world, :-)"
			+ "1234, 1567, -2, computer science"
			+ "Russia, Denmark, Kazan";

string ChoiceWords(string txt)
{
	string result = String.Empty;
	string phrase = txt;
	string[] words = phrase.Split(' ', ',');

	foreach (var word in words)
	
	if (word.Length <= 3) result += word;	
	return result;
}
string res = ChoiceWords(txt);
Console.Write("["+ txt +"] ->"+' '+"["+ res +"]");