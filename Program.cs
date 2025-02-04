using System.Net.Http.Json;

namespace TareaPractica3
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Conexion conexion = new Conexion();
            await conexion.Conectar();
        }
    }
}
