using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Flyweight
{
    public class Flyweight : IPattern
    {
        public void Example()
        {
            StudentFlyweightBuilder builder = new StudentFlyweightBuilder();

            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    students.Add(builder.CreateStudent(int.Parse((i + j).ToString())
                        , (i+j).ToString(), i.ToString()));
                }
            }
            //проверяем, что у студентов нет ни одного state, которого нет в билдере
            if (students.Any(x => !builder.StudentStates.Contains(x.State)))
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Finished");
        }
    }
}
