namespace VirtualAssitant.Core.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<int> categoryId { get; set; }

    }
}
