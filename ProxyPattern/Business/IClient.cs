using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyClient.Business {
  interface IClient {
    void CreateData(string name, string id);
    void ReadData();
    void TestConnection();
  }
}
