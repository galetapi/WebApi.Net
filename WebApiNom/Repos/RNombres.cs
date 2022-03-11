using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNom.Model;

namespace WebApiNom.Repos
{
    public class RNombres
    {
        public static List<NombreDt> _listaNombre = new List<NombreDt>()
        {
            new NombreDt() { Id = 1, Nombre = "persona 1" , Apellido = "Apellido 1" },
            new NombreDt() { Id = 2, Nombre = "persona 2" , Apellido = "Apellido 2" },
            new NombreDt() { Id = 3, Nombre = "persona 3" , Apellido = "Apellido 3" }
        };

        public IEnumerable<NombreDt> ObtenerNombres()
        {
            return _listaNombre;
        }

        public NombreDt ObtenerNombres(int id)
        {
            var cliente = _listaNombre.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void Agregar(NombreDt nuevoNombre)
        {
            _listaNombre.Add(nuevoNombre);
        }
    }
}
