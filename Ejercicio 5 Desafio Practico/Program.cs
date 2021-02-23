using System;

namespace Ejercicio5_Desafio_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "Pago de salarios";
            string nombre_empleado1 = "", apellido_empleado1 = "", cargo_empleado1 = "";
            string nombre_empleado2 = "", apellido_empleado2 = "", cargo_empleado2 = "";
            string nombre_empleado3 = "", apellido_empleado3 = "", cargo_empleado3 = "";
            string gerente = "Gerente";
            string asistente = "Asistente";
            string secretaria = "Secretaria";
            int ngerente = 0;
            int nasistente = 0;
            int nsecretaria = 0;
            double salario_empleado1 = 0, salario_empleado2 = 0, salario_empleado3 = 0, bono_empleado1 = 0, bono_empleado2 = 0, bono_empleado3 = 0;
            double descuento_iss_empleado1 = 0, descuento_afp_empleado1 = 0, descuento_renta_empleado1 = 0, descuento_total_empleado1 = 0;
            double descuento_iss_empleado2 = 0, descuento_afp_empleado2 = 0, descuento_renta_empleado2 = 0, descuento_total_empleado2 = 0;
            double descuento_iss_empleado3 = 0, descuento_afp_empleado3 = 0, descuento_renta_empleado3 = 0, descuento_total_empleado3 = 0;
            int mayor_300 = 0;

            Console.WriteLine("Bienvenido, en este programa, usted podrá calcular el sueldo líquido de 3 empleados según su cargo y las horas trabajadas al mes");
            for (int i = 1; i <= 3; i++)
            {
                int horas_trabajadas;
                string nombre, apellido, cargo;
                double salario = 0, desceuento_iss = 0, descuento_afp = 0, descuento_renta = 0, descuento_total = 0, salario_liquido = 0, bono = 0, horas_extra = 0;


                Console.WriteLine("Por favor ingresar el primer nombre del empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Por favor ingresar el apellido del empleado");
                apellido = Console.ReadLine();
                Console.WriteLine("Por favor ingrese el cargo del empleado poniendo la primera letra en mayúscula");
                cargo = Console.ReadLine();
                Console.WriteLine("Por favor ingrese la cantidad de horas trabajadas al mes");
                horas_trabajadas = int.Parse(Console.ReadLine());

                if (horas_trabajadas > 0)
                {
                    if (cargo == gerente)
                    {
                        ngerente++;
                        if (horas_trabajadas < 160)
                        {
                            salario = horas_trabajadas * 9.75;
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.1;

                        }
                        else if (horas_trabajadas > 160)
                        {
                            horas_extra = horas_trabajadas - 160;
                            salario = (160 * 9.75) + (horas_extra * 11.50);
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.1;


                        }
                        if (salario > 300)
                        {
                            mayor_300++;
                        }

                    }
                    else if (cargo == asistente)
                    {
                        nasistente++;
                        if (horas_trabajadas < 160)
                        {
                            salario = horas_trabajadas * 9.75;
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.05;


                        }
                        else if (horas_trabajadas > 160)
                        {
                            horas_extra = horas_trabajadas - 160;
                            salario = (160 * 9.75) + (horas_extra * 11.50);
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.05;

                        }
                        if (salario > 300)
                        {
                            mayor_300++;
                        }
                    }
                    else if (cargo == secretaria)
                    {
                        nsecretaria++;
                        if (horas_trabajadas < 160)
                        {
                            salario = horas_trabajadas * 9.75;
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.03;



                        }
                        else if (horas_trabajadas > 160)
                        {
                            horas_extra = horas_trabajadas - 160;
                            salario = (160 * 9.75) + (horas_extra * 11.50);
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.03;


                        }
                        if (salario > 300)
                        {
                            mayor_300++;
                        }
                    }
                    else
                    {
                        if (horas_trabajadas > 160)
                        {
                            horas_extra = horas_trabajadas - 160;
                            salario = (160 * 9.75) + (horas_extra * 11.50);
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.02;


                        }
                        else if (horas_trabajadas < 160)
                        {

                            salario = horas_trabajadas * 9.75;
                            desceuento_iss = salario * 0.0525;
                            descuento_afp = 0.0688;
                            descuento_renta = 0.1;
                            descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                            salario_liquido = salario - descuento_total;
                            bono = salario_liquido * 1.02;


                        }
                        if (salario > 300)
                        {
                            mayor_300++;
                        }

                    }
                    if (i == 1)
                    {
                        nombre_empleado1 = nombre;
                        apellido_empleado1 = apellido;
                        cargo_empleado1 = cargo;
                        descuento_iss_empleado1 = desceuento_iss;
                        descuento_afp_empleado1 = descuento_afp;
                        descuento_renta_empleado1 = descuento_renta;
                        descuento_total_empleado1 = descuento_total;
                        salario_empleado1 = salario_liquido;
                        bono_empleado1 = bono;

                    }
                    else if (i == 2)
                    {
                        nombre_empleado2 = nombre;
                        apellido_empleado2 = apellido;
                        cargo_empleado2 = cargo;
                        descuento_iss_empleado2 = desceuento_iss;
                        descuento_afp_empleado2 = descuento_afp;
                        descuento_renta_empleado2 = descuento_renta;
                        descuento_total_empleado2 = descuento_total;
                        salario_empleado2 = salario_liquido;
                        bono_empleado2 = bono;

                    }
                    else if (i == 3)
                    {
                        nombre_empleado3 = nombre;
                        apellido_empleado3 = apellido;
                        cargo_empleado3 = cargo;
                        descuento_iss_empleado3 = desceuento_iss;
                        descuento_afp_empleado3 = descuento_afp;
                        descuento_renta_empleado3 = descuento_renta;
                        descuento_total_empleado3 = descuento_total;
                        salario_empleado3 = salario_liquido;
                        bono_empleado3 = bono;

                    }
                }
                else if (horas_trabajadas <= 0)
                {
                    for (i = 1; i <= 3; i++)
                    {


                        Console.WriteLine("Por favor ingrese un número positivo");
                        Console.WriteLine("Por favor ingresar el primer nombre del empleado");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Por favor ingresar el apellido del empleado");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese el cargo del empleado poniendo la primera letra en mayúscula");
                        cargo = Console.ReadLine();
                        Console.WriteLine("Por favor ingrese la cantidad de horas trabajadas al mes");
                        horas_trabajadas = int.Parse(Console.ReadLine());

                        if (horas_trabajadas > 0)
                        {
                            if (cargo == gerente)
                            {
                                ngerente++;
                                if (horas_trabajadas < 160)
                                {
                                    salario = horas_trabajadas * 9.75;
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.1;

                                }
                                else if (horas_trabajadas > 160)
                                {
                                    horas_extra = horas_trabajadas - 160;
                                    salario = (160 * 9.75) + (horas_extra * 11.50);
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.1;


                                }
                                if (salario > 300)
                                {
                                    mayor_300++;
                                }

                            }
                            else if (cargo == asistente)
                            {
                                nasistente++;
                                if (horas_trabajadas < 160)
                                {
                                    salario = horas_trabajadas * 9.75;
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.05;


                                }
                                else if (horas_trabajadas > 160)
                                {
                                    horas_extra = horas_trabajadas - 160;
                                    salario = (160 * 9.75) + (horas_extra * 11.50);
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.05;

                                }
                                if (salario > 300)
                                {
                                    mayor_300++;
                                }
                            }
                            else if (cargo == secretaria)
                            {
                                nsecretaria++;
                                if (horas_trabajadas < 160)
                                {
                                    salario = horas_trabajadas * 9.75;
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.03;



                                }
                                else if (horas_trabajadas > 160)
                                {
                                    horas_extra = horas_trabajadas - 160;
                                    salario = (160 * 9.75) + (horas_extra * 11.50);
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.03;


                                }
                                if (salario > 300)
                                {
                                    mayor_300++;
                                }
                            }
                            else
                            {
                                if (horas_trabajadas > 160)
                                {
                                    horas_extra = horas_trabajadas - 160;
                                    salario = (160 * 9.75) + (horas_extra * 11.50);
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.02;


                                }
                                else if (horas_trabajadas < 160)
                                {

                                    salario = horas_trabajadas * 9.75;
                                    desceuento_iss = salario * 0.0525;
                                    descuento_afp = 0.0688;
                                    descuento_renta = 0.1;
                                    descuento_total = desceuento_iss + descuento_afp + descuento_renta;
                                    salario_liquido = salario - descuento_total;
                                    bono = salario_liquido * 1.02;


                                }
                                if (salario > 300)
                                {
                                    mayor_300++;
                                }

                            }
                            if (i == 1)
                            {
                                nombre_empleado1 = nombre;
                                apellido_empleado1 = apellido;
                                cargo_empleado1 = cargo;
                                descuento_iss_empleado1 = desceuento_iss;
                                descuento_afp_empleado1 = descuento_afp;
                                descuento_renta_empleado1 = descuento_renta;
                                descuento_total_empleado1 = descuento_total;
                                salario_empleado1 = salario_liquido;
                                bono_empleado1 = bono;

                            }
                            else if (i == 2)
                            {
                                nombre_empleado2 = nombre;
                                apellido_empleado2 = apellido;
                                cargo_empleado2 = cargo;
                                descuento_iss_empleado2 = desceuento_iss;
                                descuento_afp_empleado2 = descuento_afp;
                                descuento_renta_empleado2 = descuento_renta;
                                descuento_total_empleado2 = descuento_total;
                                salario_empleado2 = salario_liquido;
                                bono_empleado2 = bono;

                            }
                            else if (i == 3)
                            {
                                nombre_empleado3 = nombre;
                                apellido_empleado3 = apellido;
                                cargo_empleado3 = cargo;
                                descuento_iss_empleado3 = desceuento_iss;
                                descuento_afp_empleado3 = descuento_afp;
                                descuento_renta_empleado3 = descuento_renta;
                                descuento_total_empleado3 = descuento_total;
                                salario_empleado3 = salario_liquido;
                                bono_empleado3 = bono;

                            }
                        }
                    }
                }

            }

            if (ngerente == 0 && nsecretaria == 0 && nasistente == 0)
            {
                Console.WriteLine("Primer empleado: \n Nombre: " + nombre_empleado1 + "\n Apellido: " + apellido_empleado1 + "\n Descuento del ISSS (5.25%): $" + descuento_iss_empleado1 + "\n Descuento AFP (6.88%): $" + descuento_afp_empleado1 + "\n Descuento de renta (10%): $" + descuento_renta_empleado1 + "\n Descuento total: $" + descuento_total_empleado1 + "\n Salario líquido a pagar al empleado: $" + bono_empleado1);
                Console.WriteLine("\nSegundo empleado: \n Nombre: " + nombre_empleado2 + "\n Apellido: " + apellido_empleado2 + "\n Descuento del ISSS (5.25%): $" + descuento_iss_empleado2 + "\n Descuento AFP (6.88%): $" + descuento_afp_empleado2 + "\n Descuento de renta (10%): $" + descuento_renta_empleado2 + "\n Descuento total: $" + descuento_total_empleado2 + "\n Salario líquido a pagar al empleado: $" + bono_empleado2);
                Console.WriteLine("\nTercer: empleado: \n Nombre: " + nombre_empleado3 + "\n Apellido: " + apellido_empleado3 + "\n Descuento del ISSS (5.25%): $" + descuento_iss_empleado3 + "\n Descuento AFP (6.88%): $" + descuento_afp_empleado3 + "\n Descuento de renta (10%): $" + descuento_renta_empleado3 + "\n Descuento total: $" + descuento_total_empleado3 + "\n Salario líquido a pagar al empleado: $" + bono_empleado3);
                Console.WriteLine("Empleados con salario mayor a 300: " + mayor_300);
                if (bono_empleado1 > bono_empleado2 && bono_empleado1 > bono_empleado3)
                {
                    Console.WriteLine("\n El primer empleado " + nombre_empleado1 + " " + apellido_empleado1 + " es el que tiene el mayor salario, con un salario líquido de: $" + bono_empleado1);
                }
                else if (bono_empleado2 > bono_empleado1 && bono_empleado2 > bono_empleado3)
                {
                    Console.WriteLine("\n El segundo empleado " + nombre_empleado2 + " " + apellido_empleado2 + " es el que tiene el mayor salario, con un salario líquido de: $" + bono_empleado2);
                }
                else if (bono_empleado3 > bono_empleado1 && bono_empleado3 > bono_empleado2)
                {
                    Console.WriteLine("\n El tercer empleado " + nombre_empleado3 + " " + apellido_empleado3 + " es el que tiene el mayor salario, con un salario líquido de: $" + bono_empleado3);
                }
                if (bono_empleado1 < bono_empleado2 && bono_empleado1 < bono_empleado3)
                {
                    Console.WriteLine("\n El primer empleado " + nombre_empleado1 + " " + apellido_empleado1 + " es el que tiene el menor salario, con un salario líquido de: $" + bono_empleado1);
                }
                else if (bono_empleado2 < bono_empleado1 && bono_empleado2 < bono_empleado3)
                {
                    Console.WriteLine("\n El segundo empleado " + nombre_empleado2 + " " + apellido_empleado2 + " es el que tiene el menor salario, con un salario líquido de: $" + bono_empleado2);
                }
                else if (bono_empleado3 < bono_empleado1 && bono_empleado3 < bono_empleado2)
                {
                    Console.WriteLine("\n El tercer empleado " + nombre_empleado3 + " " + apellido_empleado3 + " es el que tiene el menor salario, con un salario líquido de: $" + bono_empleado3);
                }


            }
            else
            {
                Console.WriteLine("\n !NO HAY BONO¡ \n");
                Console.WriteLine("Primer empleado: \n Nombre: " + nombre_empleado1 + "\n Apellido: " + apellido_empleado1 + "\n Descuento del ISSS (5.25%): $" + descuento_iss_empleado1 + "\n Descuento AFP (6.88%): $" + descuento_afp_empleado1 + "\n Descuento de renta (10%): $" + descuento_renta_empleado1 + "\n Descuento total: $" + descuento_total_empleado1 + "\n Salario líquido a pagar al empleado: $" + salario_empleado1);
                Console.WriteLine("\nSegundo empleado: \n Nombre: " + nombre_empleado2 + "\n Apellido: " + apellido_empleado2 + "\n Descuento del ISSS (5.25%): $" + descuento_iss_empleado2 + "\n Descuento AFP (6.88%): $" + descuento_afp_empleado2 + "\n Descuento de renta (10%): $" + descuento_renta_empleado2 + "\n Descuento total: $" + descuento_total_empleado2 + "\n Salario líquido a pagar al empleado: $" + salario_empleado2);
                Console.WriteLine("\nTercer empleado: \n Nombre: " + nombre_empleado3 + "\n Apellido: " + apellido_empleado3 + "\n Descuento del ISSS (5.25%): $" + descuento_iss_empleado3 + "\n Descuento AFP (6.88%): $" + descuento_afp_empleado3 + "\n Descuento de renta (10%): $" + descuento_renta_empleado3 + "\n Descuento total: $" + descuento_total_empleado3 + "\n Salario líquido a pagar al empleado: $" + salario_empleado3);
                Console.WriteLine("Empleados con salario mayor a 300:" + mayor_300);
                if (salario_empleado1 > salario_empleado2 && salario_empleado1 > salario_empleado3)
                {
                    Console.WriteLine("\n El primer empleado " + nombre_empleado1 + " " + apellido_empleado2 + " es el que tiene el mayor salario, con un salario líquido de: $" + salario_empleado1);
                }
                else if (salario_empleado2 > salario_empleado1 && salario_empleado2 > salario_empleado3)
                {
                    Console.WriteLine("\n El segundo empleado " + nombre_empleado2 + " " + apellido_empleado2 + " es el que tiene el mayor salario, con un salario líquido de: $" + salario_empleado2);
                }
                else if (salario_empleado3 > salario_empleado1 && salario_empleado3 > salario_empleado2)
                {
                    Console.WriteLine("\n El tercer empleado " + nombre_empleado3 + " " + apellido_empleado3 + " es el que tiene el mayor salario, con un salario líquido de: $" + salario_empleado3);
                }
                if (salario_empleado1 < salario_empleado2 && salario_empleado1 < salario_empleado3)
                {
                    Console.WriteLine("\n El primer empleado " + nombre_empleado1 + " " + apellido_empleado1 + " es el que tiene el menor salario, con un salario líquido de: $" + salario_empleado1);
                }
                else if (salario_empleado2 < salario_empleado1 && salario_empleado2 < salario_empleado3)
                {
                    Console.WriteLine("\n El segundo empleado " + nombre_empleado2 + " " + apellido_empleado2 + " es el que tiene el menor salario, con un salario líquido de: $" + salario_empleado2);
                }
                else if (salario_empleado3 < salario_empleado1 && salario_empleado3 < salario_empleado2)
                {
                    Console.WriteLine("\n El tercer empleado " + nombre_empleado3 + " " + apellido_empleado3 + " es el que tiene el menor salario, con un salario líquido de: $" + salario_empleado3);
                }
            }
            Console.ReadKey();
        }
    }
}