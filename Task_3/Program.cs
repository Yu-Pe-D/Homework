Console.WriteLine("Задайте номер четверти 1...4:");
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("x > 0; y > 0."); 
}
else if (a == 2)
{
  Console.WriteLine("x < 0; y > 0.");  
}
else if (a == 3)
{
Console.WriteLine("x < 0; y < 0.");    
}
else if (a == 4)
{
  Console.WriteLine("x > 0; y < 0.");    
}