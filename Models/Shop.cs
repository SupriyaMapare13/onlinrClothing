
namespace OnlineCloth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop
    {
        public int DesignId { get; set; }

        public string Color { get; set; }
        public string Size { get; set; }
        public string DesignData { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
