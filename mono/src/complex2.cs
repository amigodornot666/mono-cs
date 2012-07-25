// 2nd complex number class example
// complex2.cs
using System;

class Complex {
				private int x;
				private int y;

				//constructor
				public Complex() {
				}

				//Constructor + Initialization
				public Complex(int i, int j) {

								x = i;
								y = j;
				}

				//Display data
				public void PrintComplex() {
								Console.WriteLine("{0} + {1}i", x, y);
				}

				// Implementation of the + operator
				public static Complex operator+(Complex number1,Complex number2) {
								Complex temp = new Complex();
								temp.x = number1.x + number2.x;
								temp.y = number1.y + number2.y;
								return temp;
				}
}

class Demo {
				public static void Main() {
								Complex number1 = new Complex(10,20);
								Complex number2 = new Complex(20,30);
								Complex result = new Complex();

								result = number1 + number2;
								result.PrintComplex();
								result += number1;
								result.PrintComplex();
				}
}


