namespace Task.BaseInterfaces
{
    public interface ISaveUpdateCommand<T>
    {
        void Save(T dto);
    }
}