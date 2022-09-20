int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int secondDigit = number % 100 / 10;

Console.WriteLine(secondDigit);
