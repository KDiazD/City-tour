using System;
using System.Collections.Generic;
using System.Text;

namespace citytour
{
    public class Comida
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }

    public class Lista_Comidas
    {
        public List<Comida> _comidas { get; set; }

        public Lista_Comidas()
        {
            _comidas = new List<Comida>();
            LoadComidas();
        }
        public void LoadComidas()
        {
            _comidas.Add(new Comida
            {
                Nombre = "Asado Huilense",
                Descripcion = "Es un edificio religioso afiliado a la Iglesia ",
                Imagen = "aa"

            });
            _comidas.Add(new Comida
            {
                Nombre = "Tamales",
                Descripcion = "Ubicado en el centro de la ciudad, a su alrededor se encuentran edificios de suma",
                Imagen = "aa"

            });
            _comidas.Add(new Comida
            {
                Nombre = "Iglesia Colonial",
                Descripcion = "Prueba descripcion",
                Imagen = "aa"

            });
            _comidas.Add(new Comida
            {
                Nombre = "Monumento la Cacica Gaitana",
                Descripcion = "Prueba descripcion",
                Imagen = "aa"

            });

        }
    }
}
