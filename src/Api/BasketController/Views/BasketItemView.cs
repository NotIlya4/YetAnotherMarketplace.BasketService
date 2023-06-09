﻿namespace Api.Controllers;

public class BasketItemView
{
    public Guid ProductId { get; }
    public int Quantity { get; }

    public BasketItemView(Guid productId, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }
}