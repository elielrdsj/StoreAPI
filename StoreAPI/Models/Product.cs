namespace Product
{
    public class Product
    {
        public string name { get; set; }

        public int id { get; set; }

        public string? imgLink;

        public string? description { get; set; }

        public Product(string name)
        {
            this.name = name;
            id = 1;
        }
    }
}