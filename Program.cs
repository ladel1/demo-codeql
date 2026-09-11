using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


string fileName = args[0];
string contenu = File.ReadAllText(fileName);

Console.WriteLine(contenu);

// Faille volontaire : MD5 est casse, on ne doit plus l'utiliser
// pour du hachage de securite (mots de passe, signatures...).
string motDePasse = "azerty123";
byte[] octets = Encoding.UTF8.GetBytes(motDePasse);

using MD5 md5 = MD5.Create();
byte[] empreinte = md5.ComputeHash(octets);

Console.WriteLine(Convert.ToHexString(empreinte));
