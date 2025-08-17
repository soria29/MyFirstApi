namespace MyFirstApi.Entities;

//sealed indica que essa classe não pode ser herdada
public sealed class Laptop : Device
{
    // sobrescreve o método abstrato da classe pai
    public override string GetBrand()
    {
        return "Apple";
    }

    public string getModel()
    {
        var isConnected = IsConnected();
        if(isConnected) {
            return "MacBook";
        }

        return "Unknown";
    }

    public override string getName()
    {
        return "Laptop name";
    }
}
