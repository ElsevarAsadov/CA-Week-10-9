using Pustok.Models;

namespace Pustok.Core.Models;

public class BasketProductItem : BaseEntity
{
    public string AppUserId { get; set; }
    public int BookId { get; set; }
    public int Count { get; set; }

    public Book Book { get; set; }
    public AppUser AppUser { get; set; }
}
