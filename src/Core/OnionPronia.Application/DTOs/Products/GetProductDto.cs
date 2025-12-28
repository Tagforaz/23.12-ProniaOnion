

using OnionPronia.Application.DTOs.Categories;


namespace OnionPronia.Application.DTOs.Products
{
    public record GetProductDto
    (
        long Id,
        string Name,
        decimal Price,
        string SKU,
        string Description,
        GetCategoryInProductDto CategoryDto,
        ICollection<GetTagInProductDto> TagDtos,
        ICollection<GetSizeInProductDto> SizeDtos,
        ICollection<GetColorInProductDto> ColorDtos

        );
}
