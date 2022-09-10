using System;
    
    namespace Calculator
    {

        class Program
        {

            static void Main(string[] args)
            {
                Menu();
            }
            static void Menu(){
                
                Console.Clear();
                
                Console.WriteLine("Escolha qual operação desejaa fazer:");
                Console.WriteLine("");
                Console.WriteLine("1- Soma");
                Console.WriteLine("");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("");
                Console.WriteLine("3-Divisão");
                Console.WriteLine("");
                Console.WriteLine("4-Multiplicação");
                Console.WriteLine("");
                Console.WriteLine("5- Calcular a média");
                Console.WriteLine("");
                Console.WriteLine("0- sair");

                Console.WriteLine("-------------------");
                Console.WriteLine("Digite o número corresponde a opção: ");
                short op = short.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:System.Environment.Exit(0); break;
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 5: Media(); break;
                    default: Menu(); break;
                }

            }
            static void Soma(){
                 
                Console.Clear();
               
                Console.WriteLine("Primeiro valor:");
                float v1 =  float.Parse(Console.ReadLine());
                
                Console.WriteLine("Segundo valor:");
                float v2 = float.Parse(Console.ReadLine());
                
                Console.WriteLine(" ");
                float resultado = v1+v2;
                Console.WriteLine( $"O resultao da soma é {resultado} ");
                Console.ReadKey();
                Menu();
            } 
             static void Subtracao(){
                
                Console.Clear();

                Console.WriteLine("Primeiro valor:");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor:");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");
                float resultado = v1-v2;

                Console.WriteLine($"O resultado da subtração eh{resultado}");
                Console.ReadKey();
                Menu();
            }
            static void Divisao(){
                Console.Clear();

                Console.WriteLine("Primeiro valor:");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor:");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                float resultado = v1/v2;

                Console.WriteLine($"O resultado da divisão é {resultado}");
                Console.ReadKey();
                Menu();
            }
            static void Multiplicacao(){
                
                Console.Clear();

                Console.WriteLine("Digite o Primeiro Valor:");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor:");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                float resultado = v1*v2;
                Console.WriteLine($"O rsultado da multiplicação é: {resultado}");
                Console.ReadKey();
                Menu();

            }
            static void Media(){

                Console.Clear();

                Console.WriteLine("Quantos numeros deseja calcular a média:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                int controle;
                float media = 0;

                for(controle = 1; controle<=num; controle++){
                    Console.WriteLine($"Digite o valor {controle}:");
                    float valor = float.Parse(Console.ReadLine());

                    media += valor;
                }
                
                Console.WriteLine(" O resultado da média:" + (media/num));
                Console.ReadKey();
                Menu();
            }
        }
    }  