using System;
using System.Collections.Generic;
using System.Text;

namespace citytour
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
    public class Lista_elementos
    {
        public List<Elemento> _elementos { get; set; }

        public Lista_elementos()
        {
            _elementos = new List<Elemento>();
            LoadElements();

        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre = "Catedral de la inmaculada concepción",
                Descripcion = "Es un edificio religioso afiliado a la Iglesia " +
                "católica dedicado a la Virgen María en su advocación de la Inmaculada Concepción. " +
                "​El templo que sigue el rito romano es la iglesia madre de la Diócesis de Neiva que fue " +
                "establecida en 1972 por el papa Pablo VI. " +
                "Fue construida en estilo gótico que durante mucho tiempo dominó las construcciones de la ciudad. " +
                "La iglesia está ubicada en el costado sur del parque Santander, en pleno corazón de Neiva.",
                Imagen = "aa"

            });
            _elementos.Add(new Elemento
            {
                Nombre = "Parque Central Santander",
                Descripcion = "Ubicado en el centro de la ciudad, a su alrededor se encuentran edificios de suma" +
                "importancia para la capital bambuquera del país; Así mismo, alrededor de este espacio en honor al " +
                "prócer Francisco de Paula Santander se ubican el edificio de la Gobernación del Huila y diversos establecimientos comerciales y hoteleros.",
                Imagen = "aa"

            });
            _elementos.Add(new Elemento
            {
                Nombre = "Iglesia Colonial",
                Descripcion = "Prueba descripcion",
                Imagen = "aa"

            });
            _elementos.Add(new Elemento
            {
                Nombre = "Monumento la Cacica Gaitana",
                Descripcion = "Prueba descripcion",
                Imagen = "aa"

            });
            _elementos.Add(new Elemento
            {
                Nombre = "Mirador del Mohan",
                Descripcion = "Prueba descripcion",
                Imagen = "aa"

            });
        }
    }
}
