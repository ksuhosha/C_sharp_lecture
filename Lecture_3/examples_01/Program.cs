// вид 1 ничего не возвращают и не принимают аргументы
void Method1()
{
    System.Console.WriteLine("Автор....LaPa");
}
//вызов метода
//Method1();
// вид 2 ничего не возвращают и но принимают аргументы
void Method2(string msg, int count)
{
    int i = 0;

    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }

}
/* Method2(count: 4, msg: "text msg");
Method2("text msg", 4); */

// вид 3 возвращают и не принимает аргументы

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//System.Console.WriteLine($"Сейчас {year} год");
// вид 4 возвращают и принимают аргументы

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty; // пустая строка

    while (i < count)
    {

        result = result + c;
        i++;
    }
    return result;
}
string res= Method4(10, "Текст " );
System.Console.WriteLine(res);