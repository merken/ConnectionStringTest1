using System;
using System.Collections.Generic;

namespace ConnectionStringTest1.Model
{
    public partial class MyTable
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedTimeStamp { get; set; }
        public string Description { get; set; }
    }
}
