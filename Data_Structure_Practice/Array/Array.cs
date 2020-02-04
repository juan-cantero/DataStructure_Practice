using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Datastructure_Practice
{
	public class Array<T>
	{
		private T[] _array = new T[20];
		private int _lastElement = 0;


		public IEnumerable<T> GetItems()
		{
			for (int i = 0; i < _lastElement; i++)
			{
				yield return _array[i];
			}
		}
		

		public void Add(T element)
		{
			EnsureCapacity();
			_array[_lastElement] = element;
			_lastElement++;
		}

		public T GetElementAt(int index)
		{
			if(IsValidPosition(index))
				return _array[index];
			
			throw new ArgumentOutOfRangeException("index out of bound");
		}

		public void RemoveAt(int pos)
		{
			if (IsValidPosition(pos))
			{
				RearrangeArrayAfterRemoval(pos);
				_lastElement--;
				
			}

		}
			

		public int IndexOf(T element) 
		{
			var index = -1;
			for (int i = 0; i < _lastElement; i++)
			{
				T elementToCompare = _array[i];
				if (element.Equals(elementToCompare))
				{
					index = i;
					break;
				}
				
			}
			return index;

			
		}

		public void InsertAt(int pos, T element)
		{
			if (pos > _array.Length - 1) 
			{ 
				Add(element); 
			}
			else
			{
				EnsureCapacity();
				RearrangeArrayForInserting(pos);
				_array[pos] = element;
				_lastElement++;
			}
		}

		private void RearrangeArrayForInserting(int pos)
		{
			for (int  i = _lastElement; i >= pos; i--)
			{
				_array[i + 1] = _array[i];
			}
		}

		private void RearrangeArrayAfterRemoval(int pos)
		{
			for (int i = pos; i < _lastElement; i++)
			{
				_array[i] = _array[i + 1];
			}
		}

		private bool IsValidPosition(int pos) 
		{
			return pos >= 0 && pos <= _lastElement;
		}

		private void EnsureCapacity()
		{
			int arrayLenght = _array.Length;
			if (_lastElement > arrayLenght / 2)
			{
				T[] tempArray = new T[arrayLenght * 2];
				Array.Copy(_array, tempArray, _lastElement);
				_array = tempArray;
			}
		}

		}
}
