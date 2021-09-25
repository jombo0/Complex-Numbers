using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
	class Complex
	{
		public float Real { get; set; }										//вещественная часть
		public float Imaginary { get; set; }								//мнимая часть

		public void Read()													//Ввод
		{
			Console.Write("Вещественная часть = ");
			Real = float.Parse(Console.ReadLine());
			Console.Write("Мнимая часть = ");
			Imaginary = float.Parse(Console.ReadLine());
		}

		public void Display()												//Вывод
		{
			Console.WriteLine("Вещественная часть = " + Real.ToString());
			Console.WriteLine("Мнимая часть = " + Imaginary.ToString());
		}

		public static Complex operator + (Complex a, Complex b)				//Перегрузка оператора +
		{
			Complex result = new Complex();
			result.Real = a.Real + b.Real;
			result.Imaginary = a.Imaginary + b.Imaginary;
			return result;
		}

		public static Complex operator - (Complex a, Complex b)             //Перегрузка оператора -
		{
			Complex result = new Complex();
			result.Real = a.Real - b.Real;
			result.Imaginary = a.Imaginary - b.Imaginary;
			return result;
		}

		public static Complex operator * (Complex a, Complex b)             //Перегрузка оператора *
		{
			Complex result = new Complex();
			result.Real = a.Real * b.Real - a.Imaginary * b.Imaginary;
			result.Imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
			return result;
		}

		public override string ToString()                                   //Перегрузка метода ToString()
		{
			return $"{Real} + {Imaginary}i";
		}
	}
}
