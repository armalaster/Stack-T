using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class MyList<T>
	{
		public void Add(T value)
		{
			Node<T> ddd = new Node<T>();
			ddd.value = value;
			if (firstElement == null)
			{
				firstElement = ddd;
			}
			else
			{
				GetLast().next = ddd;
			}
		}
		Node<T> firstElement;
		Node<T> GetLast()
		{
			Node<T> last = firstElement;
			while (last.next != null)
			{
				last = last.next;
			}
			return last;
		}
		public void Print()
		{
			Node<T> last = firstElement;
			//Console.WriteLine("Записанные данные в List последним элементом в списке, поставленный в начале:");
			while (last != null)
			{
				//Console.WriteLine(last.value);
				last = last.next;
			}
		}
		public void listPush(T v1)
		{
			Node<T> b = new Node<T>();
			b.value = v1;
			if (firstElement != null)
			{
				firstElement.prev = b;
				b.next = firstElement;
				firstElement = b;
				//Console.WriteLine("Последий элемент из списка это: " + v1);
				//Console.WriteLine();
			}
		}

		class Stack <T>
		{
			public Node<T> stack;
			public Node<T> Top;
			public void Push(Node<T> NewNode)
			{
				if (stack != null)
				{
					Node<T>.count++;
					Node<T> node1 = GetLast();
					Node<T> node = node1;
					node.next = NewNode;
					Top = node;
					return;
				}
				stack = NewNode;
				Node<T> Pervaya = stack;
				Node<T>.count++;
				
			}
			Node<T> firstElement;
			private Node<T> pervaya;

			public Node<T> GetLast()
			{
					Node<T> last = firstElement;
					while (last.next != null)
					{
						last = last.next;
					}
					return last;	
			}
			public void Pop()
			{
				Node<T> Tekuhiy = stack;
				while (Tekuhiy.next != Top)
				{
					Tekuhiy = Tekuhiy.next;
				}
				Top = null;
				Top = Tekuhiy;
			}
			public T top()
			{
				Node<T> Tekuhiy = stack;
				T valueToReturn;
				while (Tekuhiy.next != Top)
				{
					Tekuhiy = Tekuhiy.next;
				}
				valueToReturn = Tekuhiy.value;
				return valueToReturn;
			}
			public void Print()
			{
				Node<T> last = pervaya;
				while (last != null)
				{
					Console.WriteLine(last.value);
					last = last.next;
				}

			}

		}

	}
}
