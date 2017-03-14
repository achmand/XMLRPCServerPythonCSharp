using System;
using CookComputing.XmlRpc;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = XmlRpcProxyGen.Create<IIsEven>();
            var x = proxy.IsEven(4);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
