// another excemtion demo
// error4.cs
class Demo {
				public static void Main() {
								double result;
								try {
												result = 2.0 / 0;
												Console.WriteLine("Result: " + result);
								}
								catch (Exception e)
								{
												Console.WriteLine("Error: " + e.Message);
								}
				}
}

