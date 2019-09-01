using System;
using System.Collections.Generic;
using System.Text;

namespace TangjinJam.Infrastructure.Model
{
    public class AdditionalChildItem
    {
        public string Id { get; set; }

        public string ChildName { get; set; }

        public decimal Priority { get; set; }

        public DateTime GetDateTime { get; set; }

        public bool IsGet { get; set; }
    }
}
