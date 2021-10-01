using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace GettingAllocatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string allocatedString = "123";
            BenchmarkRunner.Run<BenchmarkClass>();
            Console.ReadLine();
        }
    }

    [MemoryDiagnoser]
    public class BenchmarkClass
    {
        [Benchmark]
        public void GetAllocatedString()
        {
            var myString = String.Intern("123");
        }
    }
}
