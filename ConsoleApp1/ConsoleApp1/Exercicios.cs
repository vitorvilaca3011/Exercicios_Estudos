using ConsoleApp1;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace PrimeiroProjeto
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            //Exe1(); correto
            //Exe2(); correto
            //Exe3(); correto
            //Exe4(); correto
            //Exe5(); correto
            //Exe6(); correto
            //Exe7(); correto
            //Exe8(); n sei matematica, pai é burro

            //Estrutura Condicional---------------------

            //Exe9(); correto
            //Exe10(); correto
            //Exe11(); correto, porem diferente
            //Exe12(); tendi nada , so depois de ler o codigo exemplo
            //Exe13(); correto , pai é genio  
            //Exe14(); correto
            //Exe15(); correto
            //Exe16(); derretimento cerebral , tendi nada.

            // Estrutura Repetitiva While

            //Exe17(); correto
            //Exe18(); correto porem diferente pro lado burro da força
            //Exe19(); correto , father is genius

            // Estrutura Repetitiva For

            //Exe20(); n entendi o calculo ali nao kkkkkkkkkk 
            //Exe21(); correto 
            //Exe22(); logica correta , só n sabia q porra era peso???? era multiplicaçao do numero pelo peso (??????)  
            //Exe23(); correto, diferenças de preferencia no codigo 
            //Exe24(); tendi porra nenhumakkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            //Exe25(); sla mano nao sei como q isso funciona kkkkkkkkk
            //Exe26(); acertei a logica , errei 1 chr era pra usar o i ao inves do N

            // Usando classes

            //Exe27(); correto
            //Exe28(); correto
            //Exe29(); correto
            //Exe30(); correto
            //Exe31(); 95% correto, errei so no aumentarsalario esqueci de aumentar o salariobruto com a porcentagem
            //Exe32(); correto
            //Exe33(); usando classe com static, eu nao entendi pra falar a vdd kkkk

            //Construtores,this,sobrecarga

            //Exe34(); funcionou , mas nao estava 100% clean code

            //Array, Listas

            //Exe35(); funciona , meu codigo ta diferente, porem funcionou igual 
            //Exe36(); fiquei meio confuso com a parada de list, confesso, tendo que declarar o employee nao pegando os dados e so para achar a id, achei confuso pra crl,nsei se realmente é assim que seria usado em um sistema de verdade
            //Exe37(); fiz 90% do codigo e os outros 10% eu n tinha ideia de como fazer e depois de ver a resposta eu nao saberia nem fudendo

            //Exercicios Aleátorios

            //Exe38(); correto
            //Exe39(); nem sabia oq era palindromo, e nem entendi a conta, mas funcionou
            //Exe40(); correto
            //Exe41(); correto
            //Exe42(); correto
            Exe43();
            Exe44();
            Exe45();
        }
        
        
        static void Exe1()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} , cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2} ,  cujo preço é {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            Console.WriteLine($"Arrendondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }

        #region Estrutura Sequencial
        // Estrutura Sequencial
        static void Exe2()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartosQuantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preçoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = (vet[0]);
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");

            Console.WriteLine(nome);
            Console.WriteLine(quartosQuantidade);
            Console.WriteLine(preçoProduto.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }

        static void Exe3() 
        {
            Console.WriteLine("Insira o 1 numero");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2 numero");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine($"A soma de {a} e {b} = {soma}");
        }
        
        static void Exe4()
        {
            double pi = 3.14159;
            double raio;

            Console.WriteLine(pi);
            Console.WriteLine("Insira o valor do raio");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A area de {raio} é: ");
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }

        static void Exe5()
        {
            int a, b, c, d;
            
            a = int.Parse(Console.ReadLine());
            
            b = int.Parse(Console.ReadLine());
            
            c = int.Parse(Console.ReadLine());
            
            d = int.Parse(Console.ReadLine());

            int diff = (a * b - c * d);

            Console.WriteLine(diff); 
        }    
        
        static void Exe6()
        {
            int userNumber, hW;
            double salary;

            
            Console.WriteLine("Insira o numero de funcionario: ");
            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de horas trabalhadas: ");
            hW = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o salário do funcionario?(em horas)");
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Numero = {userNumber}");
            
            salary = hW * salary;

            Console.WriteLine("Salário = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        static void Exe7() 
        {
            Console.WriteLine("Insira o código da peca, a quantidade, e preço(mesma linha)");
            
            string[] vet1 = Console.ReadLine().Split(' ');

            int codigopeca1 = int.Parse(vet1[0]);
            int pecaQuantidade1 = int.Parse(vet1[1]);
            double precoPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine(" ");
            
            Console.WriteLine("Insira o código da peca, a quantidade, e preço(mesma linha)");

            string[] vet2 = Console.ReadLine().Split(' ');

            int codigopeca2 = int.Parse(vet2[0]);
            int pecaQuantidade2 = int.Parse(vet2[1]);
            double precoPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            double precoFinal = (pecaQuantidade1 * precoPeca1) + (pecaQuantidade2 * precoPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
        
        static void Exe8()
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
        #endregion
        #region Estrutura Condicional
        //Estrutura Condicional 

        static void Exe9() 
        {
            Console.WriteLine("Insira um número inteiro:");
            int x = int.Parse(Console.ReadLine());
            
            
            if(x < 0) 
            {
                Console.WriteLine("Esse numero é negativo.");
            }
            else
            {
                Console.WriteLine("Esse numero nao é negativo.");
            }
            


        }

        static void Exe10()
        {
            Console.WriteLine("Insira um numero inteiro:");
            
            int x = int.Parse(Console.ReadLine());
            
            if(x % 2 == 0) 
            {
                Console.WriteLine("Esse numero é par.");
            }
            else 
            {
                Console.WriteLine("Esse numero é impar.");
            }
        }

        static void Exe11()
        {
            int A, B;

            Console.WriteLine("Insira dois numeros inteiros: ");
            
            string[] numeros = Console.ReadLine().Split(' ');
            A = int.Parse(numeros[0]);
            B = int.Parse(numeros[1]);

            if (A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao Sao Multiplos");
            }
        }

        static void Exe12()
        {
            Console.WriteLine("Que horas o jogo iniciou, e que horas terminou?");

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");


        }

        static void Exe13()
        {
            Console.WriteLine("Insira o código do item, e a quantidade");

            string[] vet1 = Console.ReadLine().Split(' ');

            int codigoItem = int.Parse(vet1[0]);
            int itemQuantidade = int.Parse(vet1[1]);
            double precoItem = 0.0;
            double precoTotal = 0.0;

            if (codigoItem == 1)
            {
                precoItem = 4.00;
                Console.WriteLine($"voce pediu {itemQuantidade} Cachorro Quente");
                Console.WriteLine(" ");
                precoTotal = precoItem * itemQuantidade;
                Console.WriteLine("Total a pagar: R$ " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 2)
            {
                precoItem = 4.50;
                Console.WriteLine($"voce pediu {itemQuantidade} X-Salada");
                Console.WriteLine(" ");
                precoTotal = precoItem * itemQuantidade;
                Console.WriteLine("Total a pagar: R$ " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 3)
            {
                precoItem = 5.00;
                Console.WriteLine($"voce pediu {itemQuantidade} X-Bacon");
                Console.WriteLine(" ");
                precoTotal = precoItem * itemQuantidade;
                Console.WriteLine("Total a pagar: R$ " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 4)
            {
                precoItem = 2.00;
                Console.WriteLine($"voce pediu {itemQuantidade} Torrada Simples");
                Console.WriteLine(" ");
                precoTotal = precoItem * itemQuantidade;
                Console.WriteLine("Total a pagar: R$ " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                precoItem = 1.50;
                Console.WriteLine($"voce pediu {itemQuantidade} Refrigerante");
                Console.WriteLine(" ");
                precoTotal = precoItem * itemQuantidade;
                Console.WriteLine("Total a pagar: R$ " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        static void Exe14()
        {
            Console.WriteLine("Insira o valor desejado:");

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(valor >= 0.00 && valor <= 25.00) 
            {
                Console.WriteLine("Intervalo 0, 25");
            }
            else if (valor >= 25.00 && valor <= 50.00)
            {
                Console.WriteLine("Intervalo 25, 50");
            }
            else if (valor >= 50.00 && valor <= 75.00)
            {
                Console.WriteLine("Intervalo 50, 75");
            }
            else if (valor >= 75.00 && valor <= 100.00)
            {
                Console.WriteLine("Intervalo 75, 100");
            }
            else
            {
                Console.WriteLine("Fora de Intervalo");
            }
        }

        static void Exe15()
        {
            Console.WriteLine("Insira 2 valores com uma casa decimal :");
            
            string[] valores = Console.ReadLine().Split(' ');

            double X = double.Parse(valores[0]);
            double Y = double.Parse(valores[1]);

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X >= 0.1 && Y >= 0.1)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0.0 && Y >= 0.1)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (X >= 0.1 && Y < 0.0)
            {
                Console.WriteLine("Q4");
            }


        }

        static void Exe16()
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
        #endregion
        #region Estrutura Repetitiva While
        // Estrutura Repetitiva While

        static void Exe17()
        {
            Console.WriteLine("Insira sua senha:");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) 
            {
                Console.WriteLine("Senha Incorreta");
                Console.WriteLine("Insira sua senha novamente:");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido.");
        }
        static void Exe18()
        {
            Console.WriteLine("Insira 2 valores :");

            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            while (X > 0 || X < 0 && Y > 0 || X < 0)
            {
                if (X >= 1 && Y >= 1)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (X <= -1 && Y >= 1)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (X <= -1 && Y <= -1)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (X >= 1 && Y <= -1)
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                Console.WriteLine("Insira 2 valores novamente:");

                valores = Console.ReadLine().Split(' ');

                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
            }

            Console.WriteLine("Finalizado");
        }
        static void Exe19()
        {
            Console.WriteLine("Insira o combustivel de sua preferencia:");
            Console.WriteLine(" ");
            Console.WriteLine("1. Alcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Sair do programa");
            Console.WriteLine(" ");

            int combustivelAbastecido = int.Parse (Console.ReadLine());

            int alcool = 0, gasolina = 0, diesel = 0;

            while (combustivelAbastecido != 4)
            {

                if (combustivelAbastecido > 4 || combustivelAbastecido < 1)
                {
                    Console.WriteLine("Insira um numero válido:");
                    Console.WriteLine(" ");

                    combustivelAbastecido = int.Parse(Console.ReadLine());
                }

                if (combustivelAbastecido == 1)
                {
                    alcool++;
                }
                else if(combustivelAbastecido == 2) 
                {
                    gasolina++;
                }
                else
                {
                    diesel++;
                }
                
                Console.WriteLine("Insira o combustivel de sua preferencia:");
                Console.WriteLine(" ");
                Console.WriteLine("1. Alcool");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Sair do programa");
                Console.WriteLine(" ");

                combustivelAbastecido = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            
        }
        #endregion
        #region Estrutura Repetitiva For
        // Estrutura Repetitiva For
        static void Exe20()
        {
            Console.WriteLine("Escreva um numero pra saber os impares de 1 até o numero desejado: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }    
        static void Exe21()
        {
            Console.WriteLine("Insira quantos numeros serao lidos: ");
            int N = int.Parse(Console.ReadLine());

            int OUT = 0, IN = 0;
            
            for (int i = 1;i <= N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) 
                {
                    IN++;
                }
                else
                {
                    OUT++;
                }   
            }
            Console.WriteLine(IN + " in");
            Console.WriteLine(OUT + " out");

        }
        static void Exe22()
        {
            Console.WriteLine("Insira quantos numeros serao lidos: ");
            int N = int.Parse(Console.ReadLine());

            
            for(int i = 1; i <= N; i++) { 
                Console.WriteLine("Insira os valores: ");
    
                string[] valores = Console.ReadLine().Split(' ');

                double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;


                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            
            
        }
        static void Exe23()
        {
            Console.WriteLine("insira um numero:");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1;i <= N; i++)
            {
                Console.WriteLine("Insira um par de numeros");

                string[] parNumero = Console.ReadLine().Split(' ');
                double numero1 = double.Parse(parNumero[0]);
                double numero2 = double.Parse(parNumero[1]);

                double divisao = 0.0;

                if (numero2 != 0)
                {
                    divisao = numero1 / numero2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else 
                {
                    Console.WriteLine("Divisao Impossivel");
                }
                

            }
        }
        static void Exe24()
        {
            Console.WriteLine("insira um numero:");
            int N = int.Parse(Console.ReadLine());

            int fat = 1;
            for(int i = 1;  i <= N; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);    
            
        }
        static void Exe25()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Exe26()
        {
            int N = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine(i.ToString() + Math.Pow(i, 2) + Math.Pow(i, 3));
            }
        }
        #endregion
        #region Usando Classes
        // Classes 
        static void Exe27()
        {
            Console.WriteLine("Dados da primeira pessoa:");

            Pessoa pessoa1, pessoa2;
            
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());
            
            if(pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("");
                Console.WriteLine(pessoa1.nome + " é mais velha que " + pessoa2.nome);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine(pessoa2.nome + " é mais velha que " + pessoa1.nome);
            }
        }

        static void Exe28()
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionario:");

            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            pessoa1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");

            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarios = (pessoa1.salario + pessoa2.salario) / 2;
            
            Console.WriteLine("");
            Console.WriteLine("A media do salario é : " + mediaSalarios.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        static void Exe29()
        {
            Produto produto = new Produto();
            
            Console.WriteLine("Entre os dados do Produto");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto:" + produto);

            Console.WriteLine();
            
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + produto);

            Console.WriteLine();
            
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + produto);
        }
        
        static void Exe30()
        {
            Retangulo rtg = new Retangulo();
            
            Console.WriteLine("Entre a largura e altura do retangulo:");

            Console.WriteLine("");
            
            Console.Write("Insira a largura:");
            rtg.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("");
            
            Console.Write("Insira a altura:");
            rtg.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + rtg.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + rtg.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + rtg.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
        }
        
        static void Exe31()
        {
            Funcionario funcionario = new Funcionario();
            
            Console.WriteLine("Insira os dados do funcionario: ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            
            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine("");
            
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("");
            
            Console.WriteLine("Dados Atualizados: " + funcionario);
        }
        
        static void Exe32()
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");

            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.SomaNotas();
            
            Console.WriteLine("Nota final: " + aluno.NotaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.NotaFinal >= 60.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                double PontosFaltando = 60.0 - aluno.NotaFinal;

                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + PontosFaltando.ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }

            
        }
        
        static void Exe33()
        {
            Console.Write("Qual a cotaçao do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
        #endregion
        #region Construtores, this, sobrecarga, encapsulamento
        //Construtores, this, sobrecarga, encapsulamento
        static void Exe34()
        {
            BankAccount bankAccount;
            
            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            
            if(resposta == char.Parse("s") || resposta == char.Parse("S")) 
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount = new BankAccount(accountNumber, name);
                bankAccount.AddBalance(initialDeposit);
                
                Console.WriteLine();
                
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(bankAccount);
                
                Console.WriteLine();
                
                Console.Write("Entre um valor para deposito: ");
                double Deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount.AddBalance(Deposit);

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(bankAccount);
                
                Console.WriteLine();

                Console.Write("Entre um valor para saque: ");
                double Withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount.WithdrawBalance(Withdraw);

                Console.WriteLine();
                
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(bankAccount);

            }
            
            else if(resposta == char.Parse("n") || resposta == char.Parse("N"))
            {
                bankAccount = new BankAccount(accountNumber, name);
                
                Console.WriteLine();
                
                Console.WriteLine("Dados da conta:" + bankAccount);

                Console.WriteLine();

                Console.Write("Entre um valor para deposito: ");
                double Deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount.AddBalance(Deposit);

                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(bankAccount);

                Console.WriteLine();

                Console.Write("Entre um valor para saque: ");
                double Withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount.WithdrawBalance(Withdraw);

                Console.WriteLine();

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(bankAccount);
            } 
            
        }
        #endregion
        #region Arrays, Listas, Matrizes
        //Arrays, Listas, Matrizes

        static void Exe35()
        {
            RentRooms[] vect = new RentRooms[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i < n; i++) 
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[i] = new RentRooms(name, email, room);
                Console.WriteLine();
            }

            Console.WriteLine("Busy Roms:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
        
        static void Exe36()
        {
            
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(Id, Name, Salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int I = int.Parse(Console.ReadLine());
            
            Employee employee = list.Find(x => x.Id == I);
            if (employee != null) 
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist.");
                Console.WriteLine("Update list of employees;");
                Console.WriteLine();
                foreach (Employee obj in list)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees;");
            Console.WriteLine();
            foreach (Employee obj in list) 
            {
                Console.WriteLine(obj);
            }
        }
        
        static void Exe37() 
        {
            Console.Write("quantidade de linhas: ");
            int M = int.Parse (Console.ReadLine());

            Console.Write("quantidade de colunas: ");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];
            
            for (int i = 0; i < M; i++) 
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(values[j]);

                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz criada.");
            Console.WriteLine();
            
            Console.Write("Insira o numero para saber numeros em sua volta: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0;  i < M; i++)
            {
                for (int j = 0; j < N; j++) 
                {
                    if (mat[i,j] == X) 
                    {
                        Console.WriteLine("Position " + i + ", " + j + ": " );
                        if ( j > 0)
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                        if(j < N - 1)
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                        if(i > 0)
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                        if(i < M -1)
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            } 
        }
        #endregion
        #region Exercicios Extras
        static void Exe38() 
        {
            Console.WriteLine("A soma de todos os multiplos de 3 a 5 abaixo de 1000");

            for(int i = 0; i <= 1000; i++) 
            {
                if (i % 3 == 0 || i % 5 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Exe39() 
        {
            Console.WriteLine("Insira um numero para saber se ele é um palíndromo");

            int numero = int.Parse(Console.ReadLine());

            void VerificaPalindromo(int numero) 
            {
                int numeroOriginal = numero;
                int numeroInvertido = 0;
                while (numero > 0) 
                {
                    int digito = numero % 10;
                    numeroInvertido = numeroInvertido * 10 + digito;
                    numero /= 10;
                }
                if (numeroOriginal == numeroInvertido) 
                {
                    Console.WriteLine("É um palíndromo");
                }
                else 
                {
                    Console.WriteLine("Não é um palíndromo");
                }
            }

            VerificaPalindromo(numero);

        }

        static void Exe40() 
        {
            Console.WriteLine("Insira um numero para imprimir sua tabuada:");

            int numero = int.Parse(Console.ReadLine());

            void ImprimirTabuada(int numero)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");

                }
            }

            ImprimirTabuada(numero);
        }

        static void Exe41()
        {
            Console.WriteLine("Insira um numero para saber se ele é primo:");

            int numero = int.Parse(Console.ReadLine());

            if(numero <= 1)
            {
                Console.WriteLine("Não é primo");
                return;
            }
            
            void VerificarPrimo(int numero)
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        Console.WriteLine("Não é primo");
                        return;
                    }
                }
                Console.WriteLine("É primo");
            }

            VerificarPrimo(numero);
        }

        static void Exe42()
        {
            Console.WriteLine("Insira um palavra para saber quantas vogais tem nela:");

            string palavra = Console.ReadLine().ToLowerInvariant();

            int contadorVogais = 0;
            
            foreach (char vogal in palavra)
            {
                if (vogal == 'a' || vogal == 'e' || vogal == 'i' || vogal == 'o' || vogal == 'u')
                {
                    contadorVogais++;
                }
            }

            Console.WriteLine($"A palavra '{palavra}' tem {contadorVogais} vogais.");
        }

        static void Exe43()
        {
            Console.WriteLine("Insira 5 numeros, espaçando-os, para mostrá-los ao contrario: (???? sla mano)");   

            Console.WriteLine("Insira o 1º numero: ");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2º numero: ");

            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 3º numero: ");

            int numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 4º numero: ");

            int numero4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 5º numero: ");

            int numero5 = int.Parse(Console.ReadLine());

            int[] numeros = new int[5];

            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;
            numeros[3] = numero4;
            numeros[4] = numero5;

            Array.Reverse(numeros);

            Console.WriteLine("");

            Console.WriteLine("Numeros ao contrario: " + string.Join(" ", numeros));
        }

        static void Exe44()
        {

        }

        static void Exe45()
        {

        }



        #endregion

    } // class exercicios
} // namespace ConsoleApp1
