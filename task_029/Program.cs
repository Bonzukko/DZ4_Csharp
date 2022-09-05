void array(int size)
{
int [] array = new int[size];
for(int index = 0; index < size; index++)
{
    array[index]= new Random().Next(0, 100);
    Console.Write(array[index] + ", ");
}
}
Console.Clear();
array(8);
