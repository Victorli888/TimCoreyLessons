namespace MediaTypes
{
    /// <summary>
    /// Modular Interface that implements our Book Interface and Rentable Items Interface
    /// </summary>
    public interface IRentableBook:IRentableItem,IBook
    {
        
    }
}