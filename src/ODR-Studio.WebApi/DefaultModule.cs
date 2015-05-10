﻿using log4net;
using Nancy;
using Newtonsoft.Json;
using Odr_DabMux_Runner;

namespace ODR_Studio.WebApi
{
    public class DefaultModule : NancyModule
    {

        public DefaultModule(ILog log)
        {
            log.Debug("Initializing DefaultModule...");

            Get["/configs"] = x =>
            {
                log.Debug("GET [/configs] route hit received");

                var configs = new[] { DabMuxConfig.OutputToFileConfig };
                var json = JsonConvert.SerializeObject(configs);

                return json;
            };

            Get["/run"] = x =>
            {
                log.Debug("GET [/run] route hit received");

                Runner runner = new Runner();
                string result = runner.RunDefaultConfigurationFile();
                var json = JsonConvert.SerializeObject(new[] { result });

                return json;
            };
        }
    }
}
