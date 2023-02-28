internal class Program
{
    private static void Main(string[] args)
    {
        try
            {
                Tablero tablero = new Tablero();
                tablero.PonPieza(new Alfil(ColorAjedrez.Blanco), "C8");
                tablero.PonPieza(new Torre(ColorAjedrez.Blanco), "A1");
                tablero.PonPieza(new Peon(ColorAjedrez.Negro), "B6");
                tablero.PonPieza(new Caballo(ColorAjedrez.Negro), "B3");
                Console.WriteLine(tablero);
                Console.WriteLine();
                tablero.PonPieza(tablero.QuitaPieza("B6"), "B7");
                tablero.PonPieza(tablero.QuitaPieza("C8"), "H3");
                tablero.QuitaPieza("B3");
                Console.WriteLine(tablero);
            }
            catch (AjedrezException e)
            {
                Console.WriteLine(e.Message);
            }
    }
}