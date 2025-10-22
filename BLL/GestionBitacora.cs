using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GestionBitacora
    {
        private mapper_bitacora maperBitacora = new mapper_bitacora();

        public void RegistrarBitacora(BE.BITACORA bitacora)
        {
            maperBitacora.Insertar(bitacora);
        }

        public List<BE.BITACORA> ListarBitacora()
        {
            return maperBitacora.Listar();
        }
    }
}