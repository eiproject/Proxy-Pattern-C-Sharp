using ProxyServer.Models;
using System;
using System.Collections.Generic; 

namespace ProxyServer.Business {
  public class Proxy : IProxy {
    private StudentGroup _group;
    public Proxy() {
      StudentGroup group = new StudentGroup(); 
      _group = group ?? throw new NullReferenceException("StudentGroup is NULL.");
    }
    StudentGroup IProxy.ReadRequest() {
      return _group;
    }

    Student IProxy.CreateRequest(string name, string id) {
      Student createdStudent = new Student(name, id);
      _group.AddStudent(createdStudent);
      return createdStudent;
    }

    void IProxy.TestConnection() {
      Console.WriteLine("Connection, OK.");
    }
  }
}

