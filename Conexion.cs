using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TareaPractica3
{
    public class Conexion
    {
        async public Task Conectar()
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    int cantidad = 0;
                    Console.Write("\nIndique cuántos usuarios aleatorios desea obtener: ");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out cantidad))
                    {
                        Console.WriteLine("\nGenerando usuarios aleatorios...");

                        string url = $"https://randomuser.me/api/?results={cantidad}";
                        var result = await GetUser(url);

                        foreach (var item in result.results) 
                        {
                            Console.WriteLine($"\nNombre: {item.name.title} {item.name.first} {item.name.last}" +
                                $"\nGénero: {item.gender}\nCorreo electrónico: {item.email}\nPaís: {item.location.country}");
                        }
                        Console.WriteLine("\nSe ha generado la lista solicitada.\n" +
                            "\nSi desea generar más usuarios aleatorios presione la letra 's' o presione cualquier otra tecla" +
                            " para salir del programa.");
                        entrada = Console.ReadLine();
                        if(entrada.ToLower() != "s")
                        {
                            continuar = false;
                            Console.WriteLine("\nSaliendo del programa...");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nDebe digitar un número. Intente nuevamente.");
                    }

                    async Task<Root> GetUser(string url)
                    {
                        var http = new HttpClient();
                        var result = await http.GetFromJsonAsync<Root>(url);
                        return result!;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nHa ocurrido un error, pruebe inicializando la aplicación nuevamente. {ex.Message}");
                }
            }
        }
    }
}
