using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salidadeusuario = false;
            do
            {
                try
                {
                    int dia;
                    int mes;
                    int año;

                    Console.WriteLine("Ingresar dia (dos numeros): ");
                    dia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresar mes (dos numeros): ");
                    mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresar año (cuatro numeros): ");
                    año = int.Parse(Console.ReadLine());

                    //Meses con 31 dias
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (dia > 0 && dia <= 31)
                        {
                            if (dia == 31)
                            {
                                dia = 32 - dia;
                                mes = mes + 1;
                            }
                            else
                            {
                                dia = dia + 1;
                            }
                            switch (mes)
                            {
                                case 1:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Enero " + " de " + año);
                                    break;

                                case 2:
                                    Console.WriteLine("Dia siguiente:: " + dia + " De Febrero " + " de " + año);
                                    break;

                                case 3:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Marzo " + " de " + año);
                                    break;

                                case 4:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Abril " + " de " + año);
                                    break;

                                case 5:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Mayo " + " de " + año);
                                    break;
                                case 6:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Junio " + " de " + año);
                                    break;
                                case 7:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Julio " + " de " + año);
                                    break;
                                case 8:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Agosto " + " de " + año);
                                    break;
                                case 9:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Septiembre " + " de " + año);
                                    break;
                                case 10:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Octubre " + " de " + año);
                                    break;
                                case 11:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Noviembre " + " de " + año);
                                    break;
                                case 12:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Diciembre" + " de " + año);
                                    break;
                                default:
                                    año = año + 1;
                                    Console.WriteLine("Dia siguiente: " + dia + " De enero " + " de " + año);
                                    break;
                            }
                        }
                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12 && (dia <= 0 || dia > 31))
                        {
                            Console.WriteLine("No existe un mes con mas de 31 dias");
                            Console.WriteLine("Desea salir? si/no");
                            Console.ReadLine();
                            if (salidadeusuario == true)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\n\nMuchas gracias! Presione ENTER para salir.");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        }
                        mes = 0;
                    }
                    //Meses con 30 dias
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        if (dia > 0 && dia <= 30)
                        {
                            if (dia == 30)
                            {
                                dia = 31 - dia;
                                mes = mes + 1;
                            }
                            else
                            {
                                dia = dia + 1;
                            }
                        }
                        if (mes == 4 || mes == 6 || mes == 9 || mes == 11 && (dia <= 0 && dia > 30))
                        {
                            Console.WriteLine("El mes elegido no tiene esa cantidad de dias");
                            Console.WriteLine("Desea salir? si/no");
                            String opcion = Console.ReadLine();
                            if (opcion == "no")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\n\nMuchas gracias! Presione ENTER para salir.");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }

                        }
                        else
                        {
                            switch (mes)
                            {
                                case 4:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Abril " + " de " + año);
                                    break;
                                case 5:
                                    Console.WriteLine("Dia siguiente: " + dia + " De mayo " + " de " + año);
                                    break;
                                case 6:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Junio " + " de " + año);
                                    break;
                                case 7:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Julio " + " de " + año);
                                    break;
                                case 9:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Septiembre " + " de " + año);
                                    break;
                                case 10:
                                    Console.WriteLine("Dia siguiente: " + dia + " De octubre " + " de " + año);
                                    break;
                                case 11:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Noviembre " + " de " + año);
                                    break;
                                case 12:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Diciembre " + " de " + año);
                                    break;

                            }
                        }

                    }

                    if (mes == 2)
                    {
                        if (AñoBiciesto(año))
                        {
                            if (dia > 0 && dia <= 29)
                            {
                                if (dia == 29)
                                {
                                    dia = 30 - dia;
                                    mes = mes + 1;
                                }
                                else
                                {
                                    dia = dia + 1;
                                }
                            }
                        }
                        else
                        {
                            if (dia > 0 && dia <= 28)
                            {
                                if (dia == 28)
                                {
                                    dia = 29 - dia;
                                    mes = mes + 1;
                                }
                                else
                                {
                                    dia = dia + 1;
                                }
                            }
                        }
                        if (mes == 2 && (dia <= 0 || dia > 29))
                        {
                            Console.WriteLine("El mes elegido no tiene 30 dias");
                            Console.WriteLine("Desea salir? si/no");
                            if (salidadeusuario == true)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\n\nMuchas gracias! Presione ENTER para salir.");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            switch (mes)
                            {
                                case 2:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Febrero " + " de " + año);
                                    break;

                                case 3:
                                    Console.WriteLine("Dia siguiente: " + dia + " De Marzo " + " de " + año);
                                    break;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Usted a ingresado un caracter incorrecto :(");
                    Console.WriteLine("Desea salir? si/no");
                    Console.ReadLine();
                    if (salidadeusuario == true)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n\nMuchas gracias! Presione ENTER para salir.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            } while (salidadeusuario = false);


        }

        static public bool AñoBiciesto(int ab)
        {
            bool dato = false;
            if (ab % 4 == 0 && (ab % 100 != 0 || ab % 400 == 0))
            {
                dato = true;
            }
            return dato;
        }
    }
}