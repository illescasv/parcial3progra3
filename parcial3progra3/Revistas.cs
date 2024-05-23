namespace ParcialCrud
{
    public class Revistas : Libros
    {
        public string Volumen {  get; set; }
        public int No_ejemplar { get; set; }

        public Revistas()
        {
            No_ejemplar = 0;
            Volumen = string.Empty;
        }
    }
}
