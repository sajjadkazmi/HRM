using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class HRM_MASTER
    {
        public Nullable<System.DateTime> CREATION { get; set; }
        public decimal USER_CODE { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<decimal> CNIC { get; set; }
        public string FATHER { get; set; }
        public string MOTHER { get; set; }
        public string SPOUSE { get; set; }
        public string PHONE { get; set; }
        public string CELL { get; set; }
        public string EMAIL { get; set; }
        public Nullable<decimal> GENDER { get; set; }
        public Nullable<decimal> MARITAL { get; set; }
        public Nullable<decimal> KIDS { get; set; }
        public byte[] PHOTO { get; set; }
        public string EMP_CODE { get; set; }
        public Nullable<decimal> EMP_STATUS { get; set; }
        public string LM_EMP_CODE { get; set; }
        public Nullable<decimal> BRANCH_CODE { get; set; }
        public Nullable<decimal> DEPT_CODE { get; set; }
        public Nullable<decimal> TITLE_CODE { get; set; }
        public Nullable<decimal> SHIFT_CODE { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<System.DateTime> DOC { get; set; }
        public Nullable<decimal> RESIGN { get; set; }
        public Nullable<System.DateTime> RESIGN_DATE { get; set; }
        public string BANK_AC_NO { get; set; }
        public string AUTH_STATUS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public Nullable<decimal> AUTH_BY { get; set; }
        public string AUTH_REMARKS { get; set; }
        public Nullable<decimal> INACTIVE { get; set; }
    }
}