var student = (firstName: "Teerapat", lastName: "Kemtis" , id: 66030077);
System.Console.WriteLine(
@$"First name: {student.firstName}
Last name: {student.lastName} 
ID:{student.id}");

int x = 3;
int y = 4;
System.Console.WriteLine($$"""Distance from origin to the point ({{x}}, {{y}}) is {{Math.Sqrt(x*x + y*y)}}""");

System.Console.WriteLine("\n\nMethod to show { and } in string");
System.Console.WriteLine($$"""Distance from origin to the point ({x}, {y}) is {Math.Sqrt(x*x + y*y)}""");