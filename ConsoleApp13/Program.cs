using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace ConsoleApp13


{


    class point
    {

        public int x; public int y;

    }

    internal class Program
    {
        static void Main(string[] args)
        {



            //point p1 = new point();
            //point p2 = new point();
            //point p3 = new point();

            //Console.WriteLine("input point1");

            //bool flag = int.TryParse(Console.ReadLine(), out  p1.x);

            //bool flag2 = int.TryParse(Console.ReadLine(), out p1.y);
            //Console.WriteLine("input point2 in center");
            //bool flag3 = int.TryParse(Console.ReadLine(), out p2.x);

            //bool flag4 = int.TryParse(Console.ReadLine(), out p2.y);
            //Console.WriteLine("input point3");
            //bool flag5 = int.TryParse(Console.ReadLine(), out p3.x);

            //bool flag6 = int.TryParse(Console.ReadLine(), out p3.y);


            //if ((double)(p1.y - p2.y) / (p1.x - p2.x) == (double)(p2.y - p3.y) / (p2.x - p3.x))
            //{

            //    Console.WriteLine("three points on one line ");




            //}else
            //{

            //    Console.WriteLine("no og one line ");
            //}

            //Console.WriteLine("write time tgat in it compelte the task");

            //double.TryParse(Console.ReadLine(), out double time);

            //if(time>=2 && time <= 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");

            //}
            //else if (time >= 3 && time <= 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed.");
            //}

            //else if (time >= 4 && time <= 5)
            //{
            //    Console.WriteLine("they are provided with training to enhance their speed. .");

            //}
            //else if (time > 5)
            //{
            //    Console.WriteLine("they are required to leave the company.");
            //}






            //int.TryParse(Console.ReadLine(), out int n);

            //int[,] identityMatrix = new int[n, n];


            //for (int i = 0; i < n; i++)
            //{

            //for (int j = 0; j < n; j++)
            //    {

            //        if (i==j)
            //        {

            //            identityMatrix[i, j] = 1;
            //        }
            //        else
            //        {
            //            identityMatrix[i, j] = 0;
            //        }

            //        Console.Write(identityMatrix[i, j] + " ");
            //    }

            //    Console.WriteLine();

            //}

            //int result = 0;

            //int[] number = new int[3];



            //for (int i = 0; i < number.Length; i++)
            //{

            //    int.TryParse(Console.ReadLine(), out number[i]);

            //    result += number[i];





            //}

            //Console.WriteLine(result);




            //int[] ar01 = { 8, 9, 5 };
            //int[] ar02 = { 4, 1, 3 };
            //int[] ar03= new int[6];


            //Array.Copy(ar01, 0, ar03, 0, ar01.Length);


            //Array.Copy(ar02, 0, ar03, ar01.Length, ar02.Length);


            //Array.Sort(ar03);
            //foreach (int item in ar03)
            //{
            //    Console.WriteLine(item);
            //}



            int[] ar09 = { 1, 2, 2, 4, 5, 5, 5, 9 };
            int count = 1;
            int i;
            int counts = 0;
            int[] countt = new int[counts];
            int n=0;

            for ( i = 0; i < ar09.Length; i++)
            {
                for (int j = i + 1; j < ar09.Length; j++)
                {
                    if (ar09[j] != -1 && ar09[i] == ar09[j])

                    {
                        counts = count++;
                        Console.WriteLine($" item {ar09[i]} repeatead {counts}.");
                        ar09[j] = -1;
                        
                        for ( n = 0; n < counts; n++)
                        {
                            countt[n] = counts;

                            Console.WriteLine(countt[n]);
                        }
                    }
                    else
                    {
                        counts = 1;
                    } 
                }

              
            }
       

            //}
            //int min = 1;
            //int max = ar09[0];

            //for (int i = 0; i < ar09.Length; i++)
            //{


            //    if (ar09[i] < min)
            //    {

            //         min = ar09[i];

            //    }

            //    if (ar09[i] > max)
            //    {

            //        max = ar09[i];

            //    }

            //}

            //Console.WriteLine(max);
            //Console.WriteLine(min);




            // second largest

            //Array.Sort(ar09);  
            //Array.Reverse(ar09);

            //Console.WriteLine(ar09[1]);









        }
}
}
