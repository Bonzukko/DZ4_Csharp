Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
while(numberB < 1)
{
    Console.Write("Введите число B: ");
   numberB = Convert.ToInt32(Console.ReadLine());
 }
int result = Pow(numberA, numberB);
Console.Clear();
Console.Write( numberA + ", " + numberB + " -> " + result );

int Pow(int A, int B)
{
    int result = A;
for(int index = 1; index < B; index++)
{
     result*=A;
}
return result;
}