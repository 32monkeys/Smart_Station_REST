namespace Smart_Station_REST.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T obj);
        T Update(T obj);
        T Delete(int id);
    }
}
