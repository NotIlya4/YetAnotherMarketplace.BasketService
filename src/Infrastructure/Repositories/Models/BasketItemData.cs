﻿namespace Infrastructure.Repositories.Models;

public class BasketItemData
{
    public string ProductId { get; }
    public int Quantity { get; }

    public BasketItemData(string productId, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }
}