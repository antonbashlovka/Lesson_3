/*
    Задача 2
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double findDist(int[] a, int[] b){
    return Math.Round(Math.Sqrt(Math.Pow((a[0]-b[0]), 2) +  Math.Pow((a[1]-b[1]), 2) + Math.Pow((a[2]-b[2]), 2)), 2);
}

int[] a = new int[3] {7,-5,0};
int[] b = new int[3] {1,-1,9};

Console.WriteLine(findDist(a,b));

 