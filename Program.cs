using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            

            //Okay using these datasets let's try some linq! 
            //Using the students list:
            //1) Find all students who are older than 21

            //2) Find the oldest student

            //3) Find the youngest student

            //4) Find all students with even ages

            //5) Find all students with odd ages AND are over 21

            //Using nums 
            //1) Find the max value 

            //2) Find the min value 

            //3) Find all values between 100 and 1000 inclusive 

            //4) Count all the even numbers 

            //5) 
        }
    }
}
