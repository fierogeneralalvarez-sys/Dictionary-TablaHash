using Dictionary_HashTable_WF;
using System;

class Program
{
    static void Main()
    {
        HashTable<string, string> tabla = new HashTable<string, string>();
        Diccionario<string, string> diccionario = new Diccionario<string, string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" MENÚ PRINCIPAL ");
            Console.WriteLine("1. Usar Tabla Hash");
            Console.WriteLine("2. Usar Diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("\nSelecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MenuTablaHash(tabla);
                    break;
                case "2":
                    MenuDiccionario(diccionario);
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MenuTablaHash(HashTable<string, string> tabla)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" MENÚ TABLA HASH ");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Mostrar tabla");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Mostrar claves");
            Console.WriteLine("8. Mostrar valores");
            Console.WriteLine("9. Verificar clave");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("\nSelecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Clave: ");
                    string clave = Console.ReadLine();
                    Console.Write("Valor: ");
                    string valor = Console.ReadLine();
                    Console.WriteLine(tabla.Insertar(clave, valor)
                        ? "Clave insertada."
                        : "Clave existente, valor reemplazado.");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Buscar clave o valor: ");
                    string filtro = Console.ReadLine();
                    var resultados = tabla.Buscar(filtro);
                    if (resultados.Count > 0)
                    {
                        Console.WriteLine("Coincidencias encontradas:");
                        foreach (var r in resultados)
                            Console.WriteLine($"Clave: {r.Clave}, Valor: {r.Valor}");
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron coincidencias.");
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Clave a eliminar: ");
                    Console.WriteLine(tabla.Eliminar(Console.ReadLine())
                        ? "Clave eliminada."
                        : "Clave no encontrada.");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine(tabla.Mostrar());
                    Console.ReadKey();
                    break;

                case "5":
                    tabla.Clear();
                    Console.WriteLine("Tabla hash limpiada.");
                    Console.ReadKey();
                    break;

                case "6":
                    Console.WriteLine($"Cantidad de elementos: {tabla.Count()}");
                    Console.ReadKey();
                    break;

                case "7":
                    var claves = tabla.GetKeys();
                    Console.WriteLine("Claves:");
                    if (claves.Count == 0) Console.WriteLine("(Sin elementos)");
                    else foreach (var c in claves) Console.WriteLine($"- {c}");
                    Console.ReadKey();
                    break;

                case "8":
                    var valores = tabla.GetValues();
                    Console.WriteLine("Valores:");
                    if (valores.Count == 0) Console.WriteLine("(Sin elementos)");
                    else foreach (var v in valores) Console.WriteLine($"- {v}");
                    Console.ReadKey();
                    break;

                case "9":
                    Console.Write("Clave a verificar: ");
                    Console.WriteLine(tabla.ContainsKey(Console.ReadLine())
                        ? "La clave existe."
                        : "La clave no existe.");
                    Console.ReadKey();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MenuDiccionario(Diccionario<string, string> diccionario)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" MENÚ DICCIONARIO ");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Mostrar diccionario");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Mostrar claves");
            Console.WriteLine("8. Mostrar valores");
            Console.WriteLine("9. Verificar clave");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("\nSelecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Clave: ");
                    string clave = Console.ReadLine();
                    Console.Write("Valor: ");
                    string valor = Console.ReadLine();
                    Console.WriteLine(diccionario.Insertar(clave, valor)
                        ? "Clave insertada."
                        : "Clave existente, valor reemplazado.");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Buscar clave o valor: ");
                    string filtroDic = Console.ReadLine();
                    var resultadosDic = diccionario.Buscar(filtroDic);
                    if (resultadosDic.Count > 0)
                    {
                        Console.WriteLine("Coincidencias encontradas:");
                        foreach (var r in resultadosDic)
                            Console.WriteLine($"Clave: {r.Clave}, Valor: {r.Valor}");
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron coincidencias.");
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Clave a eliminar: ");
                    Console.WriteLine(diccionario.Eliminar(Console.ReadLine())
                        ? "Clave eliminada."
                        : "Clave no encontrada.");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.WriteLine(diccionario.Mostrar());
                    Console.ReadKey();
                    break;

                case "5":
                    diccionario.Clear();
                    Console.WriteLine("Diccionario limpiado.");
                    Console.ReadKey();
                    break;

                case "6":
                    Console.WriteLine($"Cantidad de elementos: {diccionario.Count()}");
                    Console.ReadKey();
                    break;

                case "7":
                    var clavesDic = diccionario.GetKeys();
                    Console.WriteLine("Claves:");
                    if (clavesDic.Count == 0) Console.WriteLine("(Sin elementos)");
                    else foreach (var c in clavesDic) Console.WriteLine($"- {c}");
                    Console.ReadKey();
                    break;

                case "8":
                    var valoresDic = diccionario.GetValues();
                    Console.WriteLine("Valores:");
                    if (valoresDic.Count == 0) Console.WriteLine("(Sin elementos)");
                    else foreach (var v in valoresDic) Console.WriteLine($"- {v}");
                    Console.ReadKey();
                    break;

                case "9":
                    Console.Write("Clave a verificar: ");
                    Console.WriteLine(diccionario.ContainsKey(Console.ReadLine())
                        ? "La clave existe."
                        : "La clave no existe.");
                    Console.ReadKey();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
