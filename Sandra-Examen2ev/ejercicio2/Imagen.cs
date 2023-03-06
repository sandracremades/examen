struct Imagen{
    public Color color;
    public string dibujo;
    public override string ToString()
    {
        return base.ToString()+" con una imagen de "+dibujo+" de color "+color;
    }
}