using Xunit;
using RLBenchmark.Manager;

namespace Test
{
    public class Manager
    {
        [Fact]
        public void PasswordHashVerifyTrue()
        {
            var passwordManager = new Password();
            var password = "abcd";
            (byte[] hash, byte[] salt) = passwordManager.Create(password);
            var verify = passwordManager.Verify(password, hash, salt);

            Assert.True(verify);
        }
    }
}