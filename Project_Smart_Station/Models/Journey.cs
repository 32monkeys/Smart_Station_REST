namespace Smart_Station_REST.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }


        public Journey(string startLocation, string destination, DateTime date)
        {
            StartLocation = startLocation;
            Destination = destination;
            Date = date;
        }
        public Journey()
        {
        }

        public override string ToString()
        {
            return $"Start: {StartLocation}, Destination: {Destination}, Date: {Date:yyyy-MM-dd}";
        }
    }
}
