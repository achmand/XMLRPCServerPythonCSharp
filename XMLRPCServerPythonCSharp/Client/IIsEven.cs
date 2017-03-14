using CookComputing.XmlRpc;

namespace Client
{
    [XmlRpcUrl("http://localhost:8000/RPC2")]
    public interface IIsEven : IXmlRpcProxy
    {
        [XmlRpcMethod("IsEven")]
        bool IsEven(int n);
    }
}
