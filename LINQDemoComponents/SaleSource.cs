﻿namespace LINQDemoComponents;

public class SaleSource
{
    private readonly List<Sale> FullSales = new(3);
    public IReadOnlyList<Sale> Sales => FullSales.ToList();

    public SaleSource()
    {
        FullSales =
            new(3)
            {
                new Sale
                {
                    Id = 123,
                    ProductId = 1,
                    Price = 1000m,
                    ProductColor = "Black"
                },
                new Sale
                {
                    Id = 789,
                    ProductId = 1,
                    Price = 1000m,
                    ProductColor = "Red"
                },
                new Sale
                {
                    Id = 456,
                    ProductId = 2,
                    Price = 1000m,
                    ProductColor = "White"
                }
            };
    }
}