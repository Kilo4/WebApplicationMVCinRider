namespace WebApplicationMVCinRider.Models.Students
{
    public partial class Students : IStudents
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegisterID { get; set; }
        public int ID { get; set; }
        
        public string Address           { get; set; }
        public string Street            { get; set; }
        public string StreetNumber      { get; set; }
        public string PostalCode        { get; set; }
        public string District          { get; set; }
        public string City              { get; set; }
        
    }

    public interface IStudents
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string RegisterID { get; set; }
        int ID { get; set; }
    }
}