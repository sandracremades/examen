
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{
    class Alumno
    {
        readonly string nombreApellidos;
        readonly string nia;
        readonly string curso;
        readonly string ciclo;

        public Alumno(string nombreApellidos, string nia, string curso, string ciclo)
        {
            this.nombreApellidos=nombreApellidos;
            this.nia=nia;
            this.curso=curso;
            this.ciclo=ciclo;
        }

        public override string ToString()
        {
            StringBuilder salida=new StringBuilder();
            salida.Append(nombreApellidos);
            salida.Append("\n");
            salida.Append(nia);
            salida.Append("\n");
            salida.Append(curso);
            salida.Append("\n");
            salida.Append(ciclo);
            return salida.ToString();
        }
    }
    class Program
    {
        static Alumno CrearAlumnoValido(string alumno)
        {
            Alumno alumnos;
            StreamReader sr = new StreamReader("datos.dat");
            while(!sr.EndOfStream)
            {
                alumnos = sr.Split(',',';',' ');
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();

            return alumnos;
            
        }

        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("Pedro Garcia", "123456", "1A", "ESO");

            
			//Leo el fichero y muestro los alumnos llamando a toString() de alumno, que cumplan la 
			//condición de tener correcto el formato según expresión regular. Capturando una excepción
			//de tipo FormatException lanzada previamente cuando no se cumpla el formato
          
            Console.ReadLine();
        }
    }
}