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
            int cantidad = 0;
            Console.Write("Indique cuántos usuarios aleatorios desea obtener: "+"\n");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out cantidad))
            {
                string url = $"https://randomuser.me/api/?results={cantidad}";
                var result = await GetUser(url);

                foreach (var item in result.results)
                {
                    Console.WriteLine($"{item.name.title} {item.name.first} {item.name.last}");
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
    }
}
