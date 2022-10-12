namespace BackendLibrary.Models
{
    public class LoginCredentialsSettings:ILoginCredentialsSettings
    {
        public string LoginCredentialsDatabaseName { get; set; }=string.Empty;
        public string DatabaseCollectionsName { get; set; }= string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
    }
}
