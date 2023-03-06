abstract class Señal
{
    protected readonly Dimension dimension;
    private readonly Forma forma;
    public float Precio()
    {
        return (dimension/2)+CalculaPrecio();
    }
    public abstract float CalculaPrecio();
    public Señal(Dimension dimension, Forma forma)
    {

    }
    public override string ToString()
    {
        return base.ToString()+"\nSeñal con forma de "+forma+" de tamaño de "+dimension;
    }
}