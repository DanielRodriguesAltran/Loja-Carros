
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe51
{
    class Program
    {
        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();

        static void Main(string[] args)
        {

            int op = 0;
            //Inicializar marcas
            Marca marcaV = new Marca(1001, "Volkswagem", "Alemanha");
            Marca marcaG = new Marca(1002, "General Motors", "Estados Unidos");

            //Inicializar carros
            Carro carro = new Carro(101, "Fusca", 1980, 5000.00, marcaV);
            marcaV.addCarro(carro);
            Carro carro1 = new Carro(102, "Golf", 2016, 60000.00, marcaV);
            marcaV.addCarro(carro1);
            Carro carro2 = new Carro(103, "Fox", 2017, 30000.00, marcaV);
            marcaV.addCarro(carro2);
            Carro carro3 = new Carro(104, "Cruze", 2016, 30000.00, marcaG);
            marcaG.addCarro(carro3);
            Carro carro4 = new Carro(105, "Cobalt", 2015, 25000.00, marcaG);
            marcaG.addCarro(carro4);
            Carro carro5 = new Carro(106, "Cobalt", 2017, 35000.00, marcaG);
            marcaG.addCarro(carro5);
            Acessorio acessorio = new Acessorio("Engate", 200.00);
            Acessorio acessorio1 = new Acessorio("Antena", 100.00);

            carro4.Acessorios.Add(acessorio);
            carro4.Acessorios.Add(acessorio1);

            marcas.Add(marcaV);
            marcas.Add(marcaG);

            carros.Add(carro);
            carros.Add(carro1);
            carros.Add(carro2);
            carros.Add(carro3);
            carros.Add(carro4);
            carros.Add(carro5);



            while (op != 7)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo à nossa loja");
                Console.WriteLine("1-Listar marcas");
                Console.WriteLine("2-Listar carros de uma marca ordenadamente");
                Console.WriteLine("3-Cadastrar marca");
                Console.WriteLine("4-Cadastrar carro");
                Console.WriteLine("5-Cadastrar acessorio");
                Console.WriteLine("6-Mostrar detalhes de um carro");
                Console.WriteLine("7-Sair");

                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro" + e.Message);
                    op = 0;
                }
                switch (op)
                {
                    case 1:
                        Console.WriteLine("LISTAGEM DE MARCAS:");
                        foreach (Marca m in marcas)
                        {
                            Console.WriteLine(m);
                        }
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Digite o código da marca: ");
                        int cod;
                        try
                        {
                            cod = int.Parse(Console.ReadLine());
                            int pos = marcas.FindIndex(x => x.codigo == cod);
                            if (pos == -1)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine("Carros da marca " + marcas[pos].nome + ":");
                            List<Carro> lista = marcas[pos].carros;
                            foreach (Carro c in lista)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro" + e.Message);

                        }
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Digite os dados da marca: ");

                        try
                        {
                            Console.Write("Código: ");
                            int codMarca = int.Parse(Console.ReadLine());
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("País de origem: ");
                            string pais = Console.ReadLine();

                            Marca m = new Marca(codMarca, nome, pais);
                            marcas.Add(m);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro" + e.Message);
                            break;
                        }
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Digite os dados do Carro: ");

                        try
                        {
                            Console.Write("Marca(código) : ");
                            int codMarca1 = int.Parse(Console.ReadLine());
                            Console.Write("Código do Carro: ");
                            int codCarro = int.Parse(Console.ReadLine());
                            Console.Write("Modelo: ");
                            string modelo = Console.ReadLine();
                            Console.Write("Ano: ");
                            int ano = int.Parse(Console.ReadLine());
                            Console.Write("Preço básico: ");
                            double preço = double.Parse(Console.ReadLine());
                            int posicao = marcas.FindIndex(x => x.codigo == codMarca1);
                            Marca m;
                            if (posicao != -1)
                            {
                                m = marcas[posicao];
                            }
                            else
                            {
                                break;
                            }
                            Carro carroNovo = new Carro(codCarro, modelo, ano, preço, m);
                            m.addCarro(carroNovo);
                            carros.Add(carroNovo);


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro" + e.Message);
                            break;
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        //Cadastrar Acessorio
                        Console.WriteLine("Digite os dados do acessorio: ");

                        try
                        {
                            Console.Write("Carro (código) : ");
                            int codCarro = int.Parse(Console.ReadLine());
                            Console.Write("Descrição: ");
                            string descricao = Console.ReadLine();
                            Console.Write("Preço: ");
                            double preco = double.Parse(Console.ReadLine());

                            Acessorio ac = new Acessorio(descricao, preco);
                            int posicao = carros.FindIndex(x => x.Codigo == codCarro);
                            Carro c;
                            if (posicao != -1)
                            {
                                c = carros[posicao];
                            }
                            else
                            {
                                break;
                            }
                            c.Acessorios.Add(ac);



                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro" + e.Message);
                            break;
                        }

                        Console.ReadLine();
                        break;
                    case 6:
                        try
                        {
                            Console.Write("Carro (código) : ");
                            int codCarro = int.Parse(Console.ReadLine());
                            int posicao = carros.FindIndex(x => x.Codigo == codCarro);
                            if (posicao == -1)
                            {
                                Console.WriteLine("Código de carro não encontrado: " + codCarro);
                            }
                            Carro c = carros[posicao];

                            Console.WriteLine(c);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro " + e.Message);
                        }
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Fim do programa!");
                        break;

                }
            }

        }
    }
}
