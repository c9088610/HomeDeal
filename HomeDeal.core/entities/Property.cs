namespace HomeDeal.Core.Entities
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Adress { get; set; }
        public double Price { get; set; }
        public double NumberOfRooms { get; set; }
        public double sqm {  get; set; }
        public bool IsActiv {  get; set; }
    }
}
