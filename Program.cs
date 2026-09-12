using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

string fileName = args[0];
string contenu = File.ReadAllText(fileName);

Console.WriteLine(contenu);

// Faille volontaire : DES est un algorithme de chiffrement obsolete.
using DESCryptoServiceProvider des = new DESCryptoServiceProvider();


string json = JsonConvert.SerializeObject(new { Nom = "Alice" });
Console.WriteLine(json);
