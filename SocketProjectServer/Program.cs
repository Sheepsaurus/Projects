using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketProjectServer
{
	class Program
	{
		static void Main(string[] args)
		{
			//Connect
			TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Any, 13356));
			listener.Start();
			Console.WriteLine("Awaiting Clients");
			byte[] buffer = new byte[256];

			while (true)
			{
				//Receive
				buffer = new byte[256];
				Console.WriteLine
				(
					Encoding.UTF8
					.GetString(buffer, 0, listener
					.AcceptTcpClient()
					.GetStream()
					.Read(buffer, 0, buffer.Length))
				);
			}
		}
	}
}
