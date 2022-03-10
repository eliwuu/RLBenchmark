namespace RLBenchmark.Data
{
    public interface ISource<T>
    {
        Task<T> Get(string sourceName, Func<T, bool> predicate);
        Task<T> Set(string sourceName, T data);
        Task<T> Delete(string sourceName, Func<T, bool> predicate);
        Task<T> Update(string sourceName, Func<T, bool> predicate, T data);
    }
    public class Source<T> : ISource<T>
    {
        private readonly IDb _db;

        public Source(IDb db) { _db = db}

        public Task<T> Delete(string sourceName, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(string sourceName, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> Set(string sourceName, T data)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(string sourceName, Func<T, bool> predicate, T data)
        {
            throw new NotImplementedException();
        }
    }
}