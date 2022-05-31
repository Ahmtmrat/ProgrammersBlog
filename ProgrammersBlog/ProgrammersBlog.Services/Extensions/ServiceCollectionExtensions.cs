using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete;
using ProgrammersBlog.Data.Concrete.EntityFramework.Context;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection servisCollection)
        {
            servisCollection.AddDbContext<ProgrammersBlogContext>();
            servisCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            servisCollection.AddScoped<ICategoryService, CategoryManager>();
            servisCollection.AddScoped<IArticleService, ArticleManager>();
            return servisCollection;
        }
    }
}
