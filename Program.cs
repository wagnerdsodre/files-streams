using static System.Console;
//Criando um path combinado
//var path = Path.Combine(Environment.CurrentDirectory , "file.txt");
//var path = Path.Combine(@"c:\temp" , "file.txt");

WriteLine("Escreva o nome do arquivo");
string nameTxt  = ReadLine();
nameTxt = validateName(nameTxt);


var path = Path.Combine(Environment.CurrentDirectory,$"{nameTxt}.txt");
CreatedText(path);

WriteLine("Aperte qualquer tecla para fechar !");
ReadLine();


static  void  CreatedText(string path){
try
{
using var fc = File.CreateText(path);
fc.WriteLine("Este é um arquivo de texto da linha 1");
fc.WriteLine("Este é um arquivo de texto da linha 2");
fc.WriteLine("Este é um arquivo de texto da linha 3");
fc.WriteLine("Este é um arquivo de texto da linha 4");
fc.Flush();
    
}
catch (System.Exception)
{
    
    WriteLine("O nome do arquivo é inválido!");
}


}

static string validateName (string name){
    
//ex: Documentação 02/03/2022 out Documentação 02-03-2022
//ex: Documentação 02/03/2022 out Documentação 02-03-2022

    foreach (var @char in Path.GetInvalidFileNameChars())
{
    name = name.Replace(@char,'-');
}
     return name;

}

