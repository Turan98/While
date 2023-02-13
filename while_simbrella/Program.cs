

int odd_num = 0;
int even_num = 0;
int sum_odd_num = 0;
int sum_even_num = 0;

Console.WriteLine("Enter start num: ");
int start_num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter last num: ");
int limit_num = int.Parse(Console.ReadLine());

while (start_num < limit_num)
{
    if (start_num % 2 == 0)
    {
        sum_even_num += start_num;
        even_num ++;
    }
    else
    {
        sum_odd_num += start_num;
        odd_num ++;
    }
   start_num ++; 
}

Console.WriteLine("Odd num: " + odd_num);
Console.WriteLine("Even num: " + even_num);
Console.WriteLine("Sum Odd num: " + sum_odd_num);
Console.WriteLine("Sum even num: " + sum_even_num);
