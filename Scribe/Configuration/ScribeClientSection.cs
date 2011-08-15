using System;
using System.Configuration;

namespace Scribe.Configuration
{
    public sealed class ScribeClientSection : ConfigurationSection
    {
        [ConfigurationProperty("server", IsRequired = true)]
        public ServerElement Server
        {
            get { return (ServerElement)base["server"]; }
        }

        //ServerElement Server
        //{
        //    get { return Server; }
        //}
    }
}