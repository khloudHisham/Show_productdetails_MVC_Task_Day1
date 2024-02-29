using System.Collections.Generic;

namespace MVCDay01.Models
{
    public class ProductBL
    {
        List<Product> Products = new List<Product>();
        public ProductBL()
        {
            Products.Add(new Product() { Id = 1, Name = "Camera", Price = 1200, Image = "camera.jpg" });
            Products.Add(new Product() { Id = 2, Name = "Phone", Price = 9000, Image = "phone.jpg"});
         Products.Add(new Product() { Id = 3, Name = "labtop", Price = 20000, Image = "labtop.jpg" });
            Products.Add(new Product() { Id = 4, Name = "Microfon", Price = 1000, Image = "microfon.jpg" });
            Products.Add(new Product() { Id = 5, Name = "Alarm", Price = 9000, Image = "alarm.jpg" });        }
        public List<Product> GetAll() {
            return Products;
        }
        public Product GetByID(int id)
        {
            return Products.FirstOrDefault(e => e.Id == id);
        }

    }
}

