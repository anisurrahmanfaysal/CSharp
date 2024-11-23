int? x = null;          // Using '?' int datatype make nullable.

x = 5;
if(x.HasValue)
    Console.WriteLine(x.Value);

string? s = null;