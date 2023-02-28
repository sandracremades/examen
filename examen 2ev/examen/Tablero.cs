using System.Text.RegularExpressions;

class Tablero
{
    private const int DIMENSION_TABLERO = 8;
    private readonly Casilla[,] casillas;
    private bool negro;

    public Tablero()
    {
        this.casillas = new Casilla[DIMENSION_TABLERO,DIMENSION_TABLERO];
        this.negro = true;

        for(int i = 0; i < DIMENSION_TABLERO; i++)
        {
            for(int j = 0; j < DIMENSION_TABLERO; j++)
            {
                Casilla c = new Casilla();

                if(negro == true)
                    c.color = ColorAjedrez.Negro;
                else 
                    c.color = ColorAjedrez.Blanco;

                casillas[i,j] = c;
                negro = !negro; //invierte el bool(si esta en true lo cambia a false)
            }
        }
    }

    public bool HayPieza(string casilla)
    {
        int valorAsciiA = 'A';
        string patron = @"^[A-H]{1}[1-8]{1}$";

        if(Regex.IsMatch(casilla, patron))
        {
            string primeraLetra = casilla.Substring(0,1);
            string segundaLetra = casilla.Substring(1,1);

            int i = char.Parse(primeraLetra)-valorAsciiA;
            int j = int.Parse(segundaLetra) - 1;

            return !(casillas[i,j].pieza == null);
        }
        else 
            throw new AjedrezException(casilla + " no es una codificación válida para una casilla del tablero.");

       
    }
    public Pieza VerPieza(string casilla)
    {
        int valorAsciiA = 'A';
        string patron = @"^[A-H]{1}[1-8]{1}$";

        if(Regex.IsMatch(casilla, patron))
        {
            string primeraLetra = casilla.Substring(0,1);
       string segundaLetra = casilla.Substring(1,1);

       int i = char.Parse(primeraLetra)-valorAsciiA;
       int j = int.Parse(segundaLetra) - 1;

       if(HayPieza(casilla))
            return casillas[i,j].pieza;
        else
            throw new AjedrezException("No hay ninguna pieza en la casilla "+casilla);
        }
        else 
            throw new AjedrezException(casilla + " no es una codificación válida para una casilla del tablero.");

       
    }
    public Pieza QuitaPieza(string casilla)
    {
        int valorAsciiA = 'A';
        string patron = @"^[A-H]{1}[1-8]{1}$";

        if(Regex.IsMatch(casilla, patron))
        {
            string primeraLetra = casilla.Substring(0,1);
       string segundaLetra = casilla.Substring(1,1);

       int i = char.Parse(primeraLetra)-valorAsciiA;
       int j = int.Parse(segundaLetra) - 1;

       if(HayPieza(casilla))
       {
            Pieza p = casillas[i,j].pieza;
            casillas[i,j].pieza = null;
            return p;
       }  
        else
            throw new AjedrezException("No hay ninguna pieza en la casilla "+casilla);
        }
        else 
            throw new AjedrezException(casilla + " no es una codificación válida para una casilla del tablero.");

       
    }
    public void PonPieza(Pieza pieza, string casilla)
    {
        int valorAsciiA = 'A';
        string patron = @"^[A-H]{1}[1-8]{1}$";

        if(Regex.IsMatch(casilla, patron))
        {
            string primeraLetra = casilla.Substring(0,1);
            string segundaLetra = casilla.Substring(1,1);

            int i = char.Parse(primeraLetra)-valorAsciiA;
            int j = int.Parse(segundaLetra) - 1;

            if(pieza == null)
                throw new ArgumentNullException("La pieza a poner en "+casilla+" no puede ser null");
            else if(HayPieza(casilla) == true)
                throw new AjedrezException("En la casilla "+casilla+" ya hay una pieza "+pieza.ToString());
            else
                casillas[i,j].pieza = pieza;
        }
        else 
            throw new AjedrezException(casilla + " no es una codificación válida para una casilla del tablero.");
       
    }
    public override string ToString()
    {
        string cadena = "";
        int totalBlancas = 0;
        int totalNegras = 0;

        for(int i = 0; i < DIMENSION_TABLERO; i++)
        {
            for(int j = 0; j < DIMENSION_TABLERO; j++)
            {
                if(casillas[i,j].pieza != null)
                {
                    cadena += casillas[i,j].pieza.ToString()+"["+i+", "+j+"] "+casillas[i,j].color+"\n";

                    if(casillas[i,j].pieza.color == ColorAjedrez.Blanco)
                        totalBlancas++;
                    else
                        totalNegras++;
                }
                    
            }

        }
        cadena += "Total blancas: "+totalBlancas+"\n Total negras: "+totalNegras;
        return cadena;
    }
    
}