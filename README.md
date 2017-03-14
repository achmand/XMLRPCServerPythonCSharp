# XML-RPC Server Python & C#

A simple example/concept showing how to run an XML-RPC Server using python and calling functions from code written in c#.

For the server side, I imported the SimpleXMLRPCServer module which provides a basic server framework for XML-RPC servers. For more information on the module visit https://docs.python.org/3.4/library/xmlrpc.server.html?highlight=simplexmlrpcserver#xmlrpc.server.SimpleXMLRPCServer

As for the client I used XML-RPC.NET, which can be easily added by running the following command in the Package Manager Console :

'Install-Package xmlrpcnet'

This library is used to implement XML-RPC services and clients in a .NET environment. In this case we will use this package to use services on the client. For more information on this library visit http://xml-rpc.net/ .

The example is pretty straight forward, there is a method which checks if a number is even or odd, and returning 0 or 1. Then on the client we call the function and pass a number, and get a result from the server (True or False).

On the client, an interface was created and it implements the IXmlRpcProxy interface which comes with the xmlrpcnet library. The url must be specified as an attribute in the XmlRpcUrl Attribute. The method inside the interface also has an attribute called XmlRpcMethod which taked the method name. Note that the name of the method set in this attribute must match the name set in the server inside the 'register_function' method.

On more information about the RPC protocol visit https://en.wikipedia.org/wiki/XML-RPC.
