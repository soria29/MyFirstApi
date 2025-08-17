namespace MyFirstApi.Entities;

// o abstract indica que essa classe não pode ser instanciada diretamente
public abstract class Device
{
    //pode ser acessado por todas as classes que herdam de Device
    //public bool IsConnected() => true;

    //pode ser acessado apenas por classes que herdam de Device
    protected bool IsConnected() => true;

    // pode ser acessado apenas por Device
    //private bool IsConnected() => true;

    //método abstrato, ou seja, não tem implementação aqui, apenas na classe filha
    public abstract string GetBrand();

    //método virtual, ou seja, tem uma implementação padrão, mas pode ser sobrescrito na classe filha
    public virtual string getName()
    {
        return "Device name";
    }

}
