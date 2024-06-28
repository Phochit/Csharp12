
string Customer1 = """{ "CustomerID" : "C0001", "Name" : "Mg Mg" }""";
Console.WriteLine(Customer1);
Console.WriteLine("\n---------------*-----------------");

string Customer2 =
    """
	{
		"CustomerID" : "C0002",
		"Name" : "Aung Aung"
	}
	""";
Console.WriteLine(Customer2);
Console.WriteLine("\n---------------*-----------------");

int i = 3;
string Customer3 = $$"""
	{ 
		"CustomerID" :{{"C"+(i + 2).ToString("D4")}}, 
		"Name" : "Aye Aye" 
	}
	""";
Console.WriteLine(Customer3);
Console.WriteLine("\n---------------*-----------------");

const char tab = '\t';
string sourceCode = $$"""
	using System;

	class Program
	{
	{{tab}}static void Main()
		{
			
		}
	}
	""";
Console.WriteLine(sourceCode);
Console.WriteLine("\n---------------*-----------------");

string xml= $$"""
	<Customer>
		<CustomerID>{{"C" + (i + 3).ToString("D4")}}</CustomerID>
		<Name>Ma Hla</Name>
	</Customer>
	""";
Console.WriteLine(xml);
Console.WriteLine("\n---------------*-----------------");

Console.ReadKey();


