/*
    Задача 3
    Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
    3 -> [1, 8, 27].
    5 -> [1, 8, 27, 64, 125]
    Указание: Вывод массива вынести в отдельную функцию.
*/

double[] fillArray(int num){
    double[] cubes = new double[num];
    for (int i = 1; i <= num ; i++){
        cubes[i-1] = Math.Pow(i, 3);
    }
    return cubes;
}

void printArray(double[] arr){
    string res = "[";
    foreach (double value in arr ){
        res = res + Convert.ToString(value) + ",";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int intNumber = 0;
double[] cubeTable = {}; 

// проверка на число
while (int.TryParse(number, out intNumber) == false ){
    Console.WriteLine("Ошибка, вы ввели текст, а нужно число");
    number = Console.ReadLine();   
}

cubeTable = fillArray(intNumber);
printArray(cubeTable);

