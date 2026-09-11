using System;
using System.IO;


string fileName = args[0];
string contenu = File.ReadAllText(fileName);
        
Console.WriteLine(contenu);
