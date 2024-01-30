using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_C
{
    public class ListaItems
    {
        readonly object mValor;
        readonly string mTexto;

        public ListaItems(object pValor, string pTexto)
        {
            mValor = pValor;
            mTexto = pTexto;
        }

        public object Valor
        {
            get { return mValor; }
        }

        public string Texto
        {
            get { return mTexto; }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ListaItems other = (ListaItems)obj;
            return Valor.Equals(other.Valor) && Texto.Equals(other.Texto);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Valor.GetHashCode();
                hash = hash * 23 + Texto.GetHashCode();
                return hash;
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        #region SOBRECARGA DE OPERADORES

        /*
         * SOBRECARGA DE OPERADORES "=", "<>" Y "+"
         * Permite efectuar operaciones entre objetos ListaItem (para los cuales
         * no está prevista la operación de igualdad, desigualdad y suma). De
         * esta forma, se le dice al CLR como actuar en caso de presencia de
         * estos operadores.
         */

        //PARA QUE UN OBJETO LISTAITEM SEA IGUAL QUE OTRO, DEBEN SER IGUALES SU VALOR Y SU TEXTO
        public static bool operator ==(ListaItems pListItem1, ListaItems pListItem2)
        {
            return pListItem1.Valor == pListItem2.Valor & pListItem1.Texto == pListItem2.Texto;
        }

        //PARA QUE UN OBJETO LISTAITEM SEA DISTINTO QUE OTRO, DEBE SER DESIGUAL SU VALOR O SU TEXTO
        public static bool operator !=(ListaItems pListItem1, ListaItems pListItem2)
        {
            return pListItem1.Valor != pListItem2.Valor | pListItem1.Texto != pListItem2.Texto;
        }

        //PARA SUMAR DOS OBJETOS LISTAITEM SE SUMAN Y CONCATENAN SU VALOR Y SU TEXTO
        public static ListaItems operator +(ListaItems a, ListaItems b)
        {
            return new ListaItems((a + b).Valor, a.Texto + b.Texto);
        }

        #endregion

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
