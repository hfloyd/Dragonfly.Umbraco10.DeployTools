namespace Dragonfly.UmbracoDeployTools
{
    using System;
    using System.Collections.Generic;

    public class DeployToolsConfig 
    {

        #region Properties

        public Guid Secret { get; set; }
   
        public List<EnvironmentHost> EnvironmentHosts { get; set; } = new();

        #endregion

    }

    public class EnvironmentHost
    {
        public string HostName { get; set; }
        public string EnvironmentName { get; set; }
    }
}
