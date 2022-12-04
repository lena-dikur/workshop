//Считываем данные с консоли 
string? imputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(imputLine!=null)
{
    // Парсим введенное число
    int imputNumber = int.Parse(imputLine);
    string outDayofWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNumber));
    // Выводим данные в консоль
    Console.WriteLine(outDayofWeek);
}

