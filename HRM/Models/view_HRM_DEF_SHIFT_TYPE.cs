﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class view_HRM_DEF_SHIFT_TYPE
    {
        public int CODE { get; set; }
        public string DESC { get; set; }
        public string AUTH_STATUS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public Nullable<decimal> AUTH_BY { get; set; }
        public string AUTH_REMARKS { get; set; }
        public Nullable<decimal> INACTIVE { get; set; }
    }
}