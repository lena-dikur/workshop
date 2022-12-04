// Считываем данные с консоли
string? num1Line = Console.ReadLine();
// Проверяем чтобы данные были не пустыми
if(num1Line!=null)
{
// Парсим введенное число
// int num1 = int.Parse(num1Line);
// Находим квадрат числа
// int outResult = num1 * num1;
// int outnum1 = (int)Math.Pow(num1, 2);  
// Выводим результат в консоль
//  Console.WriteLine(outnum1);
    Console.WriteLine(Math.Pow(int.Parse(num1Line),2));
}