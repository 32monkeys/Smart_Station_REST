namespace Smart_Station_REST.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }

        public Journey(string startLocation, string destination)
        {
            StartLocation = startLocation;
            Destination = destination;
        }
        public Journey()
        {
        }

        public override string ToString()
        {
            return $"Start: {StartLocation}, Destination: {Destination}";
        }
    }
}
