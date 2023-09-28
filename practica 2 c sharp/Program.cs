using System;
class Program
{
    const int NUM = 8;
    static void Main() {
        int[] nums = new int[NUM];
        int total = 0;
        for (int i = 0; i < NUM; i++)
        {
            Console.Write("por favor,introduzca el numero:");
            nums[i] = int.Parse(Console.ReadLine());
            total += nums[i];
        }
        Console.WriteLine("El total de numeros es:" + total);
        Console.ReadKey();
       
    }

}