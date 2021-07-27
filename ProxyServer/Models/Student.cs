using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyServer.Models {
  public class Student {
    private string _name;
    private string _idNumber;

    public string Name { get { return _name; } }
    public string IdNumber { get { return _idNumber; } }

    internal Student(string name, string id) {
      _name = name;
      _idNumber = id;
    }
    public void Print() {
      Console.WriteLine($"{_name}\t{_idNumber}");
    }
  }
}
