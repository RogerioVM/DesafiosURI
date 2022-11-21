using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)

        {

            //MediaPonderada();
            //MediaPonderada2();
            //Area(3.0, 4.0, 5.2);
            //Calculo();
            //Maior();
            //Cedulas(576);
            //ConversaoTempo(140153);
            //Idade(10585);
            //CedulasComMoedas(576.73);
            //Sozinho(576);
            //Condicao(5,6,7,8);
            Teste(26);
            Console.ReadLine();
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

        static void Calculo()
        {
            int codigo1 = int.Parse(Console.ReadLine());
            int quantidade1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            int codigo2 = int.Parse(Console.ReadLine());
            int quantidade2 = int.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());

            double resultado1 = valor1 * quantidade1;
            resultado1 += valor2 * quantidade2;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======================================");

            Console.WriteLine("VALOR FINAL = R$" + resultado1.ToString("F2"));
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
            Console.WriteLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
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
                if(i % 3 == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    
}

