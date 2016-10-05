using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.IServices
{
    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public interface IBlogService:IRepository<Blog>
    {
    }

}