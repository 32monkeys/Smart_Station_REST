namespace Smart_Station_REST.Models
{
    public class APIJourneyInput
    {
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public string ArrivalTime { get; set; }
        public int Timezone { get; set; }
        public int PrepTime { get; set; }
        public int ReplanningTime { get; set; }

        public APIJourneyInput(string startLocation, string destination)
        {
            StartLocation = startLocation;
            Destination = destination;
        }
        public APIJourneyInput()
        {
        }

        public override string ToString()
        {
            return $"Start: {StartLocation}, Destination: {Destination}";
        }
    }
}