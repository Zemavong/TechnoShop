namespace TechnoShop.Data.Models
{
    public class Item
    {
        public int id { get; set; }

        public string name { get; set; }

        public string desc { get; set; }

        public string img { get; set; }

        public ushort price { get; set; }

        public bool isFavorite { get; set; }

        public int available { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
