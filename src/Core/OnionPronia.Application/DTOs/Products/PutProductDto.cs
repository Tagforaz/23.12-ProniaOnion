

namespace OnionPronia.Application.DTOs
{
    public record PutProductDto
    (
        string Name,
        decimal Price,
        string SKU,
        string Description,
        long CategoryId,
        ICollection<long> TagIds

    );
    
}
