using Pioneer.Linq;
using Pioneer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pioneer.Class.CLASS_MODEL
{
    public class MODEL_APP
    {
        public string FUNC_CODE { get; set; }
        public Models.Register register { get; set; }
        public BANK_TRANSFER BANK_TRANSFER { get; set; }
        public BANK_TRANSFER_DETAIL BANK_TRANSFER_DETAIL { get; set; }
        public ACCOUNT_DELIVERY_SETTING ACCOUNT_DELIVERY_SETTING { get; set; }
        public MEMBER MEMBER { get; set; }
        public PRODUCT PRODUCT { get; set; }
        public PRODUCER PRODUCER { get; set; }

    }
}