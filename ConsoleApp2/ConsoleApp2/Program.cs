using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*（1）定义Course类，具有int类型的成员变量课程号(cno)、 string类型的成员变量课程名(cname) ，具有返回课程信息的方法（GetCourseInfo），并定义对应的读写属性，规定课程号只能从100开始输入，检查课程号输入是否符合要求。
（2）在类Program的Main方法中，测试Course类的功能，从键盘上输入Course类成员的值，调用GetCourseInfo输出课程信息。
*/
namespace ConsoleApp2
{

    class Course
    {
        int cno;
        string cname;

        public string Cname { get => cname; set => cname = value; }
        public int Cno { get => cno; set => cno = value; }

        public void GetCourseInfo()
        {
           
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            Console.WriteLine("请输入课程编号：");

        }
    }
}
