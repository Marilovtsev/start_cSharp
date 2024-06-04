// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

int age;
age = 25;

Console.WriteLine($"My age is {age}");

double height = 1.72;
double weight = 50;
Console.WriteLine($"My height is {height}, and my weight is {weight}");

/*Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine($"My name is {name}");*/

char key = 'a';
key = 'B';
Console.WriteLine(key);

//string emptyString = string.Empty;
string emptyString = "";

Console.WriteLine($"THIS IS EMPTY STRING ->{emptyString}!");

string str1 = "test";
string str2 = "123123";
string str3 = "!@#$%";
string str4 = "5";

Console.WriteLine(str1);
Console.WriteLine(str2);
Console.WriteLine(str3);
Console.WriteLine(str4);

string stringWithQuotes = "This is string with \"double quotes\"!";
string stringWithEnter = "THis is some \nText";
Console.WriteLine(stringWithEnter);
Console.WriteLine(stringWithQuotes.Length);

bool isAlive =  true;
bool canWork = false;