namespace BackendLibrary.Models
{
    public interface IMyLibrarydatabaseSettings
    {
        string MyLibraryDatabaseName { get; set; }
        string DatabaseCollectionName { get; set; }
        string ConnectionString { get; set; }
    }
}
