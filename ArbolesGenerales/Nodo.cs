namespace ArbolesGenerales
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo Hermano { get; set; }
        public Nodo Hijo { get; set; }

        public Nodo(string valor="",Nodo hermano=null,Nodo hijo=null)
        {
            Valor = valor;
            Hermano = hermano;
            Hijo = hijo;
        }








    }
}
