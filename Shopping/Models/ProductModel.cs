namespace Shopping.Models
{
    public class ProductModel
    {
        public ProductModel(int Id,string Name,float Price,string Image)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Image = Image;
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public float Price { set; get; }
        public string Image { set; get; }
    }
}