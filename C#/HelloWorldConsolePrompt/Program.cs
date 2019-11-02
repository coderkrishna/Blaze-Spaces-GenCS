// <copyright file="Program.cs" company="Blaze Spaces">
// Copyright (c) Blaze Spaces. All rights reserved.
// </copyright>

namespace HelloWorldConsolePrompt
{
    using System;

    /// <summary>
    /// The main driver class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(Resources.FirstNamePromptText);
            var firstName = Console.ReadLine();

            Console.WriteLine(Resources.LastNamePromptText);
            var lastName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}");
        }
    }
}