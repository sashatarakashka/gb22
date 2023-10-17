Console.WriteLine("Введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if ((x<100)||(x>999))
{
    Console.WriteLine("Число не трехзначное");
}
else
{
  int a = x/10;
int b = a%10;
Console.WriteLine(b);  
}

