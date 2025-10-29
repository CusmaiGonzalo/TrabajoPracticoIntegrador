using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestionIdioma : ISujetoObserver
    {
        List<IObserver> observadores = new List<IObserver>();
        Mapper_etiquetas maperEtiquetas = new Mapper_etiquetas();
        mapper_idioma maperIdioma = new mapper_idioma();
        public int IdiomaActual { get; private set; }

        public void CambiarIdioma(int nuevoIdioma)
        {
            IdiomaActual = nuevoIdioma;
            NotificarObservadores();
        }
        public string ObtenerTraduccion(string clave)
        {
            return maperEtiquetas.ObtenerTraduccion(IdiomaActual, clave);
        }




        public void Agregar(IObserver observer)
        {
            observadores.Add(observer);
        }

        public void NotificarObservadores()
        {
            foreach (var observer in observadores)
            {
                observer.Traducir(IdiomaActual);
            }
        }

        public void Quitar(IObserver observer)
        {
            observadores.Remove(observer);
        }


        public List<BE.IDIOMA> ListarIdiomas()
        {
            return maperIdioma.Listar();
        }
    }
}
