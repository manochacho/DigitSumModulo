Console.WriteLine("Enter 3 digit int:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"the sum of the digits in {num} is {GetSum(num)} "); 
static int GetSum(int num)
{
    int sum = 0;
    
    for (int i = num; i > 0; i /= 10)
    {
        sum += i % 10;
    }
    return sum;
}
