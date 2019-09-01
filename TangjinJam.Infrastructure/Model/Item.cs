using System;
using System.Collections.Generic;
using System.Text;

namespace TangjinJam.Infrastructure.Model
{
    public class Item
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ItemDetail ItemDetail { get; set; }

        public List<AdditionalChildItem> AdditionalChildItems { get; set; }
    }
}
