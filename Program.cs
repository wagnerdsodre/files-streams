
//Criando um path combinado
//var path = Path.Combine(Environment.CurrentDirectory , "file.txt");
var path = Path.Combine(@"c:\temp" , "file.txt");


var fc = File.CreateText(path);
fc.WriteLine("Este é um arquivo de texto da linha 1");
fc.WriteLine("Este é um arquivo de texto da linha 2");
fc.WriteLine("Este é um arquivo de texto da linha 3");
fc.WriteLine("Este é um arquivo de texto da linha 4");
fc.Flush();

