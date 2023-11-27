//Задайте значение N. Напишите программу, которая выведет натуральные числав промежутке от N до 1. С помощью
// рекурсии. N = 5-> '5,4,2,1'



int n = ImputNumbers("Введите n: ");
int count = 2;
PrintNumber(n,count);
Console.Write(1);
   
    void PrintNumber(int n, int count)
   {
    if(count > n) return;
   PrintNumber(n, count + 1);
   Console.Write(count + ", ");
   }
    
    int ImputNumbers(string input)
    {
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
    }