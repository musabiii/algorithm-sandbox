global using Algorithms.Utils;
using Algorithms.Sort;
Console.WriteLine("Hello, World!");

// BubbleSort.Run();

var ls = new List<int> { 1,5,2,8,3,9,4,9,6,1,9,2 };

ls.ForEach(el => System.Console.Write(el + ","));
System.Console.WriteLine();
var res = MergeSort.Run(ls);
res.ForEach(el => System.Console.Write(el + ","));
