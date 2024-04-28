using API.DTOs;
using API.Entities;

namespace API.Extensions;

public static class BasketExtentions
{
    public static BasketDto MapBasketToDto(this Basket basket)
    {
        return new BasketDto
        {
            Id = basket.Id,
            BuyerId = basket.BuyerId,
            Items = basket.Items.Select(item => new BasketItemDto
            {
                ProductId = item.ProductId,
                Name = item.Product.Name,
                Price = item.Product.Price,
                Brand = item.Product.Brand,
                Type = item.Product.Type,
                Quantity = item.Quantity,
                PictureUrl = item.Product.PictureUrl
            }).ToList()
        };
    }
}