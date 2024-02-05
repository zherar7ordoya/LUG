using System;
using System.IO;

namespace DAL
{
    static class LogService
    {
        // Propuesta de Vilaboa para Servicio de Registro de Excepciones
        public static void ExceptionsLog(string pMensaje)
        {
            StreamWriter archivo = new StreamWriter("log.txt", true);
            archivo.WriteLine(DateTime.Now.ToString() + ";" + pMensaje);
            archivo.Close();
        }
    }
}
