// 1st delegate demo
// delegate1.cs
using System;

public delegate void MyDelegate(string input);

class Class1 {
				public void delegateMethod1(string input) {
								Console.WriteLine("DelegateMethod1: {0}", input);
				}

				public void delegateMethod2(string  input) {
								Console.WriteLine("DelegateMethod2: {0}", input);
				}
}

class Class2 {
				public  MyDelegate neuDelegate() {
								Class1 c2 = new Class1();
								MyDelegate d1 = new MyDelegate(c2.delegateMethod1);
								MyDelegate d2 = new MyDelegate(c2.delegateMethod2);
								MyDelegate d3 = d1 + d2;
								return d3;
				}
}

class Class3 {
				public void callDelegate(MyDelegate d, string input) {
								d(input);
				}
}

class Driver {
				static void Main(string[] args) {
								Class2 c2 = new Class2();
								MyDelegate d = c2.neuDelegate();
								Class3 c3 = new Class3();
								c3.callDelegate(d, "calling the delegate");
				}
}

								



