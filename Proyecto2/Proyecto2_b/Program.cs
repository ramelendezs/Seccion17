// Codigo Base de proyecto No. 2 de Roberth Melendez
using System;
using System.Collections.Generic;

class Program
{
    // Definición de parametros para los datos de la cuenta


    static string tipoCuenta, nombre, direccion, telefono, dpi;
    static double saldo = 2500.00;
    static int contadorAbonos = 0;
    static List<string> transacciones = new List<string>();
    static List<CuentaTercero> cuentasTerceros = new List<CuentaTercero>();

    static void Main(string[] args)
    {
        // Pedir al usuario que introduzca la información de la cuenta
        Console.WriteLine("Ingrese el tipo de cuenta (a. monetaria quetzales, b. monetaria dólares, c. ahorro quetzales, d. ahorro dólares):");
        tipoCuenta = Console.ReadLine();

        Console.WriteLine("teclee su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("DPI (5 carácteres maximo):");
        dpi = Console.ReadLine();

        // validacion de error de DPI ingresado
        while (dpi.Length != 5 || !EsNumerico(dpi))
        {
            Console.WriteLine("DPI inválido. Por favor ingrese denuevo un DPI válido de 5 caracteres maximo:");
            dpi = Console.ReadLine();
        }

        Console.WriteLine("dirección:");
        direccion = Console.ReadLine();

        Console.WriteLine("número de teléfono:");
        telefono = Console.ReadLine();

        // Mostrar menú (seleccion de operacion a realizar)
        int opcion;
        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Ver información de la cuenta");
            Console.WriteLine("2. Comprar producto financiero");
            Console.WriteLine("3. Vender producto financiero");
            Console.WriteLine("4. Abonar a cuenta");
            Console.WriteLine("5. Simular paso del tiempo");
            Console.WriteLine("6. Mantenimiento de cuentas de terceros");
            Console.WriteLine("7. Realizar transferencias a otras cuentas");
            Console.WriteLine("8. Pago de servicios");
            Console.WriteLine("9. Imprimir informe de transacciones");
            Console.WriteLine("10. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    VerInformacionCuenta();
                    break;
                case 2:
                    ComprarProductoFinanciero();
                    break;
                case 3:
                    VenderProductoFinanciero();
                    break;
                case 4:
                    AbonarCuenta();
                    break;
                case 5:
                    SimularPasoTiempo();
                    break;
                case 6:
                    MantenimientoCuentasTerceros();
                    break;
                case 7:
                    RealizarTransferencias();
                    break;
                case 8:
                    PagoServicios();
                    break;
                case 9:
                    ImprimirInformeTransacciones();
                    break;
                case 10:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor seleccione una opción válida del menú.");
                    break;
            }

        } while (opcion != 10);
    }

    static void VerInformacionCuenta()
    {
        Console.WriteLine("\nInformación de la cuenta:");
        Console.WriteLine($"Tipo de cuenta: {tipoCuenta}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"DPI: {dpi}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Teléfono: {telefono}");
        Console.WriteLine($"Saldo: Q{saldo}");
        Console.WriteLine("Transacciones:");
        foreach (var transaccion in transacciones)
        {
            Console.WriteLine(transaccion);
        }
    }

    static void ComprarProductoFinanciero()
    {
        double monto = saldo * 0.10;
        saldo -= monto;
        RegistrarTransaccion(DateTime.Now, monto, "Débito");
        Console.WriteLine($"Compra realizada. Saldo actual: Q{saldo}");
    }

    static void VenderProductoFinanciero()
    {
        if (saldo > 500.00)
        {
            double monto = saldo * 0.11;
            saldo += monto;
            RegistrarTransaccion(DateTime.Now, monto, "Crédito");
            Console.WriteLine($"Venta concluida con exito. Saldo actual: Q{saldo}");
        }
        else
        {
            Console.WriteLine("No se puede llevar acabo la venta. no hay saldo suficiente.");
        }
    }

    static void AbonarCuenta()
    {
        if (contadorAbonos < 2 && saldo > 500.00)
        {
            double monto = saldo;
            saldo *= 2;
            contadorAbonos++;
            RegistrarTransaccion(DateTime.Now, monto, "Crédito");
            Console.WriteLine($"Abono realizado con exito. Saldo actual: Q{saldo}");
        }
        else
        {
            Console.WriteLine("No se puede realizar el abono. límite mensual alcanzado o el saldo es insuficientemente.");
        }
    }

    static void SimularPasoTiempo()
    {
        Console.WriteLine("elija periodo de capitalización (1 para una vez al mes, 2 para dos veces al mes):");
        int periodo = int.Parse(Console.ReadLine());
        double interesSimple = 0.02;
        double interes = saldo * interesSimple * periodo / 12;
        saldo += interes;
        RegistrarTransaccion(DateTime.Now, interes, "Crédito");
        Console.WriteLine($"Simulación realizada. Saldo actual: Q{saldo}");
    }

    static void MantenimientoCuentasTerceros()
    {
        Console.WriteLine("Seleccione una opción: 1. Crear 2. Eliminar 3. Actualizar");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                CrearCuentaTercero();
                break;
            case 2:
                EliminarCuentaTercero();
                break;
            case 3:
                ActualizarCuentaTercero();
                break;
            default:
                Console.WriteLine("Opción no válida. porfavor intente nuevamente");
                break;
        }
    }

    static void CrearCuentaTercero()
    {
        CuentaTercero nuevaCuenta = new CuentaTercero
        {
            Id = cuentasTerceros.Count + 1
        };
        Console.WriteLine("Ingrese el nombre del titular de la cuenta:");
        nuevaCuenta.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el número de cuenta:");
        nuevaCuenta.NumeroCuenta = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del banco:");
        nuevaCuenta.NombreBanco = Console.ReadLine();
        Console.WriteLine("Ingrese la moneda (quetzales o dólares):");
        nuevaCuenta.Moneda = Console.ReadLine();
        cuentasTerceros.Add(nuevaCuenta);
        Console.WriteLine("Cuenta creada exitosamente.");
    }

    static void EliminarCuentaTercero()
    {
        Console.WriteLine("Ingrese el ID de la cuenta a eliminar:");
        int id = int.Parse(Console.ReadLine());
        var cuenta = cuentasTerceros.Find(c => c.Id == id);
        if (cuenta != null)
        {
            cuentasTerceros.Remove(cuenta);
            Console.WriteLine("Cuenta eliminada satisfactoriamente.");
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
        }
    }

    static void ActualizarCuentaTercero()
    {
        Console.WriteLine("Ingrese el ID de la cuenta a actualizar:");
        int id = int.Parse(Console.ReadLine());
        var cuenta = cuentasTerceros.Find(c => c.Id == id);
        if (cuenta != null)
        {
            Console.WriteLine("Ingrese el nombre del titular de la cuenta:");
            cuenta.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cuenta:");
            cuenta.NumeroCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del banco:");
            cuenta.NombreBanco = Console.ReadLine();
            Console.WriteLine("Ingrese la moneda (quetzales o dólares):");
            cuenta.Moneda = Console.ReadLine();
            Console.WriteLine("Cuenta actualizada satisfactoriamente.");
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
        }
    }

    static void RealizarTransferencias()
    {
        Console.WriteLine("Ingrese el ID de la cuenta a la que desea transferir:");
        int id = int.Parse(Console.ReadLine());
        var cuenta = cuentasTerceros.Find(c => c.Id == id);
        if (cuenta != null)
        {
            Console.WriteLine("Ingrese el monto a transferir (200 o 2000):");
            double monto = double.Parse(Console.ReadLine());
            if (monto == 200 || monto == 2000)
            {
                if (saldo >= monto)
                {
                    saldo -= monto;
                    RegistrarTransaccion(DateTime.Now, monto, "Débito");
                    Console.WriteLine($"Transferencia realizada a la cuenta {cuenta.NumeroCuenta} en {cuenta.NombreBanco}. Saldo actual: Q{saldo}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para llevar acabo la transferencia.");
                }
            }
            else
            {
                Console.WriteLine("Monto de transferencia inválido. Solo se permite transferencias de 200 o 2000 quetzales.");
            }
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
        }
    }

    static void PagoServicios()
    {
        Console.WriteLine("Seleccione el servicio a pagar: 1. Empresa de agua 2. Empresa Eléctrica 3. Telefónica");
        int servicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el monto del pago:");
        double monto = double.Parse(Console.ReadLine());
        if (saldo >= monto)
        {
            saldo -= monto;
            RegistrarTransaccion(DateTime.Now, monto, "Débito");
            Console.WriteLine($"Pago realizado. Saldo actual: Q{saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar el pago.");
        }
    }

    static void ImprimirInformeTransacciones()
    {
        Console.WriteLine("Informe de transacciones:");
        foreach (var transaccion in transacciones)
        {
            Console.WriteLine(transaccion);
        }
    }

    static void RegistrarTransaccion(DateTime fechaHora, double monto, string tipo)
    {
        string registro = $"{fechaHora} - {tipo}: Q{monto}";
        transacciones.Add(registro);
    }

    // Procedimiento para comprobar si una cadena es numérica
    static bool EsNumerico(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }
}

class CuentaTercero
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string NumeroCuenta { get; set; }
    public string NombreBanco { get; set; }
    public string Moneda { get; set; }
}
