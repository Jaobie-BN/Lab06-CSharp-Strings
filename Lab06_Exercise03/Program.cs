string s1 = "A string is more";
string s2 = " than the sum of its chars.";

System.Console.WriteLine("Before Concatenation of s1 and s2:");
System.Console.WriteLine($"s1 = \"{s1}\", Hash Code = {s1.GetHashCode():X}");
System.Console.WriteLine($"s2 = \"{s2}\", Hash Code = {s2.GetHashCode():X}");

s1 += s2;

System.Console.WriteLine("\nAfter Concatenation of s1 and s2:");
System.Console.WriteLine($"s1 = \"{s1}\", Hash Code = {s1.GetHashCode():X}");
System.Console.WriteLine($"s2 = \"{s2}\", Hash Code = {s2.GetHashCode():X}");
