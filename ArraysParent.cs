using System;
namespace Task3_1
{
	public abstract class ArraysParent
	{
		public abstract  void Print();
		public ArraysParent(bool randi) { }
        public abstract void Createarray(bool randi);
		public abstract void Getmiddle();
		protected abstract void Fill_array();
		protected abstract void Fill_array_random();


    }
	
}

