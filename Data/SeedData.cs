using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Models;

namespace WebApplication.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Blogs.Any())
                {
                    return;   // 已经初始化过数据，直接返回
                }

                 Guid _categorytId = Guid.NewGuid();

                //增加一个分类
                context.Categorys.Add(
                   new Category
                   {
                       Name = "原创",
                       Id = _categorytId
                   }
                );
                //增加一些博客
                context.Blogs.AddRange(
                     new Blog
                     {
                         Id = Guid.NewGuid(),
                         Title = "编程与营销、金融相结合",
                         Content = "突然发然，编程与营销、金融相结合后会有很好的发展前景。以后在写......",
                         CategoryId = _categorytId,
                         Tags ="{'tags','['营销','金融']'}",
                         Author = "taosilly",
                         CreateDate = DateTime.Now
                     },
                      new Blog
                     {
                         Id = Guid.NewGuid(),
                         Title = "支付宝到位不到位",
                         Content = "据悉，用户点击“到位”，地图上就呈现出服务者提供的健身、手工、维修等十余个类目的服务，继续点击服务者头像，就可以显示出具体服务内容、价格以及芝麻信用分等基础信息。确认预约后，资金会先冻结在支付宝账户中，待对方完成服务后确认，资金则解冻流出。由于双方都是支付宝实名，且有芝麻信用分作为参考，因此服务质量和安全保障更高。",
                         CategoryId = _categorytId,
                         Tags ="{'tags','['支付宝','金融']'}",
                         Author = "taosilly",
                         CreateDate = DateTime.Now
                     }
                );
                context.Commit();
            }
        }
    }

}