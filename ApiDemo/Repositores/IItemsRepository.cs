﻿using ApiDemo.Models;

namespace ApiDemo.Repositores
{
    public interface IItemsRepository
    {
        public Task<IEnumerable<Item>> GetItemsAsync();
        public Task<Item?> GetItemAsync(Guid id);
        public Task CreateItemAsync(Item item);
        public Task UpdateItemAsync(Item item);
        public Task DeleteItemAsync(Guid id);
    }
}