using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyServer.Models {
  public class StudentGroup {
    private List<Student> _studentList;
    internal List<Student> StudentList { get { return _studentList; } }
    internal StudentGroup() {
      _studentList = new List<Student>();
    }
    internal void AddStudent(Student student) {
      _studentList.Add(student);
    }
    public void Print() {
      Console.WriteLine("Student Database");
      foreach (Student student in _studentList) {
        student.Print();
      }
    }
  }
}
