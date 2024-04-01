using theatre_storage_backend;
using theatre_storage_backend.Subsystems;

namespace theatr_storage_backend_test
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestCreateThetreInformationSubsystem()
        {
            TheatreInformationSubsystem theatre = new TheatreInformationSubsystem();
            Assert.AreEqual(theatre.Id, 1);
            Assert.AreEqual(theatre.Name, "Theatre");
            Assert.AreEqual(theatre.Type, "Theatre");
            Assert.AreEqual(theatre.Address, null);
        }

        [Test]
        public void TestCreateThetreInformationSubsystemWithParameters()
        {
            TheatreInformationSubsystem theatre = new TheatreInformationSubsystem(2, "Theatre2", "Theatre", "Address");
            Assert.AreEqual(theatre.Id, 2);
            Assert.AreEqual(theatre.Name, "Theatre2");
            Assert.AreEqual(theatre.Type, "Theatre");
            Assert.AreEqual(theatre.Address, "Address");
        }   
        
    }
}