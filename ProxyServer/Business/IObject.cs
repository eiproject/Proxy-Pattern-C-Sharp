using ProxyServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyServer.Business {
  interface IObject {
    Student UpdateRequest();
    List<Student> ReadRequest();
  }
}
