﻿using System.Linq;
using System.Threading.Tasks;

namespace A4CoreBlog.Data.Services.Contracts
{
    public interface IBlogService
    {
        T Get<T>(int id);
        T Get<T>(string userId);
        IQueryable<T> GetAll<T>();
        Task<bool> Edit<T>(T model);
    }
}
