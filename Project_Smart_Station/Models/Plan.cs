namespace Smart_Station_REST.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public DateTimeOffset PlanArrivalDateTime { get; set; }
        public DateTimeOffset PlanWakeupDateTime { get; set; }
    }
}
