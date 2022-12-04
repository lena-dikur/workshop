//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(imputNumLine!=null)
{
    int imputNumber = int.Parse(imputNumLine);
    int imputNumberC = imputNumber % 10;
    Console.WriteLine(imputNumberC);
}