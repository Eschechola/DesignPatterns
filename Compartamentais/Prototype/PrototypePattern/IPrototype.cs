namespace PrototypePattern
{
    public interface IPrototype
    {
        IPrototype ShallowClone();
        IPrototype DeepClone();
    }
}
