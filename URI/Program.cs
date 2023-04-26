using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {

            //MediaPonderada();
            //MediaPonderada2();
            //Area(3.0, 4.0, 5.2);
            //CalculoSimples();
            //TempoDeJogo(23, 1);
            //TempoDeJogoComMinutos();
            //Positivos();
            //NumerosParesNegativos();
            //SeisImpares();
            //Maior();
            //Cedulas(576);
            //ConversaoTempo(600);
            //Idade(10950);
            //CedulasComMoedas(576.73);
            //Sozinho(576);
            //Condicao(5,6,7,8);
            //Teste(26);
            //Sort();
            //Vetor();
            //Month();
            //DDD();
            //TempoDeEvento();
            //Animal();
            //DistanciaEntrePontos();
            //Combinador();
            SenhaFixa();
            Console.ReadKey();
        }

        static void MediaPonderada()
        {
            // Média ponderada
            // nota 3.5*A + 7.5*B / 11 ( SOMA DOS PESOS)

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            if (A <= 100 && B <= 100)
            {
                double media = (3.5 * A + 7.5 * B) / 110;

                Console.WriteLine("MEDIA = " + media.ToString("F5"));
            }
            else
            {
                Console.WriteLine("Não deu certo");
            }
        }
        static void MediaPonderada2()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if (A <= 10.0 && B <= 10.0 && C <= 10.0)
            {
                double media = ((2 * A) + (3 * B) + (5 * C)) / (2 + 3 + 5);

                Console.WriteLine("MEDIA = " + media.ToString("F1"));
            }
        }
        static void CalculoSimples()
        {
            int[] vetor = new int[6];
            for (int i = 0; i <= vetor.Length - 1; i++)
            {
                Console.WriteLine("Digite o código, quantidade e valor do item " + (i + 1));
                int nota = int.Parse(Console.ReadLine());
                vetor[i] = nota;
            }

            int calculo = vetor[1] * vetor[2];
            calculo += vetor[4] * vetor[5];

            Console.WriteLine("VALOR FINAL = R$" + calculo.ToString("F2"));

            #region Solução antiga

            //int codigo1 = int.Parse(Console.ReadLine());
            //int quantidade1 = int.Parse(Console.ReadLine());
            //double valor1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            //int codigo2 = int.Parse(Console.ReadLine());
            //int quantidade2 = int.Parse(Console.ReadLine());
            //double valor2 = double.Parse(Console.ReadLine());

            //double resultado1 = valor1 * quantidade1;
            //resultado1 += valor2 * quantidade2;

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("======================================");

            //Console.WriteLine("VALOR FINAL = R$" + resultado1.ToString("F2"));

            #endregion

        }
        static void Area(double A, double B, double C)
        {
            double triangulo = (A * C) / 2;
            double circulo = (C * C) * 3.14159;
            double trapezio = ((A + B) * C) / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
        static void Maior()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            if (a != b && a != c && b != c)
            {
                if (a > b && a > c)
                {
                    Console.WriteLine(a + " eh o maior");
                }
                if (a < b && a > c)
                {
                    Console.WriteLine(b + " eh o maior");
                }
                if (a < b && c > b)
                {
                    Console.WriteLine(c + " eh o maior");
                }
            }
            else
            {
                Console.WriteLine("Não deu certo!");
            }


        }
        static void Consumo(int X, double Y)
        {
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            double resultado = X / Y;

            Console.WriteLine(resultado.ToString("F3") + " km/l");
        }
        static void Cedulas(int numero)
        {
            Console.WriteLine(numero);

            Console.WriteLine(numero / 100 + " notas(s) de R$ 100,00");
            numero = numero % 100;

            Console.WriteLine(numero / 50 + " notas(s) de R$ 50,00");
            numero = numero % 50;

            Console.WriteLine(numero / 20 + " notas(s) de R$ 20,00");
            numero = numero % 20;

            Console.WriteLine(numero / 10 + " notas(s) de R$ 10,00");
            numero = numero % 10;

            Console.WriteLine(numero / 5 + " notas(s) de R$ 5,00");
            numero = numero % 5;

            Console.WriteLine(numero / 2 + " notas(s) de R$ 2,00");
            numero = numero % 2;

            Console.WriteLine(numero / 1 + " notas(s) de R$ 1,00");


        }
        static void ConversaoTempo(int segundos)
        {

            int minuto = 0;
            int hora = 0;

            if (segundos > 0 && segundos < 60)
            {
                Console.WriteLine(hora + ":" + minuto + ":" + segundos);
            }

            if (segundos >= 60)
            {
                minuto = segundos / 60;
                segundos = segundos % 60;

                hora = minuto / 60;
                minuto = minuto % 60;
                Console.WriteLine(hora + ":" + minuto + ":" + segundos);
            }

        }
        static void Idade(int idade)
        {
            Console.WriteLine(idade / 365 + " ano(s)");
            int mes = idade % 365;
            int mesFinal = mes / 30;
            Console.WriteLine(mesFinal + " mes(es)");

            int dia = mes % 30;

            Console.WriteLine(dia + " dia(s)");


        }
        static void CedulasComMoedas(double numero)
        {
            Console.WriteLine("NOTAS:");

            int valorInformado = (int)numero;

            Console.WriteLine(valorInformado / 100 + " notas(s) de R$ 100,00");
            valorInformado = valorInformado % 100;

            Console.WriteLine(valorInformado / 50 + " notas(s) de R$ 50,00");
            valorInformado = valorInformado % 50;

            Console.WriteLine(valorInformado / 20 + " notas(s) de R$ 20,00");
            valorInformado = valorInformado % 20;

            Console.WriteLine(valorInformado / 10 + " notas(s) de R$ 10,00");
            valorInformado = valorInformado % 10;

            Console.WriteLine(valorInformado / 5 + " notas(s) de R$ 5,00");
            valorInformado = valorInformado % 5;

            Console.WriteLine("MOEDAS: ");






        }
        static void Condicao(int A, int B, int C, int D)
        {
            if (B > C && D > A && (C + D) > (A + B) && (C > 0 || D > 0) && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }
        }
        static void Teste(int teste)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Sort()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int i;
            int pos;
            int temp;
            int[] numbers = new int[3] { a, b ,c };

            for (i = 0; i < numbers.Length - 1; i++)
            {
                for (pos = 0; pos < numbers.Length - 1 - i; pos++)
                {
                    if (numbers[pos] > numbers[pos + 1])
                    {
                        temp = numbers[pos];
                        numbers[pos] = numbers[pos + 1];
                        numbers[pos + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void TempoDeJogo(int horaInicial, int horaFinal)
        {
            int horasJogadas = 0;

            if (horaInicial >= 24 || horaFinal >= 24)
            {
                Console.WriteLine("Valores inválidos para horas");
            }
            else
            {
                if (horaInicial == horaFinal)
                {
                    Console.WriteLine("O JOGO DUROU 24 HORA(S)");
                }
                else if (horaInicial < horaFinal)
                {
                    Console.WriteLine($"O JOGO DUROU {(horaFinal - horaInicial)} HORA(S)");

                } else
                {
                    while (horaInicial < 24)
                    {
                        horasJogadas += 1;
                        horaInicial++;
                    }
                    Console.WriteLine($"O JOGO DUROU {(horasJogadas + horaFinal)} HORA(S)");
                }
            }
        }
        static void TempoDeJogoComMinutos()
        {

            int horasJogadas = 0;
            int minutosJogados = 0;
            int minuto = 60;
            int[] horasComMinutos = new int[4];
            
            for (int i = 0; i <= horasComMinutos.Length - 1; i++)
            {
                horasComMinutos[i] = int.Parse(Console.ReadLine());
            }

            if ((horasComMinutos[0] == horasComMinutos[1]) && (horasComMinutos[2] == horasComMinutos[3]))
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
                return;
            }


            while (horasComMinutos[0] < horasComMinutos[2])
            {
                while (horasComMinutos[1] < horasComMinutos[3])
                {
                    minutosJogados += 1;
                    horasComMinutos[1]++;
                }
                horasJogadas += 1;
                horasComMinutos[0]++;
            }
            Console.WriteLine($"O JOGO DUROU {(horasJogadas)} HORA(S) E {minutosJogados} MINUTO(S)");

            #region Prototipo
            //for (int i = 0; i <= horasComMinutos.Length - 1; i++)
            //{
            //    int valor = int.Parse(Console.ReadLine());
            //    horasComMinutos[i] = valor;
            //}

            //if ((horasComMinutos[0] >= 24 || horasComMinutos[2] >= 24) || (horasComMinutos[1] >= 60 || horasComMinutos[3] >= 60))
            //{
            //    Console.WriteLine("Valores inválidos para horas");
            //}
            //else
            //{
            //    if ((horasComMinutos[0] == horasComMinutos[2]) && (horasComMinutos[1] == horasComMinutos[3]))
            //    {
            //        Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            //    }
            //    else if (horasComMinutos[0] < 24 && horasComMinutos[1] < horasComMinutos[3])
            //    {
            //        while (horasComMinutos[1] < horasComMinutos[3])
            //        {
            //            minutosJogados += 1;
            //            horasComMinutos[3]++;
            //        }
            //        Console.WriteLine($"O JOGO DUROU {(horasComMinutos[2] - horasComMinutos[0])} HORA(S) E {minutosJogados} MINUTO(S)");

            //    }
            //    else
            //    {
            //        while (horasComMinutos[0] < 24 && horasComMinutos[1] < horasComMinutos[3])
            //        {
            //            horasJogadas += 1;
            //            minutosJogados += 1;
            //            horasComMinutos[0]++;
            //        }
            //        Console.WriteLine($"O JOGO DUROU {(horasJogadas + horasComMinutos[2])} HORA(S) E {minutosJogados} MINUTO(S)");
            //    }
            //}
            #endregion

        }
        static void Intervalo()
        {
            float input = float.Parse(Console.ReadLine());
            string[] numeros = new string[4] {"[0,25]","(25,50]", "(50,75]","(75,100]"};
            

            if(input >= 0 && input <= 2500)
            {
                Console.WriteLine($"Intervalo {numeros[0]}");
            } 
            else if(input > 2500 && input <= 5000)
            {
                Console.WriteLine($"Intervalo {numeros[1]}");
            }
            else if (input > 5000 && input <= 7500)
            {
                Console.WriteLine($"Intervalo {numeros[2]}");
            }
            else if (input > 7500 && input <= 10000)
            {
                Console.WriteLine($"Intervalo {numeros[3]}");
            } else
            {
                Console.WriteLine($"Fora do intervalo");
            }
        }
        static void Positivos()
        {
            int[] values = new int[6]; 
            int contaPositivos = 0;
            int contaNegativos = 0;
            int media = 0;

            
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor");
                values[i] = int.Parse(Console.ReadLine());
                if (values[i] <= 0)
                {
                    contaNegativos += 1; // Accounter for validation (At least one value has to be positive)
                } else
                {
                    contaPositivos += 1;
                    media += values[i];
                }
            }
            
            if(contaNegativos == 6) // If true, it means that all the values are negative
            {
                Console.WriteLine("Ao menos um valor precisa ser positivo!");
            } else
            {
                int finalResult = media / contaPositivos;
                Console.WriteLine($"{contaPositivos} valor(es) positivo(s)");
                Console.WriteLine(finalResult.ToString("F1"));
            }
        }
        static void NumerosParesNegativos()
        {
            int[] values = new int[5];
            int contaNegativos = 0;
            int contaPositivos = 0;
            int contaPares = 0;
            int contaImpares = 0;

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor");
                values[i] = int.Parse(Console.ReadLine());
                if (values[i] <= 0)
                {
                    contaNegativos += 1; // Accounter for validation (At least one value has to be positive)
                }
                else
                {
                    contaPositivos += 1;
                }

                if (values[i] % 2 == 0)
                {
                    contaPares += 1;  
                } else
                {
                    contaImpares += 1;
                }
            }

            Console.WriteLine($"{contaPares} valor(es) par(es)");
            Console.WriteLine($"{contaImpares} valo(res) impar(es)");
            Console.WriteLine($"{contaPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{contaNegativos} valor(es) negativo(s)");

        }
        static void TempoDeEvento()
        {
            int[] v = new int[8];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            TimeSpan data = new TimeSpan(v[0], v[1], v[2], v[3]);
            TimeSpan data2 = new TimeSpan(v[4], v[5], v[6], v[7]);

            Console.WriteLine($"Dia {data.Days}");
            Console.WriteLine($"{data.Hours} : {data.Minutes} : {data.Seconds}");

            Console.WriteLine($"Dia {data2.Days}");
            Console.WriteLine($"{data2.Hours} : {data2.Minutes} : {data2.Seconds}");

            TimeSpan data3 = data2 - data;

            Console.WriteLine($"{data3.Days} dia(s)");
            Console.WriteLine($"{data3.Hours} hora(s)");
            Console.WriteLine($"{data3.Minutes} minuto(s)");
            Console.WriteLine($"{data3.Seconds} segundo(s)");

        }
        static void SeisImpares()
        {
            int numero = int.Parse(Console.ReadLine());
            List<int> impares = new List<int>();
            while(impares.Count < 6)
            {
                if (numero % 2 == 1)
                {
                    impares.Add(numero);
                }
                numero+= 1;
            }
            foreach (var item in impares)
            {
                Console.WriteLine("Números: " + item);
            }

            #region Outra Solução
            //int[] proximos = new int[12];
            //for (int i = 0; i < proximos.Length; i++)
            //{
            //    if (numero % 2 == 1)
            //    {
            //        proximos[i] = numero;
            //        console.writeline("números: " + proximos[i]);
            //    }
            //    numero += 1;
            //}
            #endregion


        }
        static void TestesEntrevistas()
        {
            // TESTE 1


            string input = Console.ReadLine();
            bool insideSequence = false; // whether we're currently inside a detected sequence
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 2 < input.Length && input[i] == 'a' && input[i + 1] == 'a' && input[i + 2] == 'a')
                {
                    // Detected "aaa" sequence
                    Console.Write("0");
                    i += 2; // skip ahead past the sequence
                    insideSequence = false;
                }
                else if (i + 2 < input.Length && input[i] == 'a' && input[i + 1] == 'b' && input[i + 2] == 'a')
                {
                    // Detected "aba" sequence
                    Console.Write("1");
                    i += 2; // skip ahead past the sequence
                    insideSequence = false;
                }
                else if (i + 2 < input.Length && insideSequence)
                {
                    // Ignore any sequences within sequences
                    continue;
                }
                else
                {
                    insideSequence = false;
                }
            }
            Console.WriteLine(); // Output a newline to cleanly exit


            // TESTE 2
            string input2 = "ffgf5ff5";
            int total = 0;
            string current_num = "";
            for (int i = 0; i < input2.Length; i++)
            {
                if (Char.IsDigit(input2[i]))// IsDigit serve pra verificar se o char é decimal, retornando true ou false
                {
                    current_num += input2[i];
                }
                else if (current_num != "")
                {
                    // Found a number followed by a product name
                    total += int.Parse(current_num);
                    current_num = "";
                }
            }
            // Add any remaining number at the end of the string
            if (current_num != "")
            {
                total += int.Parse(current_num);
            }
            Console.WriteLine("Total products: " + total);
        }
        static void Month()
        {
            string[] months = new string[12]
            {
                "January","February","Mars",
                "April","May","June",
                "July","August","September",
                "Octouber","Nouvember", "December"
            };

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < months.Length; i++)
            {
                if(m == i+1) 
                {
                    Console.WriteLine(months[i]);
                }
            }

        }
        static void DDD()
        {
            int ddd = int.Parse(Console.ReadLine());
            string cidade;

            switch (ddd)
            {
                case 61:
                    cidade = "Brasilia";
                    Console.WriteLine(cidade);
                    break;
                case 71:
                    cidade = "Salvador";
                    Console.WriteLine(cidade);
                    break;
                case 11:
                    cidade = "Sao Paulo";
                    Console.WriteLine(cidade);
                    break;
                case 21:
                    cidade = "Rio de Janeiro";
                    Console.WriteLine(cidade);
                    break;
                case 32:
                    cidade = "Juiz de Fora";
                    Console.WriteLine(cidade);
                    break;
                case 19:
                    cidade = "Campinas";
                    Console.WriteLine(cidade);
                    break;
                case 27:
                    cidade = "Vitoria";
                    Console.WriteLine(cidade);
                    break;
                case 31:
                    cidade = "Belo Horizonte";
                    Console.WriteLine(cidade);
                    break;

                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }
        }
        static void Combinador()
        {
            int casos = 2;

            for (int i = 0; i < casos; i++)
            {
                Console.WriteLine($"Valores do {i + 1}º caso");
                for (int j = 0; j < 2; j++)
                {
                    string primeiro = "aa";
                    string segundo = "bb";

                    char letter = primeiro[j];
                    char letter2 = segundo[j];

                }
            }
        }
        static void Animal()
        {
            Console.WriteLine("Digite a sequencia dos valores: ");
            string valor1 = Console.ReadLine();
            string valor2 = Console.ReadLine();
            string valor3 = Console.ReadLine();

            switch (valor1)
            {
                case "vertebrado":
                    if(valor2 == "ave")
                    {
                        if(valor3 == "carnivoro")
                        {
                            Console.WriteLine("aguia");
                        }
                        if (valor3 == "onivero")
                        {
                            Console.WriteLine("pomba");
                        }
                    }
                    if(valor2 == "mamifero")
                    {
                        if (valor3 == "onivoro")
                        {
                            Console.WriteLine("homem");
                        }
                        if (valor3 == "herbivoro")
                        {
                            Console.WriteLine("vaca");
                        }
                    }
                    break;

                case "invertebrado":
                    if (valor2 == "inseto")
                    {
                        if (valor3 == "hematofago")
                        {
                            Console.WriteLine("pulga");
                        }
                        if (valor3 == "herbivoro")
                        {
                            Console.WriteLine("lagarta");
                        }
                    }
                    if (valor2 == "anelideo")
                    {
                        if (valor3 == "hematofago")
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        if (valor3 == "onivoro")
                        {
                            Console.WriteLine("minhoca");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Valor fora do esperado");
                    break;
            }

        }
        static void DistanciaEntrePontos()
        {
            double[] ponto1 = new double[2]{ 1.0, 7.0 }; 
            double[] ponto2 = new double[2]{ 5.0, 9.0 };

            double result = Math.Sqrt(((ponto2[0] * 2 - ponto1[0] * 1) * 2) + ((ponto2[1] * 2 - ponto1[0] * 1) * 2));
            Console.WriteLine(result.ToString("F4"));
        }
        static void SenhaFixa()
        {
            string senha;
            do
            {
                Console.WriteLine("Senha: ");
                senha = Console.ReadLine();
                Console.WriteLine("Senha Invalida");
                
            } while (senha != "2002");
            Console.WriteLine("Acesso Permitido");
        }
    }
}

