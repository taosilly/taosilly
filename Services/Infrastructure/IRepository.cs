using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Services
{
    /// <summary>
/// 定义泛型仓储接口
/// </summary>
/// <typeparam name="TEntity">实体类型</typeparam>
public interface IRepository<TEntity> where TEntity : DbSetBase
{
    /// <summary>
    /// 获取实体集合
     /// </summary>
    /// <returns></returns>
    IQueryable<TEntity> GetAllList();

    /// <summary>
    /// 根据lambda表达式条件获取实体集合
     /// </summary>
    /// <param name="predicate">lambda表达式条件</param>
    /// <returns></returns>
    IQueryable<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);

    /// <summary>
    /// 根据主键获取实体
     /// </summary>
    /// <param name="id">实体主键</param>
    /// <returns></returns>
    TEntity Get(Guid id);

    /// <summary>
    /// 根据lambda表达式条件获取单个实体
     /// </summary>
    /// <param name="predicate">lambda表达式条件</param>
    /// <returns></returns>
    TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

    /// <summary>
    /// 新增实体
     /// </summary>
    /// <param name="entity">实体</param>
    /// <returns></returns>
    TEntity Insert(TEntity entity);

    /// <summary>
    /// 更新实体
     /// </summary>
    /// <param name="entity">实体</param>
    TEntity Update(TEntity entity);

    /// <summary>
    /// 新增或更新实体
     /// </summary>
    /// <param name="entity">实体</param>
    TEntity InsertOrUpdate(TEntity entity);

    /// <summary>
    /// 删除实体
     /// </summary>
    /// <param name="entity">要删除的实体</param>
    void Delete(TEntity entity);

    /// <summary>
    /// 删除实体
     /// </summary>
    /// <param name="id">实体主键</param>
    void Delete(Guid id);
}
}
