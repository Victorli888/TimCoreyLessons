namespace MediaTypes
{
    /// <summary>
    /// Empty Interface that connects our DVD Interface and Rentable Items Interface, Again we're trying to make our
    /// Code as modular as possible
    /// </summary>
    public interface IRentableDVD:IDVD,IRentableItem
    {
        
    }
}