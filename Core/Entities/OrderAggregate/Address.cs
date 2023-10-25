namespace Core.Entities.OrderAggregate
{
    public class Address
    {

        public Address()
        {

        }
        public Address(string firstName, string street, string province, string city, string postalcode) 
        {
            FirstName = firstName;
            LastName = LastName;
            Street = street;
            City = city;
            Province = province;
            Postalcode = postalcode;
   
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
    }
}