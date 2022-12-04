//Считываем данные с консоли 
string? imputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(imputLine!=null)
{
// Парсим введенное число
    int imputNumber = int.Parse(imputLine);
    string outDayofWeek = string.Empty;
    switch(imputNumber)
    {
        case 1: outDayofWeek = "понедельник"; break;
        case 2: outDayofWeek = "вторник"; break;
        case 3: outDayofWeek = "среда"; break;
        case 4: outDayofWeek = "четверг"; break;
        case 5: outDayofWeek = "пятница"; break;
        case 6: outDayofWeek = "суббота"; break;
        case 7: outDayofWeek = "воскресение"; break;
        default: outDayofWeek = "Это не день недели!"; break;
    }
// Выводим данные в консоль
    Console.WriteLine(outDayofWeek);
} 

