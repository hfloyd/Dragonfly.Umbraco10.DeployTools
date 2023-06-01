namespace Dragonfly.UmbracoDeployTools.Models
{
    using System;

    public class StandardViewInfo
    {
        /// <summary>
        /// Current version of DeployTools Package
        /// </summary>
        public Version CurrentToolVersion { get; set; }

        /// <summary>
        /// Current running environment
        /// </summary>
        public Workspace CurrentEnvironment { get; set; }
}
}
