namespace ByteBank.InternalSystem; 

public interface IAuthenticable 
{
    public string Password { get; set; }
    public bool Authenticate(string password);
    
}
