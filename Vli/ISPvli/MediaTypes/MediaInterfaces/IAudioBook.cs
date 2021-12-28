namespace MediaTypes
{
    public interface IAudioBook:ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
        
    }
}