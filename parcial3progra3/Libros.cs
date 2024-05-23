namespace ParcialCrud
{
    public class Libros
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public string Genero { get; set; }

        public int Anio_publicacion { get; set; }


        public Libros()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            Anio_publicacion = 0;

        }
    }
}
