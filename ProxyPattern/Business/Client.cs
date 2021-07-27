using ProxyServer.Business;
using ProxyServer.Models;
using System;
using System.Collections.Generic;

namespace ProxyClient.Business {
  class Client : IClient {
    private IProxy _proxy;
    internal Client(IProxy proxy) {
      _proxy = proxy ?? throw new NullReferenceException("Proxy is NULL."); ;
    }

    void IClient.CreateData(string name, string id) {
      Student student = _proxy.CreateRequest(name, id);
      Console.WriteLine($"... Done adding {name} {id}");
    }

    void IClient.ReadData() {
      Console.WriteLine("Reading database from proxy server ...");
      StudentGroup students = _proxy.ReadRequest();
      students.Print();
    }

    void IClient.TestConnection() {
      _proxy.TestConnection();
    }
  }
}
