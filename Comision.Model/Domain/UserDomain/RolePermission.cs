///////////////////////////////////////////////////////////
//  RolePermission.cs
//  Implementation of the Class RolePermission
//  Generated by Enterprise Architect
//  Created on:      09-Jun-2016 8:23:17 AM
//  Original author: ali-laptop
///////////////////////////////////////////////////////////

using Comision.Model.Common;

namespace Comision.Model.Domain.UserDomain
{
    /// <summary>
    /// <span dir="rtl">��� ��� ������</span>
    /// </summary>
    public class RolePermission : Auditable
    {
        public long PermissionId { get; set; }
        public long RoleId { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        
        public RolePermission() { }

    }//end RolePermission
}