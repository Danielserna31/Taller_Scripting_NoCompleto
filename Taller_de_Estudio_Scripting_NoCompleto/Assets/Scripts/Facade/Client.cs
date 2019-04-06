
public struct Client
{
    public readonly Order order;
    public readonly float patienceTime;
    public readonly float orderPrice;

    public Client(Order order, float patienceTime, float orderPrice)
    {
        this.order = order;
        this.patienceTime = patienceTime;
        this.orderPrice = orderPrice;
    }
}
