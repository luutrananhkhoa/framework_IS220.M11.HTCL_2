﻿using OTDStore.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OTDStore.ViewModels.System.Users
{
    public class UserVM
    {
        public Guid Id { get; set; }

        [Display(Name = "Tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        public string LastName { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime Dob { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Điểm tích lũy")]
        public int Point { get; set; }

        [Display(Name = "Khách hàng thân thiết")]
        public LoyalStatus TypeOfUser { get; set; }
        public IList<string> Roles { get; set; }
    }
}