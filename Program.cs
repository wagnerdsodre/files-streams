    using static System.Console;

    static void Demo1()
    {
        //Criando um path combinado
        //var path = Path.Combine(Environment.CurrentDirectory , "file.txt");
        //var path = Path.Combine(@"c:\temp" , "file.txt");

        WriteLine("Escreva o nome do arquivo");
        string nameTxt = ReadLine();
        nameTxt = validateName(nameTxt);


        var path = Path.Combine(Environment.CurrentDirectory, $"{nameTxt}.txt");
        CreatedText(path);

        WriteLine("Aperte qualquer tecla para fechar !");
        ReadLine();


        static void CreatedText(string path)
        {
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

        static string validateName(string name)
        {

            //ex: Documentação 02/03/2022 out Documentação 02-03-2022
            //ex: Documentação 02/03/2022 out Documentação 02-03-2022

            foreach (var @char in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(@char, '-');
            }
            return name;

        }

    }

    CriarDirectory();
    CriarArquivo();
   

    var origin = Path.Combine(Environment.CurrentDirectory, "SucoDeUva.txt");
    var destiny = Path.Combine(Environment.CurrentDirectory, "Sucos", "Uva", "SucoDeUva.txt");
    MoveFiles(origin, destiny);
     

    static void CopyFiles(string pathOrigin, string pathDestiny){
        if(!File.Exists(pathOrigin)){
        WriteLine("Arquivo de origem não existe");
        return;
        }

        if(File.Exists(pathDestiny)){
        WriteLine("Arquivo já existe na pasta do destino");
        return;
        }
        File.Copy(pathOrigin, pathDestiny);
        CopyFiles(pathOrigin, pathDestiny); 
    }



    static void MoveFiles(string pathOrigin, string pathDestiny)
    {
        if(File.Exists(pathOrigin)){
        WriteLine("Arquivo já existe na origem");
        return;
        }

        if(File.Exists(pathDestiny)){
        WriteLine("Arquivo já existe na pasta do destino");
        return;
        }

        File.Move(pathOrigin, pathDestiny);
             

    }



    static void CriarArquivo()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "SucoDeUva.txt");
        if (!File.Exists(path))
        {
            using var sw = File.CreateText(path);
            sw.WriteLine("Engredientes para o Suco:");
            sw.WriteLine("1 - 500ml de Nectar de uva");
            sw.WriteLine("2 - 500ml de água");
            sw.WriteLine("2 - 50g de açúcar");
            sw.Flush();
        }
    }



    static void CriarDirectory()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "receitas");
        if (!Directory.Exists(path))
        {
                var diretory = Directory.CreateDirectory(path);
                var subBolo = diretory.CreateSubdirectory("Bolo");
                var subBrig = diretory.CreateSubdirectory("Brigadeiro");
                var subPudin = diretory.CreateSubdirectory("Pudin");

            var pathSuco = Path.Combine(Environment.CurrentDirectory, "Sucos");
            var diretorySucos = Directory.CreateDirectory(pathSuco);
            var subAce = diretorySucos.CreateSubdirectory("Acerola");
            var subLar = diretorySucos.CreateSubdirectory("Laranja");
            var subUva = diretorySucos.CreateSubdirectory("Uva");
        }


    }









