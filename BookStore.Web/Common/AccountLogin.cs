﻿using System;

namespace BookStore.Web.Common
{
    [Serializable]
    public class AccountLogin
    {
        public int UserID { set; get; }
        public string UserName { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
    }
}