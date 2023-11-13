using System.ComponentModel.DataAnnotations;

namespace AppDITI5MAF.Models
{
    public class Articles
    {
        [Key]
        public int idArticle {  get; set; }
        public int codeArticle { get; set; }
        public string Description { get; set; }
        public int Quantite { get; set; }
        public double Prix{ get; set; }
        
    }
}
