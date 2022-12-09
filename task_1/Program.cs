/* Задача 1
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да 
*/

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int intNumber = 0;

// проверка на число, количество знаков и тот случай когда знаков пять, но по факту это четырехзначное с минусом
while (int.TryParse(number, out intNumber) == false || number.Length != 5 || (number.Length == 5 && intNumber < 0)){
    Console.WriteLine("Ошибка, введите пятизначное число");
    number = Console.ReadLine();   
}

// проверяем - если последняя цифра 0, то это уже не палиндром
if(intNumber % 10 == 0){
    Console.WriteLine("Число не является палиндромом");
}else{
    int reverseNumber = 0;

    while (intNumber > 0) {
        // набор перевернутого числа
        reverseNumber =  reverseNumber*10 + intNumber % 10;
        intNumber = intNumber / 10;
    }

    // проверяем - совпадает ли изначально введенная строка и полученное число, переведенное в строку 
    if (number != Convert.ToString(reverseNumber)){
        Console.WriteLine("Число не является палиндромом");
    }else{
        Console.WriteLine("Поздравляю, вы нашли палиндром");
    }
}