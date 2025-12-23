namespace OnionPronia.Application.DTOs
{
    public record GetCategoryDto
    (
        int Id,
        string Name,
        IEnumerable<GetProductInCategoryDto> ProductDtos
        );
}
