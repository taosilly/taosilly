using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.IServices;
using WebApplication.Models;

namespace WebApplication.Services
{
    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public class BlogService:RepositoryBase<Blog>,IBlogService
    {
        public BlogService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override IQueryable<Blog> GetAllList()
        {
            return _dbContext.Set<Blog>().Include(item=>item.BlogCategory);
        }

          public override IQueryable<Blog> GetAllList(Expression<Func<Blog, bool>> predicate)
        {
            return _dbContext.Set<Blog>().Include(item=>item.BlogCategory).Where(predicate);
        }
    }

}