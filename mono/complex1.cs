// a complex number constructor
// complex1.cs
using System;

class Complex {
				private int x;
				private int y;

				// constructor
				public Complex() {

								}
	
				// constructor initialization
				public Complex(int i, int j) {
								x = i;
								y = j;
				}

				// displaying data
				public void PrintComplex() {
								Console.WriteLine("{0} + {1}i", x, y);
				}

				// implementation of the + operator 
				public static Complex operator+(Complex number1,Complex number2) {
								Complex temp = new Complex();
								temp.x = number1.x + number2.x;
								temp.y = number1.y + number2.y;
								return temp;
				}
}

class Demo {
				public static void Main() {
								Complex number1 = new Complex(10, 20);
								Complex number2 = new Complex(20, 30);
								Complex ergebnis = new Complex();

								ergebnis = number1 + number2;
								ergebnis.PrintComplex();
				}
}



