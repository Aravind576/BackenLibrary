namespace BackendLibrary.Models
{
    public class MyLibrarydatabaseSettings:IMyLibrarydatabaseSettings
    {
        public string MyLibraryDatabaseName { get; set; }=string.Empty;
        public string DatabaseCollectionName { get; set; }=string.Empty ;
        public string ConnectionString { get; set; } = string.Empty;
    }
}
