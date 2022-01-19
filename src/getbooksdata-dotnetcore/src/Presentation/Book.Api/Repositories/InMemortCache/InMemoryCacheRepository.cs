﻿using Book.Api.Entities;
using EasyCaching.Core;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Api.Repositories.InMemortCache
{
    public class InMemoryCacheRepository : IInMemoryCacheRepository
    {
        private readonly IEasyCachingProvider _cache;

        public InMemoryCacheRepository(IEasyCachingProvider cache)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }
        public async Task AddBook(BasicBookData book)
        {
            await _cache.SetAsync(book.id, book, TimeSpan.FromDays(3));

        }

        public async Task DeleteBook(string id)
        {
            await _cache.RemoveAsync(id);
        }

        public async Task<BasicBookData> GetBook(string id)
        {
            var book = await _cache.GetAsync<BasicBookData>(id);

            if (!book.HasValue)
                return null;

            return book.Value;
        }
    }
}
