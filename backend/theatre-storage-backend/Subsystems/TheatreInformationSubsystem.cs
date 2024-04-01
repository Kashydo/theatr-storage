using theatre_storage_backend.Interfaces;
namespace theatre_storage_backend.Subsystems
{
    public class TheatreInformationSubsystem : IInstitution
    {
        public readonly int Id =1;
        public string Name { get ; set; }
        public string Type { get ; set; }
        public string ? Address { get ; set ; }


        public TheatreInformationSubsystem()
        {
            Id = 1;
            Name = "Theatre";
            Type = "Theatre";
            Address = null;
        }

        public TheatreInformationSubsystem(int id, string name, string type, string address)
        {
            Id = id;
            Name = name;
            Type = type;
            Address = address;
        }
    }
}
