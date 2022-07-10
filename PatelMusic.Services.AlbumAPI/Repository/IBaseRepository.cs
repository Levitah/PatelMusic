namespace PatelMusic.Services.AlbumAPI.Repository
{
    public interface IBaseRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> List();
        void Save(T item);
        void Delete(int id);
    }
}