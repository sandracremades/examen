struct Dimension{
    public float alto;
    public float ancho;

    public Dimension(float alto, float ancho)
    {
        this.alto = alto;
        this.ancho = ancho;
    }
    public float CalculaDimension()
    {
        return alto*ancho;
    }
}