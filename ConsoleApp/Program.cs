//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BHMB">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ConsoleApp
{
    using System;

    /// <summary>
    /// Entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">progrm arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 2 and 2 is {Arithmetic.Add(2, 2)}.");
        }
    }
}
