using System.Drawing;

namespace IOLibrary
{
    public interface IInputOutput
    {
        bool Save(string path, ulong offset);
        bool Load(string path, ulong offset);

        //Any library for IO should place in this project (IOLibrary)
        
    }
}
