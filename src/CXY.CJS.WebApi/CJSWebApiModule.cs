﻿using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CXY.CJS.Configuration;
using CXY.CJS.Web.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CXY.CJS.WebApi
{
    [DependsOn(typeof(CJSApplicationModule), typeof(CJSWebCoreModule))]
    public class CJSWebApiModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CJSWebApiModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(typeof(CJSApplicationModule).GetAssembly());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CJSWebApiModule).GetAssembly());
        }
    }
}
