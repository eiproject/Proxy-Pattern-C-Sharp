using ProxyClient.Business;
using ProxyServer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyClient {
  class Application {
    IClient _client;
    internal Application(IClient client) {
      _client = client;
    }

    internal void Start() {
      Console.WriteLine("Checking connection to server ...");
      _client.TestConnection();

      _client.CreateData("Nid", "11781187");
      _client.CreateData("Yun", "25437690");
      _client.CreateData("Sal", "32216437");

      _client.ReadData();
    }
  }
}
