using Smart_Station_REST.Models;
using Smart_Station_REST.Repositories;

namespace Test_Smart_Station
{
    public class JourneyRepositoryTest
    {
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
