class calculator
{
	static void main(string[] args)
	{
	  int a = 12;
	  int b = 3;
	 
		console.WriteLine("hasil penambahan: {0} + {1} = {2}", a, b, penambahan(a,b));
		console.WriteLine("hasil penambahan: {0} - {1} = {2}", a, b, pengurangan(a,b));
	
		console.WriteLine("\nTekan sembarang nek arep metu");
		console.Readkey();
	}
	
	static int penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
	
}