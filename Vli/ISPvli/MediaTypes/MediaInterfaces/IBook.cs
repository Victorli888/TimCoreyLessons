namespace MediaTypes
{
    /// <summary>
    /// General interface for book types, Rentable Items will implement this Interface.
    /// </summary>
    public interface IBook:ILibraryItem
    {        
        string Author { get; set; }
        int Pages { get; set;}
        
    }
}