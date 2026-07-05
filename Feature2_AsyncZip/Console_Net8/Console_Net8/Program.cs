using System.IO.Compression;
using System.Diagnostics;

var sw = Stopwatch.StartNew();
ZipFile.CreateFromDirectory("SampleData", "output_async1.zip");

sw.Stop();

Console.WriteLine($"Async ZIP completed in {sw.ElapsedMilliseconds} ms");
Console.ReadLine();