using CleanArchNet6Mine.Infrastructure.Models;

namespace CleanArchNet6Mine.Web.ApiModels
{
    public class ProductDescriptionDto
    {
        public int ProductDescriptionId { get; set; }
        public string Description { get; set; } = null!;
    }
}
