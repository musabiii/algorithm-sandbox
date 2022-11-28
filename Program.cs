using Algorithms.Sort;
Console.WriteLine("Hello, World!");

// BubbleSort.Run();

var ls = new List<int> { 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

ls.ForEach(el => System.Console.Write(el + ","));
System.Console.WriteLine();
var res = CombSort.Run(ls);
res.ForEach(el => System.Console.Write(el + ","));
