using System.Configuration;
using System.Net;

namespace Scribe.Configuration
{
    public class ServerElement : ConfigurationElement
    {
        [ConfigurationProperty("address", IsRequired = true, IsKey = true)]
        public string Address
        {
            get { return (string)base["address"]; }
            set { base["address"] = value; }
        }

        [ConfigurationProperty("port", IsRequired = true, IsKey = true), IntegerValidator(MinValue = 0, MaxValue = 65535)]
        public int Port
        {
            get { return (int)base["port"]; }
            set { base["port"] = value; }
        }

        private IPEndPoint _server;
        public IPEndPoint Server
        {
            get
            {
                if (_server != null)
                {
                    return _server;
                }

                var ipaddress = IPAddress.Parse(Address);
                _server = new IPEndPoint(ipaddress, Port);

                return _server;
            }
            set { _server = value; }
        }
    }
}