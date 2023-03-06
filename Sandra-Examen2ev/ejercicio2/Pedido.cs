class Pedido
{
    private DataType fechaPedido{get;}
    private Señal[] señalesPedido{get;}

    public Pedido(){}
    public Pedido(Señal[] señalesPedido)
    {
        this.señalesPedido=señalesPedido;
    }
    public Pedido(Pedido p)
    {
        this.p=p;
    }
    public void AñadeProductoPedido(Señal señal)
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }

}