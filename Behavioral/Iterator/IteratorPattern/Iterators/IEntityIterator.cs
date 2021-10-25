namespace IteratorPattern.Collections
{
    public interface IEntityIterator
    {
        bool IsFirst { get; }
        bool IsLast { get; }
        object CurrentElement { get; }
        object First();
        object Next();
        object Previous();
    }
}
