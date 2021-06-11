using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Node<T>
	{
		
		public Node<T> next;
		public Node<T> prev;
		public Node<T> Top;
		public Node<T> stack;
		public Node<T> Pervaya;

		public T value;
		public static int count;
		public Node()
		{

		}
		public Node(T value)
		{
			this.value = value;
		}

		public Node(int value1)
		{
		}
	}
}
