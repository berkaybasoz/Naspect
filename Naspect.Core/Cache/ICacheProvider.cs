namespace Naspect.Core.Cache
{
    public interface ICacheProvider
    {
        bool TryGetData(string cacheKey, out object data);
        void SetData(string cacheKey, object data);
    }
}
