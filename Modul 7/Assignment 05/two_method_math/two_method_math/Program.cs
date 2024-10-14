using two_method_math;

CalculateMath calculate = new();

calculate.AddMethod(5);
calculate.AddMethod(20);
calculate.AddMethod(4);

Console.WriteLine(calculate.SumMethod());