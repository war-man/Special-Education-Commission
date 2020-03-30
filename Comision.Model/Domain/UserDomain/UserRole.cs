///////////////////////////////////////////////////////////
//  UserRole.cs
//  Implementation of the Class UserRole
//  Generated by Enterprise Architect
//  Created on:      09-Jun-2016 8:23:37 AM
//  Original author: ali-laptop
///////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity.EntityFramework;

namespace Comision.Model.Domain.UserDomain
{
    /// <summary>
    /// <span dir="rtl">���</span>
    /// </summary>
    public class UserRole: IdentityUserRole<long>
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        public UserRole() { }

    }//end UserRole
}