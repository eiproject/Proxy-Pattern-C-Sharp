using ProxyClient;
using ProxyClient.Business;
using ProxyServer.Business;
using System;

namespace ProxyClient {
  class Program {
    static void Main(string[] args) {
      // Gather proxy from server
      IProxy proxy = new Proxy();

      // Creating client 
      IClient client = new Client(proxy);

      // Start to work
      Application app = new Application(client);
      app.Start();

      Console.ReadKey();
    }
  }
}