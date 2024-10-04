using Drones;

namespace DronesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }

        [TestMethod]
        public void Test_add_and_remove_from_dispatch()
        {
            //Arrange
            List<Box> boxes = new List<Box>();
            Dispatch dispatch = new Dispatch();
            //Act
            for (int i = 0; i < 10; i++)
            {
                Box box = new Box();
            }
            //Assert
                Assert.AreEqual(j, "le nombre de boîtes est incorrect");            
        }

    }
}