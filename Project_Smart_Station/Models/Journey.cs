namespace Smart_Station_REST.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public string Destination { get; set; }

        public Journey(string destination)
        {
            Destination = destination;
        }
        public Journey()
        {
        }

        public override string ToString()
        {
            return $"Destination: {Destination}";
        }
    }
}
