using Smart_Station_REST.Models;

namespace Smart_Station_REST.Repositories
{
    public class JourneyRepository : IRepository<Journey>
    {
        private readonly List<Journey> _journeys = new List<Journey>();

        public Journey Add(Journey obj)
        {
            _journeys.Add(obj);
            return obj;
        }

        public Journey Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Journey> GetAll()
        {
            return _journeys.ToList();
        }

        public Journey GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Journey Update(Journey obj)
        {
            throw new NotImplementedException();
        }
    }
}
