using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.IServices;
using WebApplication.Models;

namespace WebApplication.Services
{
    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public class CategoryService:RepositoryBase<Category>,ICategoryService
    {
        public CategoryService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }

}