using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Flyweight
{
    public class StudentFlyweightBuilder
    {
        public HashSet<StudentState> StudentStates = new HashSet<StudentState>();
        public Student CreateStudent(int id, string name, string state)
        {
            StudentState studentState = new StudentState() { State = state };
            if (!StudentStates.Contains(studentState))
            {
                StudentStates.Add(studentState);
            }
            else
            {
                studentState = StudentStates.Where(x => x.State == state).FirstOrDefault();
            }
            Student student = new Student() { Id = id, Name = name, State = studentState };
            return student;
        }
    }
}
