namespace BackendLibrary.Models
{
    public interface ILoginCredentialsSettings
    {
        string LoginCredentialsDatabaseName { get; set; }
        string DatabaseCollectionsName { get; set; }
        string ConnectionString { get; set; }
    }
}
