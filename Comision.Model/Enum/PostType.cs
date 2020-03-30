﻿///////////////////////////////////////////////////////////
//  PostType.cs
//  Implementation of the Enumeration PostType
//  Generated by Enterprise Architect
//  Created on:      09-Jun-2016 8:23:00 AM
//  Original author: ali-laptop
///////////////////////////////////////////////////////////

using System.ComponentModel;

namespace Comision.Model.Enum
{
    /// <summary>
    /// <span dir="rtl">نوع سمت</span>
    /// </summary>
    public enum PostType : int
    {
        /// <summary>
        /// <span dir="rtl">سازمان مرکزی</span>
        /// </summary>
        [Description("سازمان مرکزی")]
        CentralOrganization = 1,

        /// <summary>
        /// <span dir="rtl">واحد مرکز استان</span>
        /// </summary>
        [Description("واحد مرکز استان")]
        BranchProvince,

        /// <summary>
        /// <span dir="rtl">دانشگاه</span>
        /// </summary>
        [Description("دانشگاه")]
        University,

        /// <summary>
        /// <span dir="rtl">دانشکده</span>
        /// </summary>
        [Description("دانشکده")]
        College,

        /// <summary>
        /// <span dir="rtl">گروه آموزشی</span>
        /// </summary>
        [Description("گروه آموزشی")]
        EducationalGroup,

        [Description("رشته")]
        FieldofStudy

    }//end PostType
}