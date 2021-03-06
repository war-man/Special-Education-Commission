// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Comision.Ui.Areas.Admin.Controllers
{
    public partial class AssignmentRoleController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AssignmentRoleController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddOrUpdateAssignmentRole()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddOrUpdateAssignmentRole);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetUserRoles()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetUserRoles);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteAssignmentRole()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteAssignmentRole);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AssignmentRoleController Actions { get { return MVC.Admin.AssignmentRole; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "AssignmentRole";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "AssignmentRole";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string AddOrUpdateAssignmentRole = "AddOrUpdateAssignmentRole";
            public readonly string GetUserRoles = "GetUserRoles";
            public readonly string GetListUser = "GetListUser";
            public readonly string GetListRole = "GetListRole";
            public readonly string DeleteAssignmentRole = "DeleteAssignmentRole";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string AddOrUpdateAssignmentRole = "AddOrUpdateAssignmentRole";
            public const string GetUserRoles = "GetUserRoles";
            public const string GetListUser = "GetListUser";
            public const string GetListRole = "GetListRole";
            public const string DeleteAssignmentRole = "DeleteAssignmentRole";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string userId = "userId";
        }
        static readonly ActionParamsClass_AddOrUpdateAssignmentRole s_params_AddOrUpdateAssignmentRole = new ActionParamsClass_AddOrUpdateAssignmentRole();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddOrUpdateAssignmentRole AddOrUpdateAssignmentRoleParams { get { return s_params_AddOrUpdateAssignmentRole; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddOrUpdateAssignmentRole
        {
            public readonly string userRoleModel = "userRoleModel";
        }
        static readonly ActionParamsClass_GetUserRoles s_params_GetUserRoles = new ActionParamsClass_GetUserRoles();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetUserRoles GetUserRolesParams { get { return s_params_GetUserRoles; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetUserRoles
        {
            public readonly string userId = "userId";
        }
        static readonly ActionParamsClass_DeleteAssignmentRole s_params_DeleteAssignmentRole = new ActionParamsClass_DeleteAssignmentRole();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteAssignmentRole DeleteAssignmentRoleParams { get { return s_params_DeleteAssignmentRole; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteAssignmentRole
        {
            public readonly string userId = "userId";
            public readonly string roleId = "roleId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
            }
            public readonly string Index = "~/Areas/Admin/Views/AssignmentRole/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AssignmentRoleController : Comision.Ui.Areas.Admin.Controllers.AssignmentRoleController
    {
        public T4MVC_AssignmentRoleController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? userId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(long? userId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            IndexOverride(callInfo, userId);
            return callInfo;
        }

        [NonAction]
        partial void AddOrUpdateAssignmentRoleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Service.Model.UserRoleModel userRoleModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddOrUpdateAssignmentRole(Comision.Service.Model.UserRoleModel userRoleModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddOrUpdateAssignmentRole);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userRoleModel", userRoleModel);
            AddOrUpdateAssignmentRoleOverride(callInfo, userRoleModel);
            return callInfo;
        }

        [NonAction]
        partial void GetUserRolesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long userId);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetUserRoles(long userId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetUserRoles);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            GetUserRolesOverride(callInfo, userId);
            return callInfo;
        }

        [NonAction]
        partial void GetListUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetListUser()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetListUser);
            GetListUserOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetListRoleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetListRole()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetListRole);
            GetListRoleOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DeleteAssignmentRoleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long userId, long roleId);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteAssignmentRole(long userId, long roleId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteAssignmentRole);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "roleId", roleId);
            DeleteAssignmentRoleOverride(callInfo, userId, roleId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
