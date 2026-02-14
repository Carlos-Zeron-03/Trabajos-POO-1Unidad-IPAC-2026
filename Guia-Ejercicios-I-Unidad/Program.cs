// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Guia_Ejercicios_I_Unidad;
using Guia_Ejercicios_I_Unidad.Guia_1;
using Guia_Ejercicios_I_Unidad.Guia_1.Bloque_2;

{
    int op;
    do
    {

        Console.WriteLine("Seleccione un bloque de ejercicios: ");
        Console.WriteLine("1. Bloque 1\n");
        Console.WriteLine("2. Bloque 2\n");
        Console.WriteLine("3. Bloque 3\n");
        Console.WriteLine("4. Bloque 4\n");
        Console.WriteLine("5. Bloque 5\n");
        Console.WriteLine("6. Salir\n");
        while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 9) 
        // verifica que el numero ingresado este dentro del rango, si no vuelve a pedir el numero de bloque.
            {
                Console.WriteLine("Opción inválida. Intente nuevamente:");
            }
    } while (op < 1 || op > 6);

    switch (op)
    {
        case 1:
            int op1;
            do
            {
                Console.WriteLine("----- Menu -----\n");
                Console.WriteLine("Elija una opción: \n");
                Console.WriteLine("1. Calculadora IMC\n");
                Console.WriteLine("2. Conversion de temperatura\n");
                Console.WriteLine("3. Desglose de Billetes\n");
                Console.WriteLine("4. Calculadora de préstamo simple\n");
                Console.WriteLine("5. Tiempo transcurrido\n");
                Console.WriteLine("6. Área y perímetro\n");
                Console.WriteLine("7. Conversión de unidades de almacenamiento\n");
                Console.WriteLine("8. Cálculo de salario semanal\n");
                Console.WriteLine("9. Salir.\n");
                while (!int.TryParse(Console.ReadLine(), out op1) || op1 < 1 || op1 > 9)
                // Valida si el numero ingresado pertenece a algún ejercicio, sino lo vuelve a consultar hasta que ingrese uno valido.
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente:");
                    }
            } while (op1 < 1 || op1 > 9);

            switch (op1)
            {
                case 1:
                    CalculadoraIMC calculadora = new CalculadoraIMC();
                    Console.WriteLine("------ Calcular su IMC ------");
                        {
                            double peso, altura, imc;
                            Console.Write("Ingrese su peso en kg: ");
                            peso = Convert.ToDouble(Console.ReadLine());

                            if (peso <= 0)
                            // Si no es valido entra en el if, si es valido va de un solo al else.
                                {
                                    Console.WriteLine ("SU peso no es valido, debe ser un numero mayor a 0.");
                                }
                            else
                                {
                                    Console.Write("Ingrese su altura en metros: ");
                                    altura = Convert.ToDouble(Console.ReadLine());
                                    if (altura <= 0)
                                        {
                                            Console.WriteLine ("Su altura no puede ser menor o igual a 0, ingrese un valor valido.");
                                        }
                                    else
                                        {
                                            imc = peso / (altura * altura);
                                            Console.WriteLine("\n Su IMC es: " + imc);
                                            if (imc < 18)
                                                {
                                                    Console.WriteLine("Categoría: Bajo peso");
                                                }
                                            else 
                                                if (imc < 25)
                                                    {
                                                        Console.WriteLine("Categoría: Normal");
                                                    }
                                                else
                                                    if (imc < 30)
                                                        {
                                                            Console.WriteLine("Categoría: Sobrepeso");
                                                        }
                                                    else
                                                        {
                                                            Console.WriteLine("Categoría: Obesidad");
                                                        }
                                        }  
                    
                                }
                        }
                    break;


                case 2:

                int convertir;
                double temperatura, resultado;
                do
                    {
                        Console.WriteLine("\n------ Convertidor de temperatura -----\n");
                        Console.WriteLine("1. Celsius a Fahrenheit\n");
                        Console.WriteLine("2. Celsius a Kelvin\n");
                        Console.WriteLine("3. Fahrenheit a Celsius\n");
                        Console.WriteLine("4. Fahrenheit a Kelvin\n");
                        Console.WriteLine("5. Kelvin a Celsius\n");
                        Console.WriteLine("6. Kelvin a Fahrenheit\n");
                        Console.WriteLine("7. Salir\n");
                        Console.Write("Seleccione una opción: ");
                        while (!int.TryParse(Console.ReadLine(), out convertir) || convertir < 1 || convertir > 7)
                            {
                                Console.Write("Opción inválida. Intente nuevamente: ");
                            }
                        if (convertir == 7)
                            {
                                Console.WriteLine("Saliendo del programa...");
                                break;
                            }
                        Console.Write("Ingrese la temperatura: ");
                        while (!double.TryParse(Console.ReadLine(), out temperatura))
                            {
                                Console.Write("Valor inválido. Ingrese nuevamente: ");
                            }
                        switch (convertir)
                            {
                                case 1:
                                    resultado = (temperatura * 9 / 5) + 32;
                                    Console.WriteLine("Resultado: " + resultado, "°F");
                                    break;

                                case 2:
                                    resultado = temperatura + 273.15;
                                    Console.WriteLine("Resultado: " + resultado, "°K");
                                    break;

                                case 3:
                                    resultado = (temperatura - 32) * 5 / 9;
                                    Console.WriteLine("Resultado: " + resultado, "°C");
                                    break;

                                case 4:
                                    resultado = (temperatura - 32) * 5 / 9 + 273.15;
                                    Console.WriteLine("Resultado: " + resultado, "°K");
                                    break;

                                case 5:
                                    resultado = temperatura - 273.15;
                                    Console.WriteLine("Resultado: " + resultado, "°C");
                                    break;

                                case 6:
                                    resultado = (temperatura - 273.15) * 9 / 5 + 32;
                                    Console.WriteLine("Resultado: " + resultado, "°F");
                                    break;
                            }

                    } while (true);
                    break;


                case 3:
            
                {
                    int monto;
                    Console.Write("Ingrese el monto en lempiras: ");
                    while (!int.TryParse(Console.ReadLine(), out monto) || monto < 0)
                        {
                            Console.Write("Monto inválido. Ingrese un número positivo: ");
                        }
                    int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
                    Console.WriteLine("\nDesglose de billetes:");
                    for (int i = 0; i < billetes.Length; i++)
                        {
                            int cantidad = monto / billetes[i];
                            if (cantidad > 0)
                                {
                                    Console.WriteLine("Billetes de " + billetes[i], " :" + cantidad, "L.");
                                    monto %= billetes[i];
                                }
                        }
                    Console.WriteLine("\nFin del proceso.");
                }
                break;


                case 4:
                    {
                        double monto, tasaAnual, tasaMensual, cuota;
                        int meses;
                        Console.Write("Ingrese el monto del préstamo: ");
                        monto = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la tasa de interés anual (%): ");
                        tasaAnual = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el plazo en meses: ");
                        meses = Convert.ToInt32(Console.ReadLine());
                        // Convertir tasa anual a mensual
                        tasaMensual = (tasaAnual / 100) / 12;
                        // Calcular cuota mensual fija
                        cuota = monto * (tasaMensual * Math.Pow(1 + tasaMensual, meses)) 
                        / (Math.Pow(1 + tasaMensual, meses) - 1);
                        // Calcular total pagado e interés total
                        double totalPagado = cuota * meses;
                        double interésTotal = totalPagado - monto;

                        Console.WriteLine("\n------ Resultado Final ------\n");
                        Console.WriteLine($"Cuota mensual: {cuota:F2}");
                        Console.WriteLine($"Interés total: {interésTotal:F2}");
                        Console.WriteLine($"Total pagado: {totalPagado:F2}" + " Lempiras\n");
                    }
                break;


                case 5: 
                    {
                        Console.Write("Ingrese la primera hora (HH:mm:ss): ");
                        TimeSpan hora1;
                        while (!TimeSpan.TryParse(Console.ReadLine(), out hora1))
                            {
                                Console.Write("Formato inválido. Intente nuevamente: ");
                            }
                        Console.Write("Ingrese la segunda hora (HH:mm:ss): ");
                        TimeSpan hora2;
                        while (!TimeSpan.TryParse(Console.ReadLine(), out hora2))
                        {
                           Console.Write("Formato inválido. Intente nuevamente: ");
                        }
                        // Calcular diferencia total
                        TimeSpan diferencia;               
                        if (hora2 >= hora1)
                        {
                            diferencia = hora2 - hora1;  
                        }
                        else
                        {
                            diferencia = hora1 - hora2;
                        }
                        Console.WriteLine("\n-------- Resultado ------\n");
                        Console.WriteLine("Diferencia: "+ diferencia.Hours + " horas " + diferencia.Minutes + " minutos " + diferencia.Seconds + " segundos");
                        Console.ReadKey();
                    }
                break;


                case 6:
                    {
                        int figura;
                        do
                        {
                            Console.WriteLine("\n------ Menu ------\n");
                            Console.Write("Seleccione una opción: \n");
                            Console.WriteLine("1. Círculo\n");
                            Console.WriteLine("2. Triángulo\n");
                            Console.WriteLine("3. Rectángulo\n");
                            Console.WriteLine("4. Trapecio\n");
                            Console.WriteLine("5. Salir");
                            figura = Convert.ToInt32(Console.ReadLine());
                            switch (figura)
                            {
                                case 1:
                                    {
                                        // Círculo
                                        double radio = LeerPositivo("Ingrese el radio: ");
                                        double areaC = Math.PI * radio * radio;
                                        double perímetroC = 2 * Math.PI * radio;
                                        Console.WriteLine($"Área: {areaC:F2}"); // Se coloca asi para que nos de 2 números después del punto
                                        Console.WriteLine($"Perímetro: {perímetroC:F2}");
                                    }
                                break;

                                case 2:
                                    {
                                        // Triángulo
                                        double lado1 = LeerPositivo("Ingrese lado 1: ");
                                        double lado2 = LeerPositivo("Ingrese lado 2: ");
                                        double lado3 = LeerPositivo("Ingrese lado 3: ");
                                        double altura = LeerPositivo("Ingrese la altura: ");

                                        double areaT = (lado1 * altura) / 2;
                                        double perímetroT = lado1 + lado2 + lado3;

                                        Console.WriteLine($"Área: {areaT:F2}"); // Se coloca asi para que nos de 2 números después del punto
                                        Console.WriteLine($"Perímetro: {perímetroT:F2}"); 
                                    }
                                break;

                                case 3:
                                    {
                                        // Rectángulo
                                        double baseR = LeerPositivo("Ingrese la base: ");
                                        double alturaR = LeerPositivo("Ingrese la altura: ");

                                        double areaR = baseR * alturaR;
                                        double perímetroR = 2 * (baseR + alturaR);

                                        Console.WriteLine($"Área: {areaR:F2}"); // Se coloca asi para que nos de 2 números después del punto
                                        Console.WriteLine($"Perímetro: {perímetroR:F2}");                                       
                                    }
                                break;

                                case 4:
                                    {
                                    // Trapecio
                                    double baseMayor = LeerPositivo("Ingrese base mayor: ");
                                    double baseMenor = LeerPositivo("Ingrese base menor: ");
                                    double ladoA = LeerPositivo("Ingrese lado A: ");
                                    double ladoB = LeerPositivo("Ingrese lado B: ");
                                    double alturaTrap = LeerPositivo("Ingrese la altura: ");

                                    double areaTrap = ((baseMayor + baseMenor) * alturaTrap) / 2;
                                    double perímetroTrap = baseMayor + baseMenor + ladoA + ladoB;

                                    Console.WriteLine($"Área: {areaTrap:F2}"); // Se coloca asi para que nos de 2 números después del punto
                                    Console.WriteLine($"Perímetro: {perímetroTrap:F2}");                                      
                                    }
                                break;

                                case 5:
                                    {
                                        Console.WriteLine("Saliendo del programa...");   
                                    }
                                break;

                                default: Console.WriteLine("Opción inválida.");
                                break;
                            }
                        } while (figura != 5);
                        //Validar números positivos
                        static double LeerPositivo(string mensaje)
                        {
                            double valor;
                            do
                            {
                                Console.Write(mensaje);
                                valor = Convert.ToDouble(Console.ReadLine());
                                if (valor <= 0)
                                    {
                                        Console.WriteLine("Error: El valor debe ser positivo.");                                  
                                    }
                            } while (valor <= 0);
                            return valor;
                        }
                    }
                break;


                case 7:
                    {
                        int opOrigen, opDestino;
                        double valor;
                        Console.WriteLine("\n------ Menu --------");
                        Console.WriteLine("\n----- Seleccione una opción -----");
                        Console.WriteLine("1. Bytes");
                        Console.WriteLine("2. Kilobytes (KB)");
                        Console.WriteLine("3. Megabytes (MB)");
                        Console.WriteLine("4. Gigabytes (GB)");
                        Console.WriteLine("5. Terabytes (TB)");
                        Console.WriteLine("6. Salir");
                        Console.Write("\nSeleccione la unidad de origen: ");
                        while (!int.TryParse(Console.ReadLine(), out opOrigen) || opOrigen < 1 || opOrigen > 6) // comprobar que sea una opción valida.
                        {
                            Console.Write("Opción incorrecta. Intente nuevamente: ");
                        }
                        if (opOrigen == 6)
                        {
                            Console.WriteLine("Saliendo del programa...");    
                            break;
                        }
                        Console.Write("\nSeleccione la unidad de destino: ");
                        Console.WriteLine("\n1. Bytes");
                        Console.WriteLine("2. Kilobytes (KB)");
                        Console.WriteLine("3. Megabytes (MB)");
                        Console.WriteLine("4. Gigabytes (GB)");
                        Console.WriteLine("5. Terabytes (TB)");
                        while (!int.TryParse(Console.ReadLine(), out opDestino) || opDestino < 1 || opDestino > 5) // Comprobar que la opción es valida
                        {
                            Console.Write("Opción incorrecta. Intente nuevamente: ");
                        }
                        Console.Write("Ingrese el valor a convertir: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        // Convertir todo primero a Bytes
                        double valorEnBytes = ConvertirABytes(valor, opOrigen);
                        // Convertir de Bytes a la unidad destino
                        double result = ConvertirDesdeBytes(valorEnBytes, opDestino);
                        Console.WriteLine($"\nResultado: {result:F4}");
                        static double ConvertirABytes(double valor, int unidad)// Se convierte el valor primero a Bytes
                        {
                            switch (unidad)
                            {
                                case 1: return valor; // Bytes
                                case 2: return valor * 1024; // KB
                                case 3: return valor * Math.Pow(1024, 2); // MB
                                case 4: return valor * Math.Pow(1024, 3); // GB
                                case 5: return valor * Math.Pow(1024, 4); // TB
                                default: return 0;
                            }
                        }
                        static double ConvertirDesdeBytes(double bytes, int unidad) // Se convierte de Bytes a lo que el usuario elija
                        {
                            switch (unidad)
                            {
                                case 1: return bytes; // Bytes
                                case 2: return bytes / 1024; // KB
                                case 3: return bytes / Math.Pow(1024, 2); // MB
                                case 4: return bytes / Math.Pow(1024, 3); // GB
                                case 5: return bytes / Math.Pow(1024, 4); // TB
                                default: return 0;
                            }
                        }  
                    } 
                break;


                case 8:
                    {
                        double horas, tarifa;
                        // Validar primero las horas
                        do
                        {
                            Console.Write("Ingrese horas trabajadas: ");
                            horas = Convert.ToDouble(Console.ReadLine());
                            if (horas < 0)
                            {
                                Console.WriteLine("Error: Las horas no pueden ser negativas.");                            
                            }
                        } while (horas < 0);
                        // Validar la tarifa por hora
                        do
                        {
                            Console.Write("Ingrese tarifa por hora: ");
                            tarifa = Convert.ToDouble(Console.ReadLine());
                            if (tarifa <= 0)
                            {
                                Console.WriteLine("Error: La tarifa debe ser mayor que cero.");
                            }
                        } while (tarifa <= 0);
                        double horasNormales = 0;
                        double horasExtras = 0;
                        if (horas > 44)
                        {
                            horasNormales = 44;
                            horasExtras = horas - 44;
                        }
                        else
                        {
                            horasNormales = horas;
                        }
                        double pagoNormal = horasNormales * tarifa;
                        double pagoExtra = horasExtras * tarifa * 1.5;
                        double total = pagoNormal + pagoExtra;

                        Console.WriteLine("\n------ Tarifa Final ------\n");
                        Console.WriteLine("Horas normales: "+ horasNormales);
                        Console.WriteLine($"Pago normal: {pagoNormal:F2}"); // Se coloca asi para que solo salgan dos números después del punto
                        Console.WriteLine("Horas extras: " + horasExtras);
                        Console.WriteLine($"Pago extra (150%): {pagoExtra:F2}");
                        Console.WriteLine($"Total a pagar: {total:F2}");
                    }
                break;


                case 9:
                    {
                        if (op1 == 9)
                        {
                            Console.WriteLine("Saliendo del programa...");
                        }
                        break;
                    }
            }
        break;


        case 2:
            {
                int op2;
                do
                {
                    Console.WriteLine("----- Menu -----\n");
                    Console.WriteLine("Elija una opción: \n");
                    Console.WriteLine("1. Clasificación de triángulos\n");
                    Console.WriteLine("2. Sistema de calificaciones UNAH\n");
                    Console.WriteLine("3. Calculadora de descuentos\n");
                    Console.WriteLine("4. Año bisiesto y días del mes\n");
                    Console.WriteLine("5. Validador de fecha\n");
                    Console.WriteLine("6. Cajero automático\n");
                    Console.WriteLine("7. Salir.\n");
                    while (!int.TryParse(Console.ReadLine(), out op2) || op2 < 1 || op2 > 7)
                    // Valida si el numero ingresado pertenece a algún ejercicio, sino lo vuelve a consultar hasta que ingrese uno valido.
                        {
                            Console.WriteLine("Opción invalida. Intente nuevamente:");
                        }
                } while (op2 < 1 || op2 > 7);

                switch (op2)
                {
                    case 1:
                        {
                            double a, b, c;
                            // Validar lado A
                            do
                            {
                                Console.Write("Ingrese lado A: ");
                                a = Convert.ToDouble(Console.ReadLine());

                                if (a <= 0)
                                {
                                    Console.WriteLine("Error: El valor debe ser positivo.");
                                }
                            } while (a <= 0);
                            // Validar lado B
                            do
                            {
                                Console.Write("Ingrese lado B: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                if (b <= 0)
                                {
                                    Console.WriteLine("Error: El valor debe ser positivo.");
                                }
                            } while (b <= 0);
                            // Validar lado C
                            do
                            {
                                Console.Write("Ingrese lado C: ");
                                c = Convert.ToDouble(Console.ReadLine());
                                if (c <= 0)
                                {
                                    Console.WriteLine("Error: El valor debe ser positivo.");
                                }
                            } while (c <= 0);
                            // Verificar desigualdad triangular
                            if (a + b > c && a + c > b && b + c > a)
                            {
                                Console.WriteLine("\nEs un triangulo valido.");
                                // Clasificación por lados
                                if (a == b && b == c)
                                {
                                    Console.WriteLine("Tipo de triangulo por sus lados: Equilátero");
                                }
                                else
                                if (a == b || a == c || b == c)
                                    {
                                        Console.WriteLine("Tipo de triangulo por sus lados: Isosceles");
                                    }
                                else
                                    {
                                        Console.WriteLine("Tipo por lados: Escaleno");
                                    }

                                // Clasificación por ángulos
                                double a2 = a * a;
                                double b2 = b * b;
                                double c2 = c * c;
                                double mayor = Math.Max(a, Math.Max(b, c));
                                double sumaCuadrados;
                                double mayorCuadrado = mayor * mayor;
                                if (mayor == a)
                                {
                                    sumaCuadrados = b2 + c2;
                                }
                                else
                                {
                                if (mayor == b)
                                    {
                                        sumaCuadrados = a2 + c2;
                                    }
                                else
                                    {
                                        sumaCuadrados = a2 + b2;
                                    }    
                                }
                                if (mayorCuadrado == sumaCuadrados)
                                {
                                    Console.WriteLine("Tipo de triangulo por sus ángulos: Rectángulo");
                                }
                                else
                                {
                                    if (mayorCuadrado < sumaCuadrados)
                                    {
                                        Console.WriteLine("Tipo de triangulo por sus ángulos: Acutángulo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Tipo de triangulo por sus ángulos: Obtusángulo");
                                    }                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo forman un triángulo válido.");
                            } 
                        }
                    break;


                    case 2: 
                        {
                            int nota;
                            // Validar que la nota esté entre 0 y 100
                            do
                            {
                                Console.Write("Ingrese la nota (0-100): ");
                                if (!int.TryParse(Console.ReadLine(), out nota))
                                {
                                    Console.WriteLine("Error: debe ingresar un número entero.");
                                    continue;
                                }
                                if (nota < 0 || nota > 100)
                                {
                                    Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
                                }
                            } while (nota < 0 || nota > 100);
                            // Variables para la letra y descripción
                            string nivel = "";
                            string descripción = "";
                            string resultado = "";
                            // Determinar letra, descripción y aprobado/reprobado
                            if (nota >= 95)
                            {
                                nivel = "Summa Cum Laude";
                                descripción = "Excelente";
                                resultado = "Aprobado";
                            }
                            else
                            {
                            if (nota >= 90)
                            {
                                nivel = "Magna Cum Laude";
                                descripción = "Muy Bueno";
                                resultado = "Aprobado";
                            }
                            else
                                {
                                    if (nota >= 80)
                                    {
                                        nivel = "Cum Laude";
                                        descripción = "Bueno";
                                        resultado = "Aprobado";
                                    }
                                    else
                                    {
                                        if (nota >= 65)
                                        {
                                            nivel = "";
                                            descripción = "Regular";
                                            resultado = "Aprobado";
                                        }
                                        else
                                        {
                                            nivel = "";
                                            descripción = "Insuficiente";
                                            resultado = "Reprobado";
                                        }
                                    }
                                }   
                            }

                            // Mostrar resultados
                            Console.WriteLine("\nNota: " + nota);
                            Console.WriteLine("Distinción honorifica: " + nivel);
                            Console.WriteLine("Descripción: " + descripción);
                            Console.WriteLine("Resultado: " + resultado);
                        }
                    break;


                    case 3:
                        {
                            double monto;
                            // Pedir el monto de compra
                            do
                            {
                                Console.Write("Ingrese el monto de la compra: L. ");
                            } while (!double.TryParse(Console.ReadLine(), out monto) || monto < 0);
                            double descuento = 0;
                            // Determinar porcentaje de descuento
                            if (monto >= 2500)
                            {
                                descuento = 0.15; // 15%
                            }
                            else
                            {
                                if (monto >= 1000)
                                {
                                    descuento = 0.10; // 10%
                                }
                                else
                                {
                                    if (monto >= 500)
                                    descuento = 0.05; // 5%   
                                }
                                
                            }
                            // Calcular valores
                            double montoDescuento = monto * descuento;
                            double precioFinal = monto - montoDescuento;

                            // Mostrar resultados
                            Console.WriteLine($"\nPrecio original: L. {monto:F2}");
                            Console.WriteLine($"Descuento aplicado: L. {montoDescuento:F2} ({descuento * 100}%)");
                            Console.WriteLine($"Precio final: L. {precioFinal:F2}");  
                        }
                    break;


                    case 4:
                        {
                            int año, mes;
                            // Pedir el año
                            do
                            {
                                Console.Write("Ingrese el año: ");
                            } while (!int.TryParse(Console.ReadLine(), out año) || año <= 0);
                            // Pedir el mes
                            do
                            {
                                Console.Write("Ingrese el mes (1-12): ");
                            } while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12);
                            // Determinar si el año es bisiesto
                            bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
                            int días = 0;
                            // Determinar los días del mes
                            switch (mes)
                            {
                                case 1: case 3: case 5: case 7:
                                case 8: case 10: case 12:
                                    días = 31;
                                    break;

                                case 4: case 6: case 9: case 11:
                                    días = 30;
                                    break;

                                case 2:
                                    días = esBisiesto ? 29 : 28;
                                    break;
                            }

                            Console.WriteLine("\nAño: " + año);
                            Console.WriteLine($"¿Es bisiesto?: {(esBisiesto ? "Sí" : "No")}");
                            Console.WriteLine("El mes " + mes + " tiene " + días + " días.");
                        }
                    break;


                    case 5:
                        {
                            int dia, mes, año;
                            // Ingresar año
                            do
                            {
                                Console.Write("Ingrese el año: ");
                            } while (!int.TryParse(Console.ReadLine(), out año) || año <= 0);
                            // Ingresar mes
                            do
                            {
                                Console.Write("Ingrese el mes (1-12): ");
                            } while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12);
                            // Ingresar día
                            do
                            {
                                Console.Write("Ingrese el día: ");
                            } while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1);
                            // Verificar si el año es bisiesto
                            bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
                            int díasMes = 0;
                            // Determinar días del mes
                            switch (mes)
                            {
                                case 1: case 3: case 5: case 7:
                                case 8: case 10: case 12:
                                    díasMes = 31;
                                    break;

                                case 4: case 6: case 9: case 11:
                                    díasMes = 30;
                                    break;

                                case 2:
                                    díasMes = esBisiesto ? 29 : 28;
                                    break;
                            }
                            // Validar fecha
                            if (dia <= díasMes)
                            {
                                Console.WriteLine("\nLa fecha" + dia + " " + mes + " " + año + " es válida.");
                            }
                            else
                            {
                                Console.WriteLine("\nLa fecha " + dia + " " + mes + " " + año + " NO es válida.");
                            }
                        }
                    break;


                    case 6:
                        {
                            int saldo = 50000; // Saldo inicial
                            int retiro;
                            Console.WriteLine("Saldo disponible: L. " + saldo);
                            // Solicitar monto
                            Console.Write("Ingrese el monto a retirar: L. ");
                            if (!int.TryParse(Console.ReadLine(), out retiro) || retiro <= 0)
                            {
                                Console.WriteLine("Monto inválido.");
                                return;
                            }
                            // Validaciones
                            if (retiro % 20 != 0)
                            {
                                Console.WriteLine("El monto debe ser múltiplo de 20.");
                                return;
                            }
                            if (retiro > saldo)
                            {
                                Console.WriteLine("Fondos insuficientes.");
                                return;
                            }
                            // Cálculo de billetes (500, 100, 50, 20)
                            int b500 = retiro / 500;
                            retiro %= 500;
                            int b100 = retiro / 100;
                            retiro %= 100;
                            int b50 = retiro / 50;
                            retiro %= 50;
                            int b20 = retiro / 20;
                            // Actualizar saldo
                            saldo -= (b500 * 500 + b100 * 100 + b50 * 50 + b20 * 20);
                            // Mostrar resultados
                            Console.WriteLine("\nDesglose de billetes:");
                            if (b500 > 0) Console.WriteLine("Billetes de 500: " + b500);
                            if (b100 > 0) Console.WriteLine("Billetes de 100: " + b100);
                            if (b50 > 0) Console.WriteLine("Billetes de 50: " + b50);
                            if (b20 > 0) Console.WriteLine("Billetes de 20: " + b20);
                            Console.WriteLine("\nNuevo saldo: L. " + saldo);  
                        }
                    break;


                    case 7:
                    {
                        if (op2 == 7)
                        {
                            Console.WriteLine("Saliendo del programa...");
                        }
                        break;
                    }
                }
            }
        break;


        case 3:
            {
                int op3;
                do
                {
                    Console.WriteLine("----- Menu -----\n");
                    Console.WriteLine("Elija una opción: \n");
                    Console.WriteLine("1. Tabla de multiplicar extendida\n");
                    Console.WriteLine("2. Números primos en rango\n");
                    Console.WriteLine("3. Serie Fibonacci\n");
                    Console.WriteLine("4. Factorial y combinaciones\n");
                    Console.WriteLine("5. Juego de adivinanza\n");
                    Console.WriteLine("6. Validación de contraseña\n");
                    Console.WriteLine("7. Patrón de asteriscos\n");
                    Console.WriteLine("8. Calculadora con menú\n");
                    Console.WriteLine("9. Salir.\n");
                    while (!int.TryParse(Console.ReadLine(), out op3) || op3 < 1 || op3 > 9)
                    // Valida si el numero ingresado pertenece a algún ejercicio, sino lo vuelve a consultar hasta que ingrese uno valido.
                        {
                            Console.WriteLine("Opción invalida. Intente nuevamente:");
                        }
                } while (op3 < 1 || op3 > 9);

                switch (op3)
                {
                    case 1:
                        {
                            Console.Write(" que numero de tabla deseas? : ");
                            //leemos el numero base
                            int numero = 0;
                            Console.WriteLine("\nTabla del " + numero + ":");
                            // Ciclo del 1 al 12, para las tablas de multiplicar
                            for (int i = 1; i <= 12; i++)
                            {
                                int resultado = numero * i;
                                // Si el número 'i' es menor a 10, le agregamos un espacio para que 
                                // los signos '=' queden uno debajo del otro.
                                string espacio = (i < 10) ? " " : ""; 
                                Console.WriteLine(numero + " x " + espacio + i + " = " + resultado);
                            }
                        }
                    break;


                    case 2:
                        {
                            Console.Write("Ingrese el inicio del rango de los números primos: ");
                            // Inicia consultando el rango con el que quiere iniciar
                            int inicio;
                            while (!int.TryParse(Console.ReadLine(), out inicio))
                            {
                                Console.Write("Entrada inválida. Ingrese un número válido: ");
                            }
                            Console.Write("Ingrese el fin del rango de los números primos: ");
                            int fin;
                            while (!int.TryParse(Console.ReadLine(), out fin))
                            {
                                Console.Write("Entrada inválida. Ingrese un número válido: ");
                            }
                            //Ingresa hasta donde quiere calcular el numero primo
                            int cantidad= 0;
                            for (int i = inicio; i <= fin; i++)
                            //Un ciclo for que vaya desde el datos ingresados como rango "Inicio-Fin"
                            {
                                int divisores = 0;
                                for (int prueba = 1; prueba <= i; prueba++)
                                {
                                    if (i % prueba == 0)
                                    {
                                        divisores++;
                                    }
                                }
                                if (divisores == 2)
                                {
                                    Console.Write(i + " ");
                                    cantidad++;
                                    //Aumento en el contador.. +1, y aumentara hasta contar cada numero primo encontrado en el rango
                                }
                            }
                            Console.WriteLine("\nSe encontraron un total de " + cantidad + " números primos.");
                        }
                    break;


                    case 3:
                        {
                            Console.WriteLine("--- Serie Fibonacci ---");
                            Console.Write("Cuantos números de la serie quieres ver?: ");
                            int n = int.Parse(Console.ReadLine());
                            //Validación de un numero valido, en caso que el usuario ingrese 0
                            if (n <= 0)
                            {
                                Console.WriteLine("Ingresas un numero mayor que 0 o pa fuera");
                            }
                            else
                            {
                            long a = 0; 
                            //a= numero actual
                            long b = 1; 
                            //b= numero siguiente
                            //Long, ya que si el usuario ingresa un numero grande el int no lo va a mostrar completo
                            long sumaTotal = 0;
                            //contador suma inicializada en 0
                            Console.WriteLine("\nSerie generada:");
                            for (int i = 0; i < n; i++)
                            {
                                // Muestra el valor actual de a
                                Console.Write(a + " ");
                                // vamos acumulando la suma
                                sumaTotal = sumaTotal + a;
                                // calcula el siguiente numero de la serie
                                long siguiente = a + b;
                                a = b;
                                b = siguiente;
                            }
                            // Double permite guardar valores decimales exactos
                            double promedio = (double)sumaTotal / n;
                            Console.WriteLine("\n\nSuma total: " + sumaTotal);
                            Console.WriteLine("Promedio: " + promedio);  
                            }
                    }
                    break;


                    case 4:
                        {
                            int n, r;
                            Console.Write("Ingrese el valor de n: ");
                            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                            {
                                Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
                            }

                            Console.Write("Ingrese el valor de r: ");
                            while (!int.TryParse(Console.ReadLine(), out r) || r < 0 || r > n)
                            {
                                Console.Write("Entrada inválida. r debe ser >= 0 y <= n: ");
                            }

                            long factorialN = 1;
                            for (int i = 1; i <= n; i++)
                            {
                                factorialN *= i;
                            }

                            long factorialR = 1;
                            for (int i = 1; i <= r; i++)
                            {
                                factorialR *= i;
                            }

                            long factorialNR = 1;
                            for (int i = 1; i <= (n - r); i++)
                            {
                                factorialNR *= i;
                            }

                            long combinación = factorialN / (factorialR * factorialNR);

                            Console.WriteLine("\nEl factorial de " + n + " (n!) es: " + factorialN);
                            Console.WriteLine("La combinación C " + n + "," + r + " es: " + combinación);
                        }
                    break;



                    case 5:
                        {
                            Random random = new Random();
                            // Iniciar un número random
                            int numeroSecreto = random.Next(1, 101); // 1 a 100
                            int intentosMáximos = 7;
                            int intentosUsados = 0;
                            bool adivino = false;
                            Console.WriteLine("------ Juego de adivinar ------");
                            Console.WriteLine("Tienes 7 intentos para adivinar el número (1-100)\n");
                            while (intentosUsados < intentosMáximos && !adivino)
                            {
                                Console.Write("Intento : " + intentosUsados + 1);

                                if (int.TryParse(Console.ReadLine(), out int numeroUsuario))
                                {
                                    intentosUsados++;

                                    if (numeroUsuario == numeroSecreto)
                                    {
                                        adivino = true;
                                    }
                                    else if (numeroUsuario < numeroSecreto)
                                    {
                                        Console.WriteLine("El número es Mayor.\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El número es Menor.\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Entrada inválida. No se cuenta el intento.\n");
                                }
                            }
                            Console.WriteLine("\n------ Resultado del juego -----\n");

                            if (adivino)
                            {
                                Console.WriteLine("¡Felicidades que bien! Adivinaste el número en " + intentosUsados + " intentos.");
                            }
                            else
                            {
                                Console.WriteLine("No lograste adivinar el número perdedor.");
                                Console.WriteLine("El número secreto era: " + numeroSecreto);
                            }
                            Console.WriteLine("Intentos usados: " + intentosUsados);
                            Console.WriteLine($"Intentos restantes: {intentosMáximos - intentosUsados}");
                        }
                    break;

                    case 6:
                        {
                            string? contraseña;
                            bool valida = false;
                            while (!valida)
                            {
                                Console.Write("Ingrese una contraseña: ");
                                contraseña = Console.ReadLine();

                                if (string.IsNullOrEmpty(contraseña))
                                {
                                    Console.WriteLine("La contraseña no puede estar vacía.\n");
                                    continue;
                                }

                                bool tieneLongitud = contraseña.Length >= 8;
                                bool tieneMayúscula = false;
                                bool tieneMinúscula = false;
                                bool tieneNumero = false;
                                bool tieneEspecial = false;

                                foreach (char c in contraseña)
                                {
                                    if (char.IsUpper(c)) tieneMayúscula = true;
                                    else if (char.IsLower(c)) tieneMinúscula = true;
                                    else if (char.IsDigit(c)) tieneNumero = true;
                                    else tieneEspecial = true;
                                }

                                if (tieneLongitud && tieneMayúscula && tieneMinúscula && tieneNumero && tieneEspecial)
                                {
                                    valida = true;
                                }
                                else
                                {
                                    Console.WriteLine("La contraseña no cumple con los siguientes requisitos:");

                                    if (!tieneLongitud)
                                        Console.WriteLine("- Mínimo 8 caracteres");

                                    if (!tieneMayúscula)
                                        Console.WriteLine("- Al menos una letra mayúscula");

                                    if (!tieneMinúscula)
                                        Console.WriteLine("- Al menos una letra minúscula");

                                    if (!tieneNumero)
                                        Console.WriteLine("- Al menos un número");

                                    if (!tieneEspecial)
                                        Console.WriteLine("- Al menos un carácter especial");

                                    Console.WriteLine();
                                }
                            }

                            Console.WriteLine("\nContraseña válida, felicidades.");  
                        }
                    break;


                    case 7:
                        {
                            int opción;
                            int tamaño;

                            do
                            {
                                Console.WriteLine("\n------ Menu de patrones ------\n");
                                Console.WriteLine("1. Triángulo");
                                Console.WriteLine("2. Triángulo invertido");
                                Console.WriteLine("3. Rombo");
                                Console.WriteLine("4. Cuadrado hueco");
                                Console.WriteLine("5. Salir");
                            } while (!int.TryParse(Console.ReadLine(), out opción) || opción < 1 || opción > 5);

                            if (opción == 5)
                            {
                                return;
                            }
                            Console.Write("Ingrese el tamaño del patrón: ");
                            while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño <= 0)
                            {
                                Console.Write("Ingrese un número válido mayor que 0: ");
                            }
                            switch (opción)
                            {
                                case 1: // Triángulo
                                    for (int i = 1; i <= tamaño; i++)
                                    {
                                        for (int j = 1; j <= i; j++)
                                        {
                                            Console.Write("*");
                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                case 2: // Triángulo invertido
                                    for (int i = tamaño; i >= 1; i--)
                                    {
                                        for (int j = 1; j <= i; j++)
                                        {
                                            Console.Write("*");
                                            Console.WriteLine();                                     
                                        }
                                    }
                                    break;
                                case 3: // Rombo
                                    // Parte superior
                                    for (int i = 1; i <= tamaño; i++)
                                    {
                                        for (int espacios = 1; espacios <= tamaño - i; espacios++)
                                        {
                                            Console.Write(" ");
                                        }

                                        for (int estrellas = 1; estrellas <= (2 * i - 1); estrellas++)
                                        {
                                            Console.Write("*");

                                            Console.WriteLine();
                                        }
                                    }
                                    // Parte inferior
                                    for (int i = tamaño - 1; i >= 1; i--)
                                    {
                                        for (int espacios = 1; espacios <= tamaño - i; espacios++)
                                        {
                                            Console.Write(" ");
                                        }
                                        for (int estrellas = 1; estrellas <= (2 * i - 1); estrellas++)
                                        {
                                            Console.Write("*");

                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                case 4: // Cuadrado hueco
                                    for (int i = 1; i <= tamaño; i++)
                                    {
                                        for (int j = 1; j <= tamaño; j++)
                                        {
                                            if (i == 1 || i == tamaño || j == 1 || j == tamaño)
                                            {
                                                Console.Write("*");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }
                                    break;  
                            }
                        }
                    break;


                    case 8:
                        {
                            double resultado = 0;
                            bool salir = false;
                            Console.WriteLine("\n-------- Calculadora con menu --------\n");
                            while (!salir)
                            {
                                Console.WriteLine("\nResultado actual: " + resultado);
                                Console.WriteLine("1. Sumar");
                                Console.WriteLine("2. Restar");
                                Console.WriteLine("3. Multiplicar");
                                Console.WriteLine("4. Dividir");
                                Console.WriteLine("5. Potencia");
                                Console.WriteLine("6. Raíz cuadrada");
                                Console.WriteLine("7. Porcentaje");
                                Console.WriteLine("8. Salir");
                                Console.Write("Seleccione una opción: ");
                                if (!int.TryParse(Console.ReadLine(), out int opciones))
                                {
                                    Console.WriteLine("Opción inválida.");
                                    continue;
                                }
                                if (opciones == 8)
                                {
                                    salir = true;
                                    continue;
                                }
                                double numero;
                                switch (opciones)
                                {
                                    case 1: // Sumar
                                        {
                                        numero = LeerNumero();
                                        resultado += numero;
                                        }
                                    break;

                                    case 2: // Restar 
                                        {
                                        numero = LeerNumero();
                                        resultado -= numero;        
                                        }
                                    break;

                                    case 3: // Multiplicar
                                        {
                                        numero = LeerNumero();
                                        resultado *= numero;
                                        }
                                    break;

                                    case 4: // Dividir
                                        {
                                        numero = LeerNumero();
                                        if (numero != 0)
                                            {
                                                resultado /= numero;
                                            }
                                        else
                                            {
                                                Console.WriteLine("No se puede dividir entre 0.");
                                            }
                                        }
                                    break;

                                    case 5: // Potencia
                                        {
                                        numero = LeerNumero();
                                        resultado = Math.Pow(resultado, numero);    
                                        }
                                    break;

                                    case 6: // Raíz cuadrada
                                        {
                                        if (resultado >= 0)
                                            {
                                                resultado = Math.Sqrt(resultado);
                                            }
                                        else
                                            {
                                                Console.WriteLine("No se puede sacar raíz de número negativo.");    
                                            }
                                        }
                                    break;

                                    case 7: // Porcentaje
                                        {
                                        numero = LeerNumero();
                                        resultado = (resultado * numero) / 100;    
                                        }
                                    break;

                                    default:Console.WriteLine("Opción inválida.");
                                    break;
                                }
                            }
                            Console.WriteLine("\nCalculadora finalizada.");
                        }

                        static double LeerNumero() // Sirve para leer el numero a ingresar 
                        {
                            double numero;
                            Console.Write("Ingrese el número: ");

                            while (!double.TryParse(Console.ReadLine(), out numero))
                            {
                                Console.Write("Entrada inválida. Ingrese un número válido: ");
                            }
                            return numero;
                        }
                    break;


                    case 9:
                        {
                            if (op3 == 9)
                        {
                            Console.WriteLine("Saliendo del programa...");
                        }
                        break;
                        }
            }
        }   
        break;




        case 4:
            {
                int op4;
                do
                {
                    Console.WriteLine("----- Menu -----\n");
                    Console.WriteLine("Elija una opción: \n");
                    Console.WriteLine("1. Estadísticas de calificaciones\n");
                    Console.WriteLine("2. Búsqueda y ordenamiento\n");
                    Console.WriteLine("3. Rotación de arreglo\n");
                    Console.WriteLine("4. Frecuencia de elementos\n");
                    Console.WriteLine("5. Arreglo de temperaturas\n");
                    Console.WriteLine("6. Salir.\n");
                    while (!int.TryParse(Console.ReadLine(), out op4) || op4 < 1 || op4 > 6)
                    // Valida si el numero ingresado pertenece a algún ejercicio, sino lo vuelve a consultar hasta que ingrese uno valido.
                        {
                            Console.WriteLine("Opción invalida. Intente nuevamente:");
                        }
                } while (op4 < 1 || op4 > 6);

                switch (op4)
                        {
                            case 1:
                                {
                                    int n;
                                    // Validar cantidad de calificaciones
                                    Console.Write("Ingrese la cantidad de calificaciones: ");
                                    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                                    {
                                        Console.Write("Ingrese un número válido mayor que 0: ");
                                    }
                                    double[] notas = new double[n];
                                    int i = 0;
                                    // Ingreso de calificaciones con while 
                                    while (i < n)
                                    {
                                        Console.Write($"Ingrese la calificación #{i + 1}: ");
                                        
                                        if (double.TryParse(Console.ReadLine(), out notas[i]) && notas[i] >= 0 && notas[i] <= 100)
                                        {
                                            i++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
                                        }
                                    }
                                    double suma = 0;
                                    double max = notas[0];
                                    double min = notas[0];
                                    int aprobados = 0;
                                    int reprobados = 0;
                                    i = 0;
                                    // Cálculos con while
                                    while (i < n)
                                    {
                                        suma += notas[i];
                                        if (notas[i] > max)
                                        {
                                            max = notas[i];
                                        }
                                        if (notas[i] < min)
                                        {
                                            min = notas[i];
                                        }
                                        if (notas[i] >= 60)
                                        {
                                            aprobados++;
                                        }
                                        else
                                        {
                                            reprobados++;
                                        }
                                        i++;
                                    }
                                    double promedio = suma / n;
                                    double sumaCuadrados = 0;
                                    i = 0;
                                    while (i < n)
                                    {
                                        sumaCuadrados += Math.Pow(notas[i] - promedio, 2);
                                        i++;
                                    }
                                    double desviación = Math.Sqrt(sumaCuadrados / n);

                                    Console.WriteLine("\n--- Resultados ---");
                                    Console.WriteLine($"Promedio: {promedio:F2}");
                                    Console.WriteLine("Máxima: " + max);
                                    Console.WriteLine("Mínima: " + min);
                                    Console.WriteLine("Aprobados: " + aprobados);
                                    Console.WriteLine($"Reprobados: " + reprobados);
                                    Console.WriteLine($"Desviación estándar: {desviación:F2}");
                                }
                            break;


                            case 2:
                                {
                                    int[] números = new int[10];
                                    int i = 0;
                                    // Llenar arreglo con validación
                                    while (i < 10)
                                    {
                                        Console.Write($"Ingrese el número #{i + 1}: ");
                                        if (int.TryParse(Console.ReadLine(), out números[i]))
                                        {
                                            i++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Número inválido. Intente de nuevo.");
                                        }
                                    }
                                    // Búsqueda lineal
                                    Console.Write("\nIngrese un número a buscar: ");
                                    int buscar;
                                    while (!int.TryParse(Console.ReadLine(), out buscar))
                                    {
                                        Console.Write("Ingrese un número válido: ");
                                    }
                                    bool encontrado = false;
                                    i = 0;
                                    while (i < números.Length)
                                    {
                                        if (números[i] == buscar)
                                        {
                                            Console.WriteLine("Número encontrado en la posición: " + i);
                                            encontrado = true;
                                            break;
                                        }
                                        i++;
                                    }
                                    if (!encontrado)
                                    {
                                        Console.WriteLine("Número no encontrado en el arreglo.");
                                    }

                                    // Encontrar el segundo mayor
                                    int mayor = int.MinValue;
                                    int segundoMayor = int.MinValue;

                                    i = 0;
                                    while (i < números.Length)
                                    {
                                        if (números[i] > mayor)
                                        {
                                            segundoMayor = mayor;
                                            mayor = números[i];
                                        }
                                        else if (números[i] > segundoMayor && números[i] != mayor)
                                        {
                                            segundoMayor = números[i];
                                        }
                                        i++;
                                    }
                                    Console.WriteLine("El segundo mayor número es: " + segundoMayor);
                                    // Ordenamiento burbuja ascendente
                                    int n = números.Length;
                                    int j;
                                    for (i = 0; i < n - 1; i++)
                                    {
                                        for (j = 0; j < n - i - 1; j++)
                                        {
                                            if (números[j] > números[j + 1])
                                            {
                                                int temp = números[j];
                                                números[j] = números[j + 1];
                                                números[j + 1] = temp;
                                            }
                                        }
                                    }
                                    Console.WriteLine("\nArreglo colocado de forma ascendente:");
                                    i = 0;
                                    while (i < n)
                                    {
                                        Console.Write(números[i] + " ");
                                        i++;
                                    }
                                    Console.WriteLine();
                                    // Mostrar elementos en posiciones pares
                                    Console.WriteLine("\nElementos en posiciones pares:");
                                    i = 0;
                                    while (i < n)
                                    {
                                        if (i % 2 == 0)
                                            Console.WriteLine("Posición " + i + ": " + números[i]);
                                        i++;
                                    }
                                }
                            break;


                            case 3:
                                {
                                    Console.Write("Ingrese el tamaño del arreglo: ");
                                    // Ingreso del tamaño del arreglo
                                    int n;
                                    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                                    {
                                        Console.Write("Número inválido. Ingrese un número mayor a 0: ");
                                    }
                                    int[] arr = new int[n];
                                    int i = 0;
                                    // Llenado del arreglo
                                    while (i < n)
                                    {
                                        Console.Write($"Ingrese el elemento #{i + 1}: ");
                                        if (int.TryParse(Console.ReadLine(), out arr[i]))
                                        {
                                            i++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Número inválido, no sea tonto. Intente de nuevo.");
                                        }
                                    }

                                    // Menú
                                    int opción = 0;
                                    while (opción != 4)
                                    {
                                        Console.WriteLine("\n--- Menu ---");
                                        Console.WriteLine("1. Rotar K posiciones a la izquierda");
                                        Console.WriteLine("2. Rotar K posiciones a la derecha");
                                        Console.WriteLine("3. Invertir el arreglo");
                                        Console.WriteLine("4. Salir");
                                        Console.Write("Seleccione una opción: ");
                                        if (!int.TryParse(Console.ReadLine(), out opción))
                                        {
                                            Console.WriteLine("Opción inválida.");
                                            continue;
                                        }

                                        switch (opción)
                                        {
                                            case 1:
                                                {
                                                    Console.Write("Ingrese K posiciones: ");
                                                    int kIzq = int.Parse(Console.ReadLine());
                                                    RotarIzquierda(arr, kIzq);
                                                    Console.WriteLine("Arreglo rotado a la izquierda:");
                                                    ImprimirArreglo(arr);
                                                }
                                            break;

                                            case 2:
                                                {
                                                    Console.Write("Ingrese K posiciones: ");
                                                    int kDer = int.Parse(Console.ReadLine());
                                                    RotarDerecha(arr, kDer);
                                                    Console.WriteLine("Arreglo rotado a la derecha:");
                                                    ImprimirArreglo(arr);

                                                }
                                            break;

                                            case 3:
                                                {
                                                    Array.Reverse(arr);
                                                    Console.WriteLine("Arreglo invertido:");
                                                    ImprimirArreglo(arr);
                                                }
                                            break;

                                            case 4:
                                                {
                                                    Console.WriteLine("Saliendo espere...");
                                                }
                                                break;

                                            default: Console.WriteLine("Opción inválida.");
                                                break;
                                        }
                                    }
                                }

                                // Método para imprimir arreglo
                                static void ImprimirArreglo(int[] arr)
                                {
                                    foreach (int num in arr)
                                        {
                                            Console.Write(num + " ");
                                        Console.WriteLine();
                                        }
                                }

                                // Rotar a la izquierda
                                static void RotarIzquierda(int[] arr, int k)
                                {
                                    int n = arr.Length;
                                    k = k % n;
                                    int[] temp = new int[k];
                                    Array.Copy(arr, temp, k);
                                    Array.Copy(arr, k, arr, 0, n - k);
                                    Array.Copy(temp, 0, arr, n - k, k);
                                }

                                // Rotar a la derecha
                                static void RotarDerecha(int[] arr, int k)
                                {
                                    int n = arr.Length;
                                    k = k % n;
                                    int[] temp = new int[k];
                                    Array.Copy(arr, n - k, temp, 0, k);
                                    Array.Copy(arr, 0, arr, k, n - k);
                                    Array.Copy(temp, 0, arr, 0, k);
                                }
                            break;


                            case 4:
                                {
                                    int[] números = new int[20];
                                    int[] frecuencia = new int[10]; // índices 0-9 representan números 1-10
                                    Random rnd = new Random();

                                    // Generar 20 números aleatorios entre 1 y 10
                                    for (int i = 0; i < 20; i++)
                                    {
                                        números[i] = rnd.Next(1, 11); // 1 a 10
                                    }

                                    // Contar frecuencia
                                    for (int i = 0; i < 20; i++)
                                    {
                                        frecuencia[números[i] - 1]++;
                                    }

                                    // Mostrar números generados
                                    Console.WriteLine("Números generados:");
                                    foreach (int num in números)
                                        Console.Write(num + " ");
                                    Console.WriteLine("\n");
                                    // Mostrar frecuencia de cada número
                                    Console.WriteLine("Frecuencia de cada número:");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.WriteLine($"{i + 1}: {frecuencia[i]}");
                                    }
                                    // Encontrar más y menos frecuente
                                    int maxFreq = frecuencia[0], minFreq = frecuencia[0];
                                    int numMax = 1, numMin = 1;
                                    for (int i = 1; i < 10; i++)
                                    {
                                        if (frecuencia[i] > maxFreq)
                                        {
                                            maxFreq = frecuencia[i];
                                            numMax = i + 1;
                                        }
                                        if (frecuencia[i] < minFreq)
                                        {
                                            minFreq = frecuencia[i];
                                            numMin = i + 1;
                                        }
                                    }

                                    Console.WriteLine("\nNúmero más frecuente: " + numMax + maxFreq + " veces)");
                                    Console.WriteLine("Número menos frecuente: " + numMin + minFreq + " veces)");
                                }
                            break;


                            case 5:
                                {
                                    const int días = 7;
                                    double[] temperaturas = new double[días];
                                    int i = 0;

                                    // Ingreso de temperaturas
                                    while (i < días)
                                    {
                                        Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                                        if (double.TryParse(Console.ReadLine(), out temperaturas[i]))
                                        {
                                            i++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Valor no válido. Intente de nuevo.");
                                        }
                                    }

                                    // Calcular promedio
                                    double suma = 0;
                                    i = 0;
                                    while (i < días)
                                    {
                                        suma += temperaturas[i];
                                        i++;
                                    }
                                    double promedio = suma / días;
                                    Console.WriteLine($"\nPromedio semanal: {promedio:F2}°");

                                    // Mostrar días sobre el promedio
                                    Console.WriteLine("Días con temperatura sobre el promedio:");
                                    i = 0;
                                    while (i < días)
                                    {
                                        if (temperaturas[i] > promedio)
                                            Console.WriteLine($"Día {i + 1}: {temperaturas[i]}°");
                                        i++;
                                    }

                                    // Encontrar día más caluroso y más frío
                                    double max = temperaturas[0], min = temperaturas[0];
                                    int diaMax = 1, diaMin = 1;
                                    i = 1;
                                    while (i < días)
                                    {
                                        if (temperaturas[i] > max)
                                        {
                                            max = temperaturas[i];
                                            diaMax = i + 1;
                                        }
                                        if (temperaturas[i] < min)
                                        {
                                            min = temperaturas[i];
                                            diaMin = i + 1;
                                        }
                                        i++;
                                    }
                                    Console.WriteLine("\nDía más caluroso: Día " + diaMax + "con " + max + " °");
                                    Console.WriteLine($"Día más frío: Día " + diaMin + "con " + min + " °");
                                    // Variación entre días consecutivos
                                    Console.WriteLine("\nVariación entre días consecutivos:");
                                    i = 0;
                                    while (i < días - 1)
                                    {
                                        double variación = temperaturas[i + 1] - temperaturas[i];
                                        Console.WriteLine($"Día {i + 1} → Día {i + 2}: {variación:+0.##;-0.##;0}°");
                                        i++;
                                    }
                                }
                            break;


                            case 6:
                                {
                                    if (op4 == 6)
                                    {
                                        Console.WriteLine("Saliendo del programa...");
                                    }
                                    break;
                                }
                        }
                    }
                break;
                    
                    

        case 5:
            {
                int op5;
                do
                {
                    Console.WriteLine("----- Menu -----\n");
                    Console.WriteLine("Elija una opción: \n");
                    Console.WriteLine("1. Matriz de notas por parcial\n");
                    Console.WriteLine("2. Juego de Gato (Tic-Tac-Toe)\n");
                    Console.WriteLine("3. Inventario simple\n"); 
                    Console.WriteLine("4. Salir.\n");
                    while (!int.TryParse(Console.ReadLine(), out op5) || op5 < 1 || op5 > 4)
                    // Valida si el numero ingresado pertenece a algún ejercicio, sino lo vuelve a consultar hasta que ingrese uno valido.
                        {
                            Console.WriteLine("Opción invalida. Intente nuevamente:");
                        }
                } while (op5 < 1 || op5 > 4);
                
                switch(op5)
                    {
                        case 1:
                            {
                                Console.Write("Ingrese el número de estudiantes: ");
                                int n;
                                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                                {
                                    Console.Write("Número inválido. Ingrese un valor mayor a 0: ");
                                }
                                int parciales = 3;
                                double[,] notas = new double[n, parciales];
                                int i = 0, j;

                                // Llenar la matriz de notas
                                while (i < n)
                                {
                                    j = 0;
                                    while (j < parciales)
                                    {
                                        Console.Write($"Ingrese la nota del estudiante {i + 1}, parcial {j + 1}: ");
                                        if (double.TryParse(Console.ReadLine(), out notas[i, j]) && notas[i, j] >= 0 && notas[i, j] <= 100)
                                        {
                                            j++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
                                        }
                                    }
                                    i++;
                                }

                                // Promedio por estudiante
                                double[] promedioEstudiante = new double[n];
                                i = 0;
                                while (i < n)
                                {
                                    double suma = 0;
                                    j = 0;
                                    while (j < parciales)
                                    {
                                        suma += notas[i, j];
                                        j++;
                                    }
                                    promedioEstudiante[i] = suma / parciales;
                                    Console.WriteLine($"Promedio estudiante {i + 1}: {promedioEstudiante[i]:F2}");
                                    i++;
                                }

                                // Promedio por parcial
                                double[] promedioParcial = new double[parciales];
                                j = 0;
                                while (j < parciales)
                                {
                                    double suma = 0;
                                    i = 0;
                                    while (i < n)
                                    {
                                        suma += notas[i, j];
                                        i++;
                                    }
                                    promedioParcial[j] = suma / n;
                                    Console.WriteLine($"Promedio parcial {j + 1}: {promedioParcial[j]:F2}");
                                    j++;
                                }

                                // Estudiante con mejor promedio
                                double mejorProm = promedioEstudiante[0];
                                int estudianteMejor = 1;
                                i = 1;
                                while (i < n)
                                {
                                    if (promedioEstudiante[i] > mejorProm)
                                    {
                                        mejorProm = promedioEstudiante[i];
                                        estudianteMejor = i + 1;
                                    }
                                    i++;
                                }
                                Console.WriteLine($"\nEstudiante con mejor promedio: {estudianteMejor} ({mejorProm:F2})");

                                // Parcial más difícil (menor promedio)
                                double minParcial = promedioParcial[0];
                                int parcialDifícil = 1;
                                j = 1;
                                while (j < parciales)
                                {
                                    if (promedioParcial[j] < minParcial)
                                    {
                                        minParcial = promedioParcial[j];
                                        parcialDifícil = j + 1;
                                    }
                                    j++;
                                }
                                Console.WriteLine($"Parcial más difícil: {parcialDifícil} ({minParcial:F2})");
                            }
                        break;


                        case 2:
                            {
                                bool jugarDeNuevo = true;
                                while (jugarDeNuevo)
                                {
                                    char[,] tablero = new char[3, 3];
                                    InicializarTablero(tablero);
                                    char jugadorActual = 'X';
                                    bool juegoTerminado = false;
                                    while (!juegoTerminado)
                                    {
                                        MostrarTablero(tablero);
                                        Console.WriteLine($"\nTurno del jugador {jugadorActual}");
                                        int fila, columna;

                                        // Validar movimiento
                                        while (true)
                                        {
                                            Console.Write("Ingrese fila (1-3): ");
                                            fila = int.Parse(Console.ReadLine()) - 1;
                                            Console.Write("Ingrese columna (1-3): ");
                                            columna = int.Parse(Console.ReadLine()) - 1;
                                            if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3)
                                            {
                                                if (tablero[fila, columna] == ' ')
                                                {
                                                    tablero[fila, columna] = jugadorActual;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Esa posición ya está ocupada. Intente otra.");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Posición inválida. Filas y columnas van de 1 a 3.");
                                            }
                                        }

                                        // Verificar ganador
                                        if (HayGanador(tablero, jugadorActual))
                                        {
                                            MostrarTablero(tablero);
                                            Console.WriteLine($"\n¡Felicidades! Jugador {jugadorActual} ganó.");
                                            juegoTerminado = true;
                                        }
                                        // Verificar empate
                                        else
                                        {
                                            if (Empate(tablero))
                                            {
                                                MostrarTablero(tablero);
                                                Console.WriteLine("\n¡Empate!");
                                                juegoTerminado = true;
                                            }
                                            else
                                            {
                                                // Cambiar jugador
                                                jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                                            }
                                        }
                                    }

                                    // Preguntar si quieren jugar de nuevo
                                    Console.Write("\n¿Desean jugar de nuevo? (s/n): ");
                                    string respuesta = Console.ReadLine().ToLower();
                                    jugarDeNuevo = (respuesta == "s");
                                }
                            }

                            static void InicializarTablero(char[,] tablero)
                            {
                                for (int i = 0; i < 3; i++)
                                    for (int j = 0; j < 3; j++)
                                        tablero[i, j] = ' ';
                            }

                            static void MostrarTablero(char[,] tablero)
                            {
                                Console.Clear();
                                Console.WriteLine("  1   2   3");
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.Write(i + 1);
                                    for (int j = 0; j < 3; j++)
                                    {
                                        Console.Write(" " + tablero[i, j]);
                                        if (j < 2) Console.Write(" |");
                                    }
                                    Console.WriteLine();
                                    if (i < 2) Console.WriteLine(" ---+---+---");
                                }
                            }

                            static bool HayGanador(char[,] tablero, char jugador)
                            {
                                // Filas y columnas
                                for (int i = 0; i < 3; i++)
                                {
                                    if ((tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) ||
                                        (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador))
                                        return true;
                                }
                                // Diagonales
                                if ((tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) ||
                                    (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador))
                                    return true;

                                return false;
                            }

                            static bool Empate(char[,] tablero)
                            {
                                for (int i = 0; i < 3; i++)
                                    for (int j = 0; j < 3; j++)
                                        if (tablero[i, j] == ' ')
                                            return false;
                                return true;
                            }
                        break;


                        case 3:
                            {
                                const int n = 5;
                                int[] códigos = new int[n];
                                string[] nombres = new string[n];
                                int[] cantidades = new int[n];
                                double[] precios = new double[n];

                                // Ingreso de productos usando while
                                int i = 0;
                                while (i < n)
                                {
                                    Console.WriteLine($"\nProducto #{i + 1}:");

                                    // Código
                                    Console.Write("Código: ");
                                    while (!int.TryParse(Console.ReadLine(), out códigos[i]))
                                    {
                                        Console.Write("Código inválido. Ingrese un número entero: ");
                                    }

                                    // Nombre
                                    Console.Write("Nombre: ");
                                    nombres[i] = Console.ReadLine();

                                    // Cantidad
                                    Console.Write("Cantidad: ");
                                    while (!int.TryParse(Console.ReadLine(), out cantidades[i]) || cantidades[i] < 0)
                                    {
                                        Console.Write("Cantidad inválida. Ingrese un número entero mayor o igual a 0: ");
                                    }

                                    // Precio
                                    Console.Write("Precio: ");
                                    while (!double.TryParse(Console.ReadLine(), out precios[i]) || precios[i] < 0)
                                    {
                                        Console.Write("Precio inválido. Ingrese un número mayor o igual a 0: ");
                                    }

                                    i++;
                                }

                                int opción = 0;

                                // Menú principal usando while
                                while (opción != 5)
                                {
                                    Console.WriteLine("\n--- MENÚ ---");
                                    Console.WriteLine("1. Mostrar inventario");
                                    Console.WriteLine("2. Buscar producto por código");
                                    Console.WriteLine("3. Actualizar cantidad de producto");
                                    Console.WriteLine("4. Calcular valor total del inventario");
                                    Console.WriteLine("5. Salir");
                                    Console.Write("Seleccione una opción: ");

                                    if (!int.TryParse(Console.ReadLine(), out opción))
                                    {
                                        Console.WriteLine("Opción inválida.");
                                        continue;
                                    }

                                    if (opción == 1)
                                    {
                                        Console.WriteLine("\n--- Inventario ---");
                                        i = 0;
                                        while (i < n)
                                        {
                                            Console.WriteLine($"Código: {códigos[i]}, Nombre: {nombres[i]}, Cantidad: {cantidades[i]}, Precio: {precios[i]:C2}");
                                            i++;
                                        }
                                    }
                                    else if (opción == 2)
                                    {
                                        Console.Write("Ingrese el código del producto a buscar: ");
                                        int códigoBuscar;
                                        while (!int.TryParse(Console.ReadLine(), out códigoBuscar))
                                        {
                                            Console.Write("Código inválido. Ingrese un número entero: ");
                                        }

                                        bool encontrado = false;
                                        i = 0;
                                        while (i < n)
                                        {
                                            if (códigos[i] == códigoBuscar)
                                            {
                                                Console.WriteLine($"Producto encontrado: Código: {códigos[i]}, Nombre: {nombres[i]}, Cantidad: {cantidades[i]}, Precio: {precios[i]:C2}");
                                                encontrado = true;
                                                break;
                                            }
                                            i++;
                                        }

                                        if (!encontrado)
                                            Console.WriteLine("Producto no encontrado.");
                                    }
                                    else if (opción == 3)
                                    {
                                        Console.Write("Ingrese el código del producto a actualizar: ");
                                        int códigoActualizar;
                                        while (!int.TryParse(Console.ReadLine(), out códigoActualizar))
                                        {
                                            Console.Write("Código inválido. Ingrese un número entero: ");
                                        }

                                        bool encontrado = false;
                                        i = 0;
                                        while (i < n)
                                        {
                                            if (códigos[i] == códigoActualizar)
                                            {
                                                Console.Write($"Cantidad actual: {cantidades[i]}. Ingrese nueva cantidad: ");
                                                while (!int.TryParse(Console.ReadLine(), out cantidades[i]) || cantidades[i] < 0)
                                                {
                                                    Console.Write("Cantidad inválida. Ingrese un número entero mayor o igual a 0: ");
                                                }
                                                Console.WriteLine("Cantidad actualizada.");
                                                encontrado = true;
                                                break;
                                            }
                                            i++;
                                        }

                                        if (!encontrado)
                                            Console.WriteLine("Producto no encontrado.");
                                    }
                                    else if (opción == 4)
                                    {
                                        double valorTotal = 0;
                                        i = 0;
                                        while (i < n)
                                        {
                                            valorTotal += cantidades[i] * precios[i];
                                            i++;
                                        }
                                        Console.WriteLine($"\nValor total del inventario: {valorTotal:C2}");
                                    }
                                    else if (opción == 5)
                                    {
                                        Console.WriteLine("Saliendo...");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción inválida.");
                                    }
                                }
                            }
                        break;


                        case 4:
                            {
                                if (op5 == 4)
                                {
                                    Console.WriteLine("Saliendo del programa...");
                                }
                                break;
                            }
                    }
            }
        break;


        case 6:
            {
                if (op == 6)
                        {
                            Console.WriteLine("Saliendo del programa...");
                        }
                        break;
            }
    }
}
