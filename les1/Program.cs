Console.WriteLine("input number 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
    if (num1 > max ) max = num1;
    if ( num2 > max) max = num2;

Console.WriteLine(max);