﻿namespace IdentityServer4.NHibernate.Entities
{
    public abstract class UserClaim : EntityBase<int>
    {
        public string Type { get; set; }
    }
}