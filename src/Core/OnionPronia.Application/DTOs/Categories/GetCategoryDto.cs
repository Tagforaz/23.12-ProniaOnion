namespace OnionPronia.Application.DTOs
{
    public record GetCategoryDto
    (
        long Id,
        string Name,
        ICollection<GetProductInCategoryDto> ProductDtos
        );
}
