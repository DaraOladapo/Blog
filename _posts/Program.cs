using System;
using System.IO;

string directoryPath = "./";
string[] files = Directory.GetFiles(directoryPath, "*.md");

foreach (string file in files)
{
    string content = File.ReadAllText(file);
    Console.WriteLine($"Content of {file}:\n{content}\n");
}