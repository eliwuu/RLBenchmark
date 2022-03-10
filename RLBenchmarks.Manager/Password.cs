namespace RLBenchmark.Manager;

public interface IPassword
{
    (byte[] hash, byte[] salt) Create(string password);
    bool Verify(string password, byte[] hash, byte[] salt);
}

public class Password : IPassword
{
    public (byte[] hash, byte[] salt) Create(string password)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512();
        var salt = hmac.Key;
        var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return (hash, salt);
    }

    public bool Verify(string password, byte[] hash, byte[] salt)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512(salt);

        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        for (var i = 0; i < hash.Length; i++)
        {
            if (computedHash[i] != hash[i]) return false;
        }
        return true;
    }
}
