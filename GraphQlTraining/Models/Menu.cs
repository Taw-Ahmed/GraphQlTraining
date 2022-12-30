namespace GraphQlTraining.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ImageURL { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
