﻿using log4net;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace ODR_Studio.WebApi.Host
{
    public class CustomNancyBootstrapper : DefaultNancyBootstrapper
    {
        private readonly ILog log;

        public CustomNancyBootstrapper(ILog log)
        {
            this.log = log;
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register(log);
        }
    }
}
