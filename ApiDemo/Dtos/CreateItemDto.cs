﻿namespace ApiDemo.Dtos
{
    public record CreateItemDto
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}