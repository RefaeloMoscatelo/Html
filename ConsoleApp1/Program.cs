using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class A
    {
        void Foo()
        {
            throw new Exception("error");

        }

        protected abstract void Foo1();

    }

    public  class B:A
    {
        protected override void Foo1()
        {
            throw new NotImplementedException();
        }

        void Foo()
        {
            throw new Exception("error");

        }

    }



class Program
{
    //parent b =  new son();
    //b.print();





    static void Main(string[] args)
    {

            int sum = 7;
            int[] arr = { 1,2, 3, 4, 5,13,19 };

            int num1 = 0;
            int num2 = 0;

            int index = 0;
            for (int i = arr.Length-1; i > index;)
            {
                if (arr[i]+arr[index]<sum)
                {
                    index++;
                }
                else if (arr[i] + arr[index] > sum)
                {
                    i--;
                }
                else
                {
                    num1 = arr[i];
                    num2 = arr[index];
                    break;
                }
            }

            Console.WriteLine(num1+" "+num2);


      
        //bool b = func(arr, sum);

    }
    static bool func(int[] arr, int sum)
    {
        bool b = false;
        int num1 = 0;
        int num2 = 0;
        int temp = 0;

        //for (int i = arr.Length; i > 0; i--)
        //{
        //    if (arr[i] > sum)
        //    {

        //    }
        //}


        for (int i = 0; i < arr.Length; i++)
        {
            int g = arr.Length;
            if (arr[i] >= sum)
            {
                temp = arr[i];
            }

            num1 = arr[i];
            num2 = arr[i + 1];
            if (num1 + num2 == sum)
            {
                b = true;
                break;
            }
        }
        return b;
    }


}
}
