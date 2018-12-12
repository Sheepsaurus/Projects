using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects2
{
	class Program
	{
		static void Main(string[] args)
		{
		}
		public Node getList()
		{
			Node p = new Node();
			Node p2 = new Node();
			p.TAL = 1;
			p2.TAL = 2;
			p.NEXT = p2;
			return p;
		}
	}	

	public class Node
	{
		public int TAL;
		public Node NEXT = new Node();
	}

}
