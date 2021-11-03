using System;

namespace C_Task_1._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*string a = "AZERBAYCAN";
            Num(a);*/
            #endregion

            #region Task-2
            /*       Random random = new Random();
                   Random random1 = new Random();






                   DD();*/

            #endregion

            #region Task-3
            /*int len = Convert.ToInt32(Console.ReadLine());

            Number(len);
            */
                #endregion
        }
        #region Task-1(method)
        /* public static void Num(string a)
         {
             char[] Arry = a.ToCharArray();

             for (int i = 0; i < a.Length; i++)
             {
                 Console.Write(Arry[i] + "*");
             }
         }*/
        #endregion

        #region Task-2(method)
        /* public static void DD()
         {
             Random random = new Random();
             int score = 0;
             int continues = 0;
             while (continues <=10)
             {
                 int b = random.Next(1, 100);
                 int a = random.Next(1, 100);
                 Console.WriteLine(a + " + " + b + " = ?");
                 int num = Convert.ToInt32(Console.ReadLine());
                 if (num == (a + b))
                 {
                     score += 5;
                     Console.WriteLine("Əla!");
                 }
                 else
                 {
                     Console.WriteLine("Ayyazığ!");
                     score -= 2;
                 }
                 Console.WriteLine("Davam edek?");
                 string str = Console.ReadLine();
                 if (str.Equals("no"))
                 {
                     break;
                 }
                 else if (str.Equals("Da"))
                 {
                     continues += 1;
                 }

             }
             Console.WriteLine("Score : " + score);

         }*/
        #endregion

        #region Task-3(method)
        /*public static void Number(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }*/
        #endregion
    }
}

