namespace ParcialCrud
{
    public class LibrosElectronicos : Libros
    {
        public string Formato { get; set; }

        public int Tamano_archivo { get; set; }

        public LibrosElectronicos() { 
            Formato = string.Empty;
            Tamano_archivo = 0;
        }
    }
}
