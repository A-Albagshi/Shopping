namespace Shopping.Models
{
    public class ProductModel
    {
        public ProductModel(int Id,string Name,float Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public float Price { set; get; }
    }
}