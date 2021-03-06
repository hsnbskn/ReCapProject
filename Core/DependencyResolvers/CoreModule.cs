using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    //Uygulama seviyesinde bağımlılıklarımızı tutar.
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache(); //Arka planda ICacheManager instance oluşturur.
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //arka planda httpcontextaccessor instance oluşturur.
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>(); //arka planda memorycachemanager instance oluşturur.
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
