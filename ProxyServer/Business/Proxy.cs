using ProxyServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyServer.Business {
  class Proxy : IObject {
    private StudentGroup _group;
    internal Proxy(StudentGroup group) {
      _group = group ?? throw new NullReferenceException("StudentGroup is NULL.");
    }
    List<Student> IObject.ReadRequest() {
      return _group.StudentList;
    }

    Student IObject.UpdateRequest(string name, string id) {
      Student createdStudent = new Student(name, id);
      _group.AddStudent(createdStudent);
      return createdStudent;
    }
  }
}
