using ProxyServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyServer.Business {
  public interface IProxy {
    Student CreateRequest(string name, string id);
    StudentGroup ReadRequest();
    void TestConnection();
  }
}
