using System.IO.Compression;
using System.Diagnostics;

var sw = Stopwatch.StartNew();
var task = ZipFile.CreateFromDirectoryAsync("SampleData", "output_async.zip");

int dots = 0;
while (!task.IsCompleted)
{
    Console.Write('.');
    dots++;
    await Task.Delay(200);
    if (dots % 50 == 0) Console.WriteLine();
}
await task;

sw.Stop();
Console.WriteLine($"Async ZIP completed in {sw.ElapsedMilliseconds} ms");
Console.ReadLine();