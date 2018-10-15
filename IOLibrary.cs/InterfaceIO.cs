namespace IOLibrary
{
    public interface InterfaceIO
    {
        bool Save(string path, ulong offset);
        bool Load(string path, ulong offset);
    }
}
