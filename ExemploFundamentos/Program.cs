
//  using ExemploFundamentos.Common.Models;

//  Pessoa pessoa1 = new Pessoa();

//  pessoa1.Nome = "Buta";
//  pessoa1.Idade = 26;
//  pessoa1.Apresentar();
//*****************************
//convertendo variaveis CASTING

// int a = int.Parse("5");

//Parse permite null na variabel
//int a = int.Parse(null);

//convert Aceita null na variavel
//int a = Convert.ToInt32(null);

// int inteiro = 5;
// string a = inteiro.ToString();

//  Console.WriteLine(a);
//****************************

/*
*********************************
//Try Parse para tentar convertir e se nao tiver como retorna alguma coisa

string a = "15-";

int b = 0;

//try parse a a integer se nao retornar b
int.TryParse(a, out b);

Console.WriteLine(b);
***************************************************
*/


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case var inputted when "aeiou".Contains(inputted):

//     Console.WriteLine("Vogal");
//     break;

//     default:

//     Console.WriteLine("Não é uma vogal");
//     break ;
// }

//exemplo do while
// int numero = 0;
// do 
// {
// Console.WriteLine("Digiute un numero (0 para parar)");
// numero = Convert.ToInt32(Console.ReadLine());

// }while(numero != 0);


//Fazendo menu

// string opcao;
// bool exibirMenu = true;
// while (exibirMenu)
// {
    
//     Console.WriteLine("***\nDigite sua opção:\n1 - Cadastrar cliente\n2 - Buscar cliente\n3 - Apagar cliente\n4 - Encerrar\n***");
//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
       
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Buscar de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false; 
//             break;

//         default:
//             Console.WriteLine("Opção invalida");
//             break;

//     }
    
// }


// int[] arrayInteiros = new int[4] { 72, 64, 50, 1 };

// int [] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arrayInteirosDobrado, 2);



// int contadorInteiros = 0;
// int contadorInteirosDobrado = 0;
// foreach (int valor in arrayInteiros)
// {
    
// Console.WriteLine($"ArrayInteiros Valor:, {valor}. - Posição {contadorInteiros}");

// contadorInteiros++;
// } 

// foreach (int valor in arrayInteirosDobrado)
// {
    
// Console.WriteLine($"ArrayDobrados Valor:, {valor}. - Posição Dobrados {contadorInteirosDobrado}");

// contadorInteirosDobrado++;
// } 

//********************************
//Listas

// List<string> listaString = new List<string>();
// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");



// for (int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição {i} - Estado {listaString[i]}");
// }


//**
//Desafio de conding the future Avanade Saque de dinero ejemplo

        // int saldoTotal = int.Parse(Console.ReadLine());
        
        // int valorSaque = int.Parse(Console.ReadLine());

        
        // //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
        
        // if( saldoTotal >=  valorSaque)
        // {
        //     int saldo = saldoTotal-valorSaque;
        //     Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldo}");
        // }

        // else
        // {
        //     Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        // }

  //Desafio de conding the future Avanade lista de items
    //  // Lista para armazenar os itens
    //     List<string> itens = new List<string>();
        

    //     // TODO: Solicite os itens ao usuário
    //     for (int i =  0; i < 3; i++)
    //     {
    //         Console.WriteLine($"Digite o nome do item numero - {i + 1}" );

    //         string itemName = Console.ReadLine();
    //         itens.Add( itemName );
            
    //     }

    //     // Exibe a lista de itens
    //     Console.WriteLine("Lista de itens:");
    //     foreach (string item in itens)
    //     {
    //         Console.WriteLine($"- {item}");
    //     }

    //Desafio de conding the future Avanade Sistema para um estascionamiento C#