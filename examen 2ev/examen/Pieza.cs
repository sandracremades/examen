abstract class Pieza
{
    public ColorAjedrez color { get; }

    public Pieza(ColorAjedrez color){
        this.color = color;
    }

    public abstract double Valor();
    public abstract string Nombre();

    public override string ToString()
    {
        return Nombre()+ " "+ color.ToString();
    }
}