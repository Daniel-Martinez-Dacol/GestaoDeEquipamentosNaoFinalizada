using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string menuDeOpcoes;
            string menuEdicao = "";
            int adicionarEquipamento = 0;

            //Criação do Equipamento:
            string[] nomeDoEquipamento = new string[1000];
            decimal[] precoDoEquipamento = new decimal[1000];
            string[] numeroDeSerie = new string[1000];
            string[] dataDeFabricacao = new string[1000];
            string[] fabricante = new string[1000];


            do
            {
                Console.WriteLine("-Digite 1: para cadatrar um novo equipamento.\n-Digite 2: Editar um produto do inventario\n-Digite 3: Para Excluir um equipamento.\n-Digite 4: Para encerrar.");
                menuDeOpcoes = Console.ReadLine();

                #region Addicionando novo produto:

                if (menuDeOpcoes == "1")
                {
                    //nome do Equipamento:

                    Console.Write("-Digite o nome do Equipamento:");
                    nomeDoEquipamento[adicionarEquipamento] = Console.ReadLine();
                    Console.WriteLine();

                    //Preço do Equipamento:

                    Console.Write("-Digite o preço do Equipamento:");
                    precoDoEquipamento[adicionarEquipamento] = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //O numero de serie do equipamento:

                    Console.Write("-Digite o numero de série do Equipamento:");
                    numeroDeSerie[adicionarEquipamento] = Console.ReadLine();
                    Console.WriteLine();

                    //A data de fabricação:

                    Console.Write("-Digite a data de fabricação do Equipamento:");
                    dataDeFabricacao[adicionarEquipamento] = Console.ReadLine();
                    Console.WriteLine();

                    //O nome do fabricante;

                    Console.Write("-Digite o nome do fabricante do Equipamento:");
                    fabricante[adicionarEquipamento] = Console.ReadLine();
                    Console.WriteLine();

                    adicionarEquipamento++;
                }
                Console.WriteLine(adicionarEquipamento);
                Console.WriteLine($"\n{nomeDoEquipamento[0]} - {precoDoEquipamento[0]} - {numeroDeSerie[0]} - {dataDeFabricacao[0]} - {fabricante[0]}");

                #endregion

                #region Editar Produto:
                if (menuDeOpcoes == "2")
                {
                    Console.Write("Digite o nome do equipamento que sera editado: ");
                    string edicaoDeEquipamento = Console.ReadLine();

                    if ("AQUI TA  O PROBLEMA")
                    {
                        Console.WriteLine("-Digite 1: Para editar o nome do equipamento\n-Digite 2: Para editar o preço do equipamento\n" +
                                "-Digite 3: Para editar o numero de serie do equipamento\n-Digite 4: Para editar a data de fabricação do equipamento\n" +
                                "-Digite 5: Para editar o fabricante\n-Digite 6: para encerrar a edição do equipamente.");
                        do
                        {
                            

                            if (menuEdicao == "1")

                            {
                                int valor = Array.IndexOf(nomeDoEquipamento,nomeDoEquipamento.Equals(edicaoDeEquipamento));
                                Console.Write("Digite o novo nome do equipamento:");
                               nomeDoEquipamento[valor] = Console.ReadLine();
                                

                            }
                            else if (menuEdicao == "2")
                            {

                            }
                            else if (menuEdicao == "3")
                            {

                            }
                            else if (menuEdicao == "4")
                            {

                            }
                            else if (menuEdicao == "5")
                            {

                            }

                        } while (menuEdicao != "6");
                    }
                }
                #endregion
            } while (menuDeOpcoes != "4");
        }
    }
}
