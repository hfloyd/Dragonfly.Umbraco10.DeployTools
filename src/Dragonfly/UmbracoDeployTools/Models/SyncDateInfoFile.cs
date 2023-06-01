namespace Dragonfly.UmbracoDeployTools.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using DeployToolsService = Dragonfly.UmbracoDeployTools.DeployToolsService;

    public class SyncDateInfoFile
    {
        public List<SyncDateInfo> Syncs { get; set; }

        public SyncDateInfoFile()
        {
            this.Syncs = new List<SyncDateInfo>();
        }
    }


    public class SyncDateInfo
    {
        public Workspace RemoteEnvironment { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public DeployToolsService.NodesType Type { get; set; }

        public DateTime SyncDate { get; set; }

        public SyncDateInfo()
        {

        }
        public SyncDateInfo(Workspace Environment, DeployToolsService.NodesType NodesType, DateTime UtcDateTime)
        {
            this.RemoteEnvironment = Environment;
            this.Type = Type;
            this.SyncDate = UtcDateTime;
        }
    }
}
