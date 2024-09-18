namespace complex_automapper.Models
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDTO> ProductDTO { get; set; }
    }
}
