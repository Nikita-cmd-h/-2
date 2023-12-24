/* Задача 1: Напишите программу, которая принимает
на вход число и проверяет, кратно ли оно
одновременно 7 и 23
*/
/* Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%7==0 && number%23==0){
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else{
    Console.WriteLine($"Число {number} не кратно 7 и 23");
} */
/*Задача 2: Напишите программу, которая принимает
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.
*/
bool condition = false;
int x = 0;
int y = 0;

while(condition==false){
    Console.Write("Ведите X: ");
    int firstnumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите Y: ");
    int secondnumber = Convert.ToInt32(Console.ReadLine());
    if(firstnumber==0 | secondnumber==0){
        Console.WriteLine("Нельзя вводить x или y равные нулю!");
    }
    else{
        x = firstnumber;
        y = secondnumber;
        condition = true;
    }
}

int quarter = 0;

if(x<0){
    if(y>0){
        quarter = 2;
    }
    else{
        quarter = 3;
    }
}
else{
    if(y>0){
        quarter = 1;
    }
    else{
        quarter = 4;
    }
}

Console.Write($"Координата ({x}; {y}) находится в {quarter} четверти");
/*Задача 3: Напишите программу, которая принимает
на вход целое число из отрезка [10, 99] и показывает
наибольшую цифру числа.
*/

/*Задача 4: Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.
 */