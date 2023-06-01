namespace Dragonfly.UmbracoDeployTools.Services
{
    using Dragonfly.UmbracoServices;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using Umbraco.Cms.Core.Hosting;
    using Umbraco.Cms.Core.Services;
    using Umbraco.Cms.Web.Common;

    public class DependencyLoader
    {
        public IHostingEnvironment HostingEnvironment { get; }
        public IHttpContextAccessor ContextAccessor { get; }
        
        public UmbracoHelper UmbHelper;

        public HttpContext Context;

        public ServiceContext Services;
        public Dragonfly.NetHelperServices.FileHelperService DragonflyFileHelperService { get; }
        public DependencyLoader(
            IHostingEnvironment hostingEnvironment,
            IHttpContextAccessor contextAccessor,
            Dragonfly.NetHelperServices.FileHelperService fileHelperService,
            ServiceContext serviceContext
           )
        {
            HostingEnvironment = hostingEnvironment;
            ContextAccessor = contextAccessor;
            UmbHelper = contextAccessor.HttpContext.RequestServices.GetRequiredService<UmbracoHelper>();
            DragonflyFileHelperService = fileHelperService;
            Context = contextAccessor.HttpContext;
            Services = serviceContext;
        }
    }
}
