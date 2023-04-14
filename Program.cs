////////////////////Exercício 1-sem static////////////////////


// int year = DateTime.Now.Year;

// Console.WriteLine($"Informe o ano que você nasceu");
// int dataDeNascimento = int.Parse(Console.ReadLine());

// int idade = (year - dataDeNascimento);
// if (idade <= 17)
// {
//     Console.WriteLine($"O usuário não tem idade para votar");
// }
// else
// {
//     Console.WriteLine($"O usuário já possui a idade para votar");
// }


////////////////////Exercício 2-sem static////////////////////
// char a;
// char g;

// Console.WriteLine(@$"                                       
// //                                                                         ------------------------------
// //                                                                         | Escolha um combustivel     |
// //                                                                         | Álcool = a                 |
// //                                                                         | Gasolina = g               |
// //                                                                         ------------------------------
// ");

// char combustivel = char.Parse(Console.ReadLine().ToLower());
// float quantidade = 0;

// switch (combustivel)
// {
//     case 'a':

//         Console.WriteLine($"Quantos litros serão colocados no veículo?");
//         quantidade = float.Parse(Console.ReadLine().ToLower());
//         if (quantidade <= 20)
//         {
//             Console.WriteLine($"O desconto total é igual à {((quantidade * 4.90f) / 100) * 3} reais");
//         }
//         else
//         {
//             Console.WriteLine($"O desconto total é igual à {((quantidade * 4.90f) / 100) * 5} reais");
//         }
//         break;

//     case 'g':

//         Console.WriteLine($"Quantos litros serão colocados no veículo?");
//         quantidade = float.Parse(Console.ReadLine().ToLower());
//         if (quantidade <= 20)
//         {
//             Console.WriteLine($"O desconto total é igual à {((quantidade * 5.30f) / 100) * 4}");
//         }
//         else
//         {
//             Console.WriteLine($"O desconto total é igual à {((quantidade * 5.30f) / 100) * 6}");
//         }
//         break;
//     default:
//         Console.WriteLine($"Não é possivel entender qual o combustível foi escolhido");
//         break;
// }
// : {Math.Round(salario, 2).ToString("C", new CultureInfo("pt-BR"))}
// Valor do Imposto: {Math.Round(impostoDevido, 2)}");


////////////////////Exercício 2-com static////////////////////
static float Alcool(float quantidade, float preco)
{
    if(quantidade <= 20)
    {
        return (quantidade * preco) * 0.97f;
    }
    else
    {
        return (quantidade * preco) * 0.95f;
    }
}
static float Gasolina(float quantidade, float preco)
{
    if(quantidade <= 20)
    {
        return (quantidade * preco) * 0.96f;
    }
    else
    {
        return (quantidade * preco) * 0.94f;
    }
}
 
const float precoAlcool = 4.90f;
const float precoGasolina = 5.30f;

float quantidadeAlcool;
float quantidadeGasolina;

float valorAbastecimento;

// Console.WriteLine(@$"                                       
// //                                                                         ------------------------------
// //                                                                         | Escolha um combustivel     |
// //                                                                         | Álcool = a                 |
// //                                                                         | Gasolina = g               |
// //                                                                         ------------------------------
// ");

char opcao = char.Parse(Console.ReadLine());

switch(opcao)
{
    case 'a':
    Console.WriteLine($"Informe a quantidade de litros: ");
    quantidadeAlcool = float.Parse(Console.ReadLine());
    valorAbastecimento = Alcool(quantidadeAlcool, precoAlcool);
    Console.WriteLine($"O valor a ser pago é {valorAbastecimento}");
    break;
    case 'g':
    Console.WriteLine($"Informe a quantidade de litros: ");
    quantidadeGasolina = float.Parse(Console.ReadLine());
    valorAbastecimento = Gasolina(quantidadeGasolina, precoGasolina);
    Console.WriteLine($"O valor a ser pago é {valorAbastecimento}");
    break;
}


////////////////////Exercício 3////////////////////

// Console.WriteLine(@$"                                       
//     //                                                    -----------------------------------------------------------------------
//     //                                                    | Escolha um produto da loja                                          |
//     //                                                    | Leite Quatá Integral 1 Litro.................................R$ 4,77|
//     //                                                    | Manteiga Aviação Pote com Sal 200g..........................R$ 12,55|
//     //                                                    | Batavo Requeijão Cremoso Com Queijo 400g....................R$ 13,20|
//     //                                                    | Queijo Gouda Quatá 200g.....................................R$ 10,50|
//     //                                                    | Sorvete de Chocolate Fudge Brownie BEN&JERRYS Pote 458ml.....R$43,99|
//     //                                                    -----------------------------------------------------------------------
//     ");

// char produtoEscolhido = char.Parse(Console.ReadLine().ToLower());

// Console.WriteLine($"Com base no valor unitário, escolha quantos elementos serão levados: ");
// double quantidadeAdquirida = double.Parse(Console.ReadLine().ToLower());
// Console.WriteLine($"Com base no produto, diga o seu preço: ");
// double preço = double.Parse(Console.ReadLine().ToLower());
// double total = quantidadeAdquirida* preço;
// double desconto = 0;

// if (quantidadeAdquirida <= 5)
// {
//     Console.WriteLine($"O total adquirido é: {total} reais");
//     Console.WriteLine($"Entretanto devido ao desconto o total à ser pago é: {total - (desconto = total * 0.02)} reais");

// }
// else if (quantidadeAdquirida > 5 && quantidadeAdquirida<=10)
// {
//     Console.WriteLine($"O total adquirido é: {total} reais");
//     Console.WriteLine($"Entretanto devido ao desconto o total à ser pago é: {total - (desconto = total * 0.03)} reais"); 
// }
// else
// {
//     Console.WriteLine($"O total adquirido é: {total} reais");
//     Console.WriteLine($"Entretanto devido ao desconto o total à ser pago é: {total - (desconto = total * 0.05)} reais"); 
// }


////////////////////Exercício 4-nao terminado////////////////////
// // entrada:
// int[] numero = new int[10];
// //processamento:
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Informe o {i + 1}º número: ");    
//     numero[i] = int.Parse(Console.ReadLine());

// // saída:
// int[] numero = new int[1];
// Console.WriteLine($"O maior número apresentado foi: {numero.Min()}");
// }


////////////////////Exercício 4-terminado////////////////////

// int[] valores = new int[10];
// int maior = 0; 
// int menor = 0;

// for (int i = 0; i < 10; i++) {
//     Console.Write($"Digite o {i+1}º valor: ");
//     valores[i] = int.Parse(Console.ReadLine());

//     if (i == 0) {
//           maior = valores[i];
//           menor = valores[i];
//      }
//      else {
//            if (valores[i] > maior) {
//                maior = valores[i];
//            }
//                if (valores[i] < menor) {
//                menor = valores[i];
//            }
//           }
//         }

// Console.WriteLine($"Maior valor: {maior}");
// Console.WriteLine($"Menor valor: {menor}");




////////////////////Exercício 5////////////////////
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"Tabuada do " + i + ":");

//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine(i + "x" + j + " = " + (i * j));

//     }
//     Console.WriteLine();
// }


////////////////////Exercício 6////////////////////
// // entrada:
// string[] nome = new string[10];
// //processamento:
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Informe a nome da {i + 1}º pessoa: ");
//     nome[i] = Console.ReadLine().ToLower();
// }

// // saída:
// Console.WriteLine($"Os nomes apresentados foram: ");
// for (var i = 0; i < 10; i++)
// {
//     Console.WriteLine($"{i + 1}º nome: {nome[i]}");
// }

// Console.WriteLine($"Agora diga outro nome: ");
// string decimoPrimeiroNome = Console.ReadLine().ToLower();

// for (var i = 0; i < 10; i++)
// {
//     if (decimoPrimeiroNome == nome[i])
//     {
//         Console.WriteLine($"O nome foi achado");
//     }

//     else
//     {
//         Console.WriteLine($"ACHEI!!!");
//     }
// }

////////////////////Exercício 7////////////////////
// // entrada:
// int[] numero = new int[15];
// //processamento:
// for (int i = 0; i < 15; i++)
// {
//     Console.WriteLine($"Informe o {i + 1}º número: ");    
//     numero[i] = int.Parse(Console.ReadLine());
// }
// // saída:
// Console.WriteLine($"Os números apresentados foram: ");
// for (var i = 14; i >= 0; i--)
// {
//     Console.WriteLine($"{i + 1}º numero: {numero[i]}");
// }
