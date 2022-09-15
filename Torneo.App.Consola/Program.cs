using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        static void Main(string[] args)
        {
            #region Menu Inicio
            Console.WriteLine("Selecione opcion a trabajar");             
            Console.WriteLine("1. Municipios");
            Console.WriteLine("2. Posicion");
            Console.WriteLine("3. Jugador");
            Console.WriteLine("4. Partido");
            Console.WriteLine("5. Director Tecnico");
            Console.WriteLine("6. Equipos");
            //Console.ReadKey();
            int selecionar = int.Parse(Console.ReadLine());
            #endregion

            if (selecionar == 1)
            {
                Console.WriteLine("1. Agregar Municipios");
                Console.WriteLine("2. Mostrar Municipios");
                selecionar = int.Parse(Console.ReadLine());

                if (selecionar == 1)
                {
                    Console.WriteLine("Agregar Municipios");
                    AddMunicipio();
                }

                if (selecionar == 2)
                {
                    Console.WriteLine("Mostrar Municipios");
                    GetAllMunicipios();
                    Console.ReadKey();
                }

            }
        }

        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                Console.WriteLine(municipio.Id + " " + municipio.Nombre);
            }
        }
    }
}
