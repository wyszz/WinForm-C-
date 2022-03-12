using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        /*  
         枚举
         enum Week
          {
              Sun, Mon, Tue, Wed, Thu, Fri, Sat
          };
          enum Days
          {
              Sun = 2, Mon, Tue, Wed, Thu, Fri, Sat
          };
        */
        static void Main(string[] args)
        {
            /*
             int num1 = 126;
            Console.WriteLine(num1);
            float num2 = 3.245f;
            Console.WriteLine(num2);
            double num3 = 1.234d;
            Console.WriteLine(num3);
            decimal num4 = 3.4565647m;
            Console.WriteLine(num4);
            char ch = 'a';
            Console.WriteLine(ch);
            string str = "大连外国语大学欢迎你";
            Console.WriteLine(str);
            const int num = 0X12;
            Console.WriteLine(num);
            const double d = 1.2334e3;
            Console.WriteLine(d);
            char ch2 = '\'';
            Console.WriteLine(ch2);
            const string str1 = "sadasdas";
            Console.WriteLine(str1);
            const double PI = 3.1415;
            Console.WriteLine(PI);
            Week w = Week.Sun;
            Console.WriteLine(w);
            Console.WriteLine((int)w);
            Days w2 = Days.Sun;
            Console.WriteLine(w2);
            Console.WriteLine((int)w2);
            int numa = Console.Read();
            Console.WriteLine(numa);
            Console.WriteLine((char)numa);
            string stra = Console.ReadLine();
            Console.Write(stra);
            Console.WriteLine(stra);
            Console.WriteLine("xingming :");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            */

            /*
             学生成绩输出 
            Console.WriteLine("请输入学生的信息:");
            Console.Write("姓名：");
            string namei = Console.ReadLine();
            Console.Write("成绩；");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("学生信息如下：");
            Console.WriteLine("姓名：{0}", namei);
            Console.WriteLine("成绩：{0}", grade);
            */

            /*
             强制转换
            int num1;
            short num2 = 23;
            num1 = num2;
            num2 = (short)num1;
            double num1;
            num1 = Convert.ToDouble(Console.ReadLine());
            */

            /* 
             学生信息
             Console.Write("学号：");
             string sno = Console.ReadLine();
             Console.Write("姓名：");
             string name = Console.ReadLine();
             Console.Write("姓别：");
             char sex = Convert.ToChar(Console.ReadLine());
             Console.Write("年龄：");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("学生信息如下：");
             Console.WriteLine("姓名：{0}", name);
             Console.WriteLine("学号：{0}", sno);
             Console.WriteLine("性别：{0}", sex);
             Console.WriteLine("年龄：{0}", age);
            */

            /*
             三元运算符输出两个数最大值
            int iabs;
            Console.Write("请输入第一个数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个数：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            iabs = num1 > num2 ? num1 : num2;
            Console.WriteLine(iabs);
            */


            /*
             温度转换 
            Console.Write("请输入华氏温度：");
            double F = Convert.ToDouble(Console.ReadLine());
            double C =5.0 / 9*(F - 32);
            Console.Write("摄氏温度：");
            Console.WriteLine("{0:F3}",C);
            */

            /*
             for循环
            int num;
            int sum = 0;
            int i;
            Console.Write("请输入一个数");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                sum += i;
            Console.WriteLine("1+2+..+{0}={1}",num,sum);
            */

            //使用for语句编写程序：求sn=a+aa+aaa+…+aa…a的值，其中a是一个数字，aa…a表示n个a，a和n由键盘输入。
            /*
             1
             int a;
            int n;
            int i;
            int b =0;
            int sn = 0;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                b = n * 10;
            b = b + a;
            sn = sn + b;
            Console.WriteLine("sn={0}", sn);
            */

            /*
             2
            double a, num, count = 1;
            double sum = 0, temp = 0;
            double b;
            Console.Write("请输入一个数");
            a = Convert.ToInt32(Console.ReadLine());
            b = a.ToString().Length;
            Console.Write("请输入要加到几位");
            num = Convert.ToInt32(Console.ReadLine());
            for (; count <= num;)
            {
                temp = temp + a;
                sum = sum + temp;
                a = a * Math.Pow(10, b);
                ++count;
            }
            Console.WriteLine("sum={0}", sum); */
            /*
             3
          
            string num, temp;
            int sum = 0, n;
            Console.Write("请输入一个数");
            num = Console.ReadLine();
            Console.Write("请输入要加到几位");
            n = Convert.ToInt32(Console.ReadLine());
            temp = num;
            for (int i = 1; i <= n; i++)
            {
                sum += Convert.ToInt32(temp);
                temp += num;
            }
            Console.WriteLine("a+aa+aaa...+{0}={1}",temp,sum); 
            */

            /*
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            Console.WriteLine("王艺石");
            */

            /*
             求n的阶乘
             int i = 1;
            int sum = 1;
            int n ;
            int t=1;
            Console.Write("请输入n:");
             n= Convert.ToInt32(Console.ReadLine());
           while (i <= n)
             {
                 sum *= i;//阶乘
                 i++;
             }
             Console.WriteLine(sum);
            */

            /*
             阶乘求和
            int i = 1;
            int sum = 0;
            int n;
            int mul = 1;
            Console.Write("请输入n:");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                mul *=i;
                sum += mul;
                Console.WriteLine("{0}！={1}",i,mul);
                i++;
            }
            Console.WriteLine(sum);
            */

            /* 
             使用while语句编写程序：有一个分数序列2/1,  3/2,  5/3, …,  求出这个分数序列前20项之和。
            double sum = 0;
            double m = 1.0;
            double n = 2.0;
            while (m <= 20)
            {
                Console.WriteLine("{0}/{1}", n, m);
                sum += n / m;
                n += m;
                m++;
            }
            Console.WriteLine(sum);
            */

            /*
             打印出所有的“水仙花数”， “水仙花数”是指一个三位数，其各位数字立方和等于该数本身。例如，153是一个“水仙花数”，因为153是一个"水仙花数"，因为153=1的三次方＋5的三次方＋3的三次方 
            int i, x, y, z;
            for (i = 100; i < 1000; i++)
            {
                x = i % 10;
                y = (i / 10) % 10;
                z = i / 100;
                if (i == x * x * x + y * y * y + z * z * z)
                {
                    Console.WriteLine("{0}是水仙花数", i);
                }   
             }
            */
            /*
             使用do…while语句编写程序：请输入介于0~100之间的整数，设置要猜的数值为67，根据键盘输入的数字跟被猜数字进行比较，输出猜数字次数以及是否猜中。如果没猜中，对输入数字跟被猜数字的大小比较输出。
            
            int num ;//floor向下取整
            Random rand = new Random();
            num = rand.Next(0, 101);
            int count = 0;
            bool guess = false;
            do
            {
                Console.Write("请输入介于0~100之间的整数:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                count++;
                if (num2 > num)
                    Console.WriteLine("第{0}次，{1}太大了",count, num2);
                else if (num2 < num)
                         Console.WriteLine("第{0}次，{1}太小了",count, num2);
                else
                {
                    Console.WriteLine("第{0}次，猜对了",count, num2);
                    guess = true;
                }
            }
            while (!guess); 
            */

            /*
             *  使用Do …While语句编写程序，迭代法求平方根。
                已知求平方根的迭代公式为：x n+1 = (xn + a / xn) / 2要求前后两次求出的差的绝对值小于10-5。
            double xn1;
            double xn = 3;
            Console.Write("请输入a:");
            int a = Convert.ToInt32(Console.ReadLine());
            xn1 = (xn + a / xn) / 2;
            do
            {
                Console.WriteLine(xn1);
                xn = xn1;
                xn1 = (xn + a / xn) / 2;
            } while (Math.Abs(xn1 - xn) > 0.000001);
            */

            /*
             输入一个整数n，判断该数是否素数。 
            Console.Write("请输入整数NUM：");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                    break;
            }
            if (i == num)
                Console.WriteLine("{0}是素数",num);
            else
                Console.WriteLine("{0}不是素数",num);
            */

            /*
             * 把1~100之间不能被3整除的数输出。
             
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    continue;
                else
                    Console.WriteLine(i);    
             }
            */
            /*
             用for循环计算0-20之间的奇数和，并把相应的奇数以及和进行输出，如下图所示，当和大于60时，退出循环。
             */

            /*嵌套循环求素数
            int i;
            int j;
            for (i = 100; i <= 200; i++)
            {
                for (j = 2; j < i; j++)
                { 
                if(i%j==0)
                        break;
                }
                if(j==i)
                    Console.WriteLine(i+ "是素数");
            }
            */

            /*
             * 一个数如果恰好等于它的因子之和，这个数就称为“完数”，例如6的因子为1、2、3，而6=1+2+3，因此6是“完数”。输出1000以内的所有完数。
             
            int i, n, sum;
            for (i = 2; i <= 1000; i++)
            {
                sum = 0;//清零
                for (n = 1; n < i; n++)
                {
                    if (i % n == 0)
                        sum = sum + n;
                }
                if (sum == i)
                    Console.WriteLine(i + "是完数");
            }*/

            /*
             * 一维数组定义4种方法
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr3 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr4;
            arr4 = new int[5] { 1, 2, 3, 4, 5 };
            for(int i=0;i<arr.Length;i++)
                Console.WriteLine(arr[i]+"");
            foreach (int k in arr)
                Console.Write(k + "");
            Console.WriteLine();
            */

            /*
             * 从键盘上输入10个数，输出最大值和最小值
            int[] arr = new int[10];
            Console.WriteLine("请输入十个数");
            for (int i = 0; i <= 9; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            int sum = 0;
           
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                sum += arr[i];
            }
            Console.WriteLine("最大的数为" + arr[0]);
            Console.WriteLine("最小的数为:" + arr[9]);
            */

            /*
            1     给定5个数：13、25、14、7、8，将它们存储在一个数组中，按“冒泡”排序法将其按从小到大的顺序输出。

            int[] arr = new int[5] { 13, 25, 14, 7, 8 };
            int temp = 0;


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }


            }
            foreach (int a in arr)
                Console.Write(a + " ");
            */

            /* 2
             *  int[] arr = new int[] { 25, 14, 13, 8, 7 };
             int temp;
             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 4 - i; j++)
                 {
                     if(arr[j]>arr[j+1])
                     {
                         temp = arr[j];
                         arr[j] = arr[j + 1];
                         arr[j + 1] = temp;
                     }

                 }
             }
             foreach (int a in arr)
                 Console.Write(a + " ");
              */
            /*
             从键盘输入学生数n, 依次输入学生姓名并遍历输出。
            
            Console.Write("n:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] student = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("请输入第{0}个学生姓名:", i + 1);
                student[i] = Console.ReadLine();
            }
            Console.WriteLine("\n输入结束，你输入的学生姓名如下：");
            foreach (string name in student)
            {
                Console.WriteLine(name);
            } 
            */

            /*二维数组
            int[,] score = { {1,2,3, }, {4,5,6 } };
            int row = score.GetLength(0);
            int coloum = score.GetLength(1);
            for (int i = 0; i < row; i++)
            { 
            for(int j=0;j<coloum;j++)
                {
                    Console.Write(score[i,j]+" ");
                }
                Console.WriteLine();
            }
            */
            /*
            int[,] score = { { 1, 2, 3, }, { 4, 5, 6 } };
            // int row = score.GetLength(0);
            //int coloum = score.GetLength(1);
            for (int i = score.GetLowerBound(0); i <= score.GetUpperBound(0); i++)
            {
                for (int j = score.GetLowerBound(1); j <=score.GetUpperBound(1); j++)
                {
                    Console.Write(score[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            /*
             将一个矩阵的行和列元素互换，存到另一个矩阵中
            
            int[,] A = { { 1, 2, 3, }, { 4, 5, 6 } };
            int[,] B = new int[3, 2];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j <A.GetLength(1); j++)
                {
                    B[j,i]=A[i,j];
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    Console.Write(B[i,j] + " ");
                    Console.WriteLine();
                
            }*/

            /*
             * 假设某个班有三名学生，每个学生有四门课程，输入学生各科的成绩，并求每个学生的平均成绩
            
            int[,] score = new int[3, 4];
            int sum;
            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write("请输入第{0}个学生的第{1}门成绩：", i + 1,j+1) ;
                    score[i, j] = Convert.ToInt32(Console.ReadLine());
                }
              
            }
            for (int i = 0; i < score.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < score.GetLength(1); j++)
                    sum += score[i, j];
                Console.WriteLine("第{0}个学生的平均成绩为{1}", i + 1,sum/4) ;
            } */

            /*
             * 交错数组 
            string[][] arr = new string[4][];
            arr[0] = new string[] { "1", "3", "5", "7", "9", "13" };
            arr[1] = new string[] { "0", "2" };
            arr[2] = new string[3];
            arr[2][0] = "5";
            arr[3] = new string[5];
            arr[3][4] = "32";
            foreach (string[] hang in arr)
            {
                foreach (string lie in hang)
                    Console.Write("{0,4}", lie);
                Console.WriteLine();
            }
           */

            /*
             * 字符串
            string s = "C# is my favourite language";
            for (int index = 0; index < 8; index++)
            {
                Console.WriteLine("[{0}]= 字符{1}",index,s[index]);
            }
            Console.WriteLine(s.Length);
            */

            /*
             * 编写程序，打印出以下的杨辉三角形（要求打印出10行）
            Console.WriteLine("请输入长度：");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] array = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        array[i, j] = 1;
                    }
                    else 
                    {
                        array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
                    }
                    Console.Write(array[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
               */

            /*ArrayList用法*/
            ArrayList aList = new ArrayList();
            aList.Add("a");
            aList.Add("123");
            aList.Add("12.345");
            foreach (object o in aList)
                Console.WriteLine(o);

        }
    }
}
