using System;
using System.Collections.Generic;
using System.Text;

namespace RedisWithDotNet
{
    public class Client
    {
        public Client(Guid key)
        {
            Key = key;
        }
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }

    }
}
