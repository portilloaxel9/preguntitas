using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a Preguntitas!");
            Console.WriteLine("Presione A para continuar.");
            string A = Console.ReadLine();
            if (A.ToLower() == "a")
            {
                Console.WriteLine("Elija una categoría:");
                bool salir = false;
                do
                {
                    Console.WriteLine("1. Matemáticas");
                    Console.WriteLine("2. Geografía");
                    Console.WriteLine("3. Literatura");
                    Console.WriteLine("4. Historia");
                    Console.WriteLine("5. Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    int puntaje = 0;
                    int resultado1, resultado2, resultado3;
                    string respuesta1, respuesta2, respuesta3, respuesta4;
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido Matemáticas.");
                            Console.WriteLine("¿Cuánto es 2 + 2?");
                            resultado1 = Convert.ToInt32(Console.ReadLine());
                            if (resultado1 == 4)
                            {
                                Console.WriteLine("¡Correcto! La respuesta es 4.");
                                puntaje = puntaje + 1;
                            } else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es 4.");
                            }
                            Console.WriteLine("¿Cuánto es 79 - 29?");
                            resultado2 = Convert.ToInt32(Console.ReadLine());
                            if (resultado2 == 50)
                            {
                                Console.WriteLine("¡Excelente! La respuesta es 50.");
                                puntaje = puntaje + 1;
                            } else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es 50.");
                            }
                            Console.WriteLine("¿Cuánto es 3 x 100?");
                            resultado3 = Convert.ToInt32(Console.ReadLine());
                            if (resultado3 == 300)
                            {
                                Console.WriteLine("¡Perfecto! La respuesta es 300.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es 300.");
                            }

                            Console.WriteLine("Se acabaron las preguntas...");

                            if (puntaje < 2)
                            {
                                Console.WriteLine("Tu puntaje es " + puntaje + ". ¡Debes practicar más!");
                            }
                            else
                            {
                                Console.WriteLine("¡Felicidades! Tu puntaje es " + puntaje + ".");
                            }
                            Console.WriteLine("¿Desea volver al menú?");
                            respuesta4 = Console.ReadLine();
                            if (respuesta4.ToLower() == "si")
                            {
                                Console.WriteLine("Volviendo al menú...");
                            } else
                            {
                                salir = true;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Has elegido Geografía.");
                            Console.WriteLine("¿Cuál es la capital de Argentina?");
                            respuesta1 = Console.ReadLine();
                            if (respuesta1 == "Buenos Aires")
                            {
                                Console.WriteLine("¡Correcto! La respuesta es Buenos Aires.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es Buenos Aires.");
                            }
                            Console.WriteLine("¿En qué provincia argentina queda Bariloche?");
                            respuesta2 = Console.ReadLine();
                            if (respuesta2 == "Río Negro")
                            {
                                Console.WriteLine("¡Excelente! La respuesta es Río Negro.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es Río Negro.");
                            }
                            Console.WriteLine("¿Cuál es la capital de Perú?");
                            respuesta3 = Console.ReadLine();
                            if (respuesta3 == "Lima")
                            {
                                Console.WriteLine("¡Perfecto! La respuesta es Lima.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es Lima.");
                            }

                            Console.WriteLine("Se acabaron las preguntas...");

                            if (puntaje < 2)
                            {
                                Console.WriteLine("Tu puntaje es " + puntaje + ". ¡Debes practicar más!");
                            }
                            else
                            {
                                Console.WriteLine("¡Felicidades! Tu puntaje es " + puntaje + ".");
                            }
                            Console.WriteLine("¿Desea volver al menú?");
                            respuesta4 = Console.ReadLine();
                            if (respuesta4.ToLower() == "si")
                            {
                                Console.WriteLine("Volviendo al menú...");
                            }
                            else
                            {
                                salir = true;
                            }
                            break;

                        case 3:
                            Console.WriteLine("Has elegido Literatura.");
                            Console.WriteLine("¿Cuál es la profesión de Sherlock Holmes?");
                            respuesta1 = Console.ReadLine();
                            if (respuesta1 == "Detective")
                            {
                                Console.WriteLine("¡Correcto! Sherlock Holmes es dectective.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! Sherlock Holmes es dectective.");
                            }
                            Console.WriteLine("¿Quién escribió La Odisea?");
                            respuesta2 = Console.ReadLine();
                            if (respuesta2 == "Homero")
                            {
                                Console.WriteLine("¡Excelente! La Odisea fue escrita por Homero.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La Odisea fue escrita por Homero.");
                            }
                            Console.WriteLine("¿En cuál ciudad italiana vivían Romeo y Julieta?");
                            respuesta3 = Console.ReadLine();
                            if (respuesta3 == "Verona")
                            {
                                Console.WriteLine("¡Perfecto! La respuesta es Verona.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es Verona.");
                            }

                            Console.WriteLine("Se acabaron las preguntas...");

                            if (puntaje < 2)
                            {
                                Console.WriteLine("Tu puntaje es " + puntaje + ". ¡Debes practicar más!");
                            }
                            else
                            {
                                Console.WriteLine("¡Felicidades! Tu puntaje es " + puntaje + ".");
                            }
                            Console.WriteLine("¿Desea volver al menú?");
                            respuesta4 = Console.ReadLine();
                            if (respuesta4.ToLower() == "si")
                            {
                                Console.WriteLine("Volviendo al menú...");
                            }
                            else
                            {
                                salir = true;
                            }
                            break;

                        case 4:
                            Console.WriteLine("Has elegido Historia.");
                            Console.WriteLine("¿En qué año se sucedió la Revolución de Mayo?");
                            respuesta1 = Console.ReadLine();
                            if (respuesta1 == "1810")
                            {
                                Console.WriteLine("¡Correcto! Sucedió en 1810.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! Sucedió en 1810.");
                            }
                            Console.WriteLine("¿De qué país fue colonia Australia?");
                            respuesta2 = Console.ReadLine();
                            if (respuesta2 == "Inglaterra")
                            {
                                Console.WriteLine("¡Excelente! La respuesta es Inglaterra.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es Inglaterra.");
                            }
                            Console.WriteLine("¿De qué país fue rey Luis XIII?");
                            respuesta3 = Console.ReadLine();
                            if (respuesta3 == "Francia")
                            {
                                Console.WriteLine("¡Perfecto! La respuesta es Francia.");
                                puntaje = puntaje + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Incorrecto! La respuesta es Francia.");
                            }

                            Console.WriteLine("Se acabaron las preguntas...");

                            if (puntaje < 2)
                            {
                                Console.WriteLine("Tu puntaje es " + puntaje + ". ¡Debes practicar más!");
                            }
                            else
                            {
                                Console.WriteLine("¡Felicidades! Tu puntaje es " + puntaje + ".");
                            }
                            Console.WriteLine("¿Desea volver al menú?");
                            respuesta4 = Console.ReadLine();
                            if (respuesta4.ToLower() == "si")
                            {
                                Console.WriteLine("Volviendo al menú...");
                            }
                            else
                            {
                                salir = true;
                            }
                            break;

                        case 5:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 5.");
                            break;
                    }
                }
                while (!salir);
            } 
        }
    }
}
