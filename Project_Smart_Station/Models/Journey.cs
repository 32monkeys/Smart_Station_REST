namespace Smart_Station_REST.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public string Weekday { get; set; } = string.Empty;


        public Journey(string startLocation, string destination, string weekday = "")
        {
            StartLocation = startLocation;
            Destination = destination;
            Weekday = weekday;
        }
        public Journey()
        {
        }

        public override string ToString()
        {
            return $"Start: {StartLocation}, Destination: {Destination}, Weekday: {Weekday}";
        }
    }
}
