using System.Collections.Generic;

namespace MediaTypes
{
    public interface IDVD:ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
        List<string> Actors { get; set; }
    }
}