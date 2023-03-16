using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class ItemPrice
    {
       public decimal wholesaleItem { get; set; }

        public ItemPrice(decimal wsi)
        {
            wholesaleItem = wsi;
        }
    }
}
