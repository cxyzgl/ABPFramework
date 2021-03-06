﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CXY.CJS.Model
{
    public class User : Entity<string>, ISoftDelete
    {


        public string UserName { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string WebSiteId { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastLoginTime { get; set; }

        public string CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public string LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public string DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }

        public User()
        {
            CreationTime = Clock.Now;
            IsActive = true;
        }
    }
}
