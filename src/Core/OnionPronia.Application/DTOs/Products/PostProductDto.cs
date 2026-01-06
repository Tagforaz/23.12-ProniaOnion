
namespace OnionPronia.Application.DTOs
{
    public record PostProductDto
    (
        string Name,
        decimal Price,
        string SKU,
        string Description,
        long CategoryId,
        ICollection<long> TagIds

    );
    
}
