using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


string fileName = args[0];
string contenu = File.ReadAllText(fileName);

Console.WriteLine(contenu);

// Faille volontaire : DES est un algorithme de chiffrement obsolete.
using DESCryptoServiceProvider des = new DESCryptoServiceProvider();
