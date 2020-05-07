namespace ByteBank.Systems
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}
