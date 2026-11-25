using Smart_Station_REST.Models;
using Smart_Station_REST.Repositories;

namespace Test_Smart_Station
{
    public class JourneyRepositoryTest
    {
        [Fact]

        public void GetAll_Should_Return_All_Journeys()
        {
            // Arrange
            var journeyRepository = new JourneyRepository();
            var journey1 = new Journey { Id = 1, StartLocation = "Here", Destination = "There" };
            var journey2 = new Journey { Id = 2, StartLocation = "There", Destination = "Here" };
            journeyRepository.Add(journey1);
            journeyRepository.Add(journey2);

            // Act
            var allJourneys = journeyRepository.GetAll();

            // Assert
            Assert.Contains(journey1, allJourneys);
            Assert.Contains(journey2, allJourneys);
        }
        
        [Fact]
        public void AddJourney_Should_Add_Journey_To_Repository()
        {
            // Arrange
            var journeyRepository = new JourneyRepository();
            var journey = new Journey { Id = 1, StartLocation = "Here", Destination = "There" };

            // Act
            journeyRepository.Add(journey);

            // Assert
            bool journeyExists = journeyRepository.GetAll().Contains(journey);
            Assert.True(journeyExists);
        }
    }
}
