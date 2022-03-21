using System.ComponentModel.DataAnnotations;

namespace RazorPagesRanque.models
{
    public class motorcycle

    { 
    public int ID { get; set; }
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }


    
    }
}
