using System;
using System.Collections.Generic;
using SCribe.Thrift;
using Thrift.Protocol;
using Thrift.Transport;

namespace ScribeClientExample
{
	class Program
	{
		static void Main()
		{
            //string hostname = "0.0.0.0";
            //int port = 1463;

            //TSocket socket = new TSocket(hostname, port);
            //TFramedTransport transport = new TFramedTransport(socket);
            //TBinaryProtocol protocol = new TBinaryProtocol(transport, false, false);
            //transport.Open();

            //LogEntry logEntry = new LogEntry()
            //                        {
            //                            Category = "events",
            //                            Message = "Hello World!"
            //                        };


            //FacebookService.Client fbClient = new FacebookService.Client(protocol);
            //string name = fbClient.getName();
            //fb_status status = fbClient.getStatus();

            //Console.WriteLine("{0},{1}", name, status);
			
            //scribe.Client scribeClient = new scribe.Client(protocol);
            //scribeClient.Log(new List<LogEntry>() { logEntry});
            //transport.Close();

		    var sc = new ScribeClient();
		}
	}
}
