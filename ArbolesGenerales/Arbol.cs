namespace ArbolesGenerales
{
    internal class Arbol
    {
        public Nodo Raiz { get; }
        public Arbol(string valor)
        {
            Raiz = new Nodo(valor);
        }

        public Nodo Agregar(string valor, Nodo padre)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new Exception("Se debe especificar el valor");
            }

            if (padre == null)
            {
                throw new Exception("Se debe especificar el padre");
            }

            if (padre.Hijo == null)
            {
                padre.Hijo = new Nodo(valor);
                return padre.Hijo;
            }
            else
            {
                Nodo nodoActual = padre.Hijo;
                while (nodoActual.Hermano != null)
                {
                    nodoActual = nodoActual.Hermano;
                }
                nodoActual.Hermano = new Nodo(valor);
                return nodoActual.Hermano;
            }
        }

        private void Recorrer(Nodo nodo, ref int posicion, ref string datos)
        {
            if (nodo != null)
            {
                string dato = nodo.Valor;
                int cantidadGuiones = datos.Length + posicion;
                string datoConGuiones = dato.PadLeft(cantidadGuiones, '+');
                datos += $"{datoConGuiones}{Environment.NewLine}";

                if (nodo.Hijo != null)
                {
                    posicion++;
                    Recorrer(nodo.Hijo, ref posicion, ref datos);
                    posicion--;
                }

                if (nodo.Hermano != null && posicion != 0)
                {
                    Recorrer(nodo.Hermano, ref posicion, ref datos);

                }
            }
        }
        public string Obtener()
        {
            int posicion = 0;
            string datos = "";
            Recorrer(Raiz, ref posicion, ref datos);
            return datos;
        }





    }
}
