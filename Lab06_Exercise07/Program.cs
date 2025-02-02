﻿string s1 = "I \u0003 Visual C# ";
System.Console.WriteLine($"s1 = {s1}");

var indexOfC = s1.IndexOf("C");
System.Console.WriteLine($"Index of C in s1 = {indexOfC}");

var substring = s1.Substring(indexOfC, 2);
System.Console.WriteLine($"s1.Substring({indexOfC}, 2) = {substring}");

System.Console.WriteLine($"Replace C# with Basic and write to s2");

System.Console.WriteLine($"Before replace s1.hashcode = {s1.GetHashCode():X}");

var s2 = s1.Replace("C#", "Basic");
System.Console.WriteLine($"s1 = {s1}");
System.Console.WriteLine($"After replace s1.hashcode = {s1.GetHashCode():X}");