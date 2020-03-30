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
namespace Comision.Ui.Controllers
{
    public partial class AccountController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AccountController(Dummy d) { }

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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ConfirmEmail()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmEmail);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Login()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Login);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CheckProfile()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CheckProfile);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ResetPassword()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> IsEmailExist()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IsEmailExist);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CompareCaptcha()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CompareCaptcha);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> IsEmailConfirmed()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IsEmailConfirmed);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> HasValidIdentificationCode()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HasValidIdentificationCode);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> HasValidNationalCode()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HasValidNationalCode);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult IsStudentExist()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IsStudentExist);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AccountController Actions { get { return MVC.Account; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Account";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Account";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string RegisterProgramCentralOrganization = "RegisterProgramCentralOrganization";
            public readonly string RegisterProgramBranchProvince = "RegisterProgramBranchProvince";
            public readonly string RegisterProgramUniversity = "RegisterProgramUniversity";
            public readonly string RegisterUser = "RegisterUser";
            public readonly string ConfirmEmail = "ConfirmEmail";
            public readonly string Login = "Login";
            public readonly string CheckProfile = "CheckProfile";
            public readonly string ForgetPassword = "ForgetPassword";
            public readonly string ForgetPasswordConfirmation = "ForgetPasswordConfirmation";
            public readonly string ResetPassword = "ResetPassword";
            public readonly string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            public readonly string IsEmailExist = "IsEmailExist";
            public readonly string CompareCaptcha = "CompareCaptcha";
            public readonly string IsEmailConfirmed = "IsEmailConfirmed";
            public readonly string HasValidIdentificationCode = "HasValidIdentificationCode";
            public readonly string HasValidNationalCode = "HasValidNationalCode";
            public readonly string IsStudentExist = "IsStudentExist";
            public readonly string LogOff = "LogOff";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string RegisterProgramCentralOrganization = "RegisterProgramCentralOrganization";
            public const string RegisterProgramBranchProvince = "RegisterProgramBranchProvince";
            public const string RegisterProgramUniversity = "RegisterProgramUniversity";
            public const string RegisterUser = "RegisterUser";
            public const string ConfirmEmail = "ConfirmEmail";
            public const string Login = "Login";
            public const string CheckProfile = "CheckProfile";
            public const string ForgetPassword = "ForgetPassword";
            public const string ForgetPasswordConfirmation = "ForgetPasswordConfirmation";
            public const string ResetPassword = "ResetPassword";
            public const string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            public const string IsEmailExist = "IsEmailExist";
            public const string CompareCaptcha = "CompareCaptcha";
            public const string IsEmailConfirmed = "IsEmailConfirmed";
            public const string HasValidIdentificationCode = "HasValidIdentificationCode";
            public const string HasValidNationalCode = "HasValidNationalCode";
            public const string IsStudentExist = "IsStudentExist";
            public const string LogOff = "LogOff";
        }


        static readonly ActionParamsClass_RegisterProgramCentralOrganization s_params_RegisterProgramCentralOrganization = new ActionParamsClass_RegisterProgramCentralOrganization();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RegisterProgramCentralOrganization RegisterProgramCentralOrganizationParams { get { return s_params_RegisterProgramCentralOrganization; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RegisterProgramCentralOrganization
        {
            public readonly string registerProgramCentralOrganizationModel = "registerProgramCentralOrganizationModel";
        }
        static readonly ActionParamsClass_RegisterProgramBranchProvince s_params_RegisterProgramBranchProvince = new ActionParamsClass_RegisterProgramBranchProvince();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RegisterProgramBranchProvince RegisterProgramBranchProvinceParams { get { return s_params_RegisterProgramBranchProvince; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RegisterProgramBranchProvince
        {
            public readonly string registerProgramBranchProvinceModel = "registerProgramBranchProvinceModel";
        }
        static readonly ActionParamsClass_RegisterProgramUniversity s_params_RegisterProgramUniversity = new ActionParamsClass_RegisterProgramUniversity();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RegisterProgramUniversity RegisterProgramUniversityParams { get { return s_params_RegisterProgramUniversity; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RegisterProgramUniversity
        {
            public readonly string registerProgramUniversityModel = "registerProgramUniversityModel";
        }
        static readonly ActionParamsClass_RegisterUser s_params_RegisterUser = new ActionParamsClass_RegisterUser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RegisterUser RegisterUserParams { get { return s_params_RegisterUser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RegisterUser
        {
            public readonly string registerUserViewModel = "registerUserViewModel";
        }
        static readonly ActionParamsClass_ConfirmEmail s_params_ConfirmEmail = new ActionParamsClass_ConfirmEmail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ConfirmEmail ConfirmEmailParams { get { return s_params_ConfirmEmail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ConfirmEmail
        {
            public readonly string userId = "userId";
            public readonly string code = "code";
        }
        static readonly ActionParamsClass_Login s_params_Login = new ActionParamsClass_Login();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Login LoginParams { get { return s_params_Login; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Login
        {
            public readonly string returnUrl = "returnUrl";
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_CheckProfile s_params_CheckProfile = new ActionParamsClass_CheckProfile();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CheckProfile CheckProfileParams { get { return s_params_CheckProfile; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CheckProfile
        {
            public readonly string userId = "userId";
        }
        static readonly ActionParamsClass_ForgetPassword s_params_ForgetPassword = new ActionParamsClass_ForgetPassword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ForgetPassword ForgetPasswordParams { get { return s_params_ForgetPassword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ForgetPassword
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_ResetPassword s_params_ResetPassword = new ActionParamsClass_ResetPassword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ResetPassword ResetPasswordParams { get { return s_params_ResetPassword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ResetPassword
        {
            public readonly string code = "code";
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_IsEmailExist s_params_IsEmailExist = new ActionParamsClass_IsEmailExist();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_IsEmailExist IsEmailExistParams { get { return s_params_IsEmailExist; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_IsEmailExist
        {
            public readonly string email = "email";
        }
        static readonly ActionParamsClass_CompareCaptcha s_params_CompareCaptcha = new ActionParamsClass_CompareCaptcha();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CompareCaptcha CompareCaptchaParams { get { return s_params_CompareCaptcha; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CompareCaptcha
        {
            public readonly string captcha = "captcha";
        }
        static readonly ActionParamsClass_IsEmailConfirmed s_params_IsEmailConfirmed = new ActionParamsClass_IsEmailConfirmed();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_IsEmailConfirmed IsEmailConfirmedParams { get { return s_params_IsEmailConfirmed; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_IsEmailConfirmed
        {
            public readonly string email = "email";
        }
        static readonly ActionParamsClass_HasValidIdentificationCode s_params_HasValidIdentificationCode = new ActionParamsClass_HasValidIdentificationCode();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HasValidIdentificationCode HasValidIdentificationCodeParams { get { return s_params_HasValidIdentificationCode; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HasValidIdentificationCode
        {
            public readonly string identificationCode = "identificationCode";
        }
        static readonly ActionParamsClass_HasValidNationalCode s_params_HasValidNationalCode = new ActionParamsClass_HasValidNationalCode();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HasValidNationalCode HasValidNationalCodeParams { get { return s_params_HasValidNationalCode; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HasValidNationalCode
        {
            public readonly string nationalCode = "nationalCode";
        }
        static readonly ActionParamsClass_IsStudentExist s_params_IsStudentExist = new ActionParamsClass_IsStudentExist();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_IsStudentExist IsStudentExistParams { get { return s_params_IsStudentExist; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_IsStudentExist
        {
            public readonly string studentNumber = "studentNumber";
            public readonly string requestType = "requestType";
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
                public readonly string ConfirmEmail = "ConfirmEmail";
                public readonly string DisplayEmail = "DisplayEmail";
                public readonly string ForgetPassword = "ForgetPassword";
                public readonly string ForgetPasswordConfirmation = "ForgetPasswordConfirmation";
                public readonly string Login = "Login";
                public readonly string RegisterProgramBranchProvince = "RegisterProgramBranchProvince";
                public readonly string RegisterProgramCentralOrganization = "RegisterProgramCentralOrganization";
                public readonly string RegisterProgramUniversity = "RegisterProgramUniversity";
                public readonly string RegisterUser = "RegisterUser";
                public readonly string ResetPassword = "ResetPassword";
                public readonly string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            }
            public readonly string ConfirmEmail = "~/Views/Account/ConfirmEmail.cshtml";
            public readonly string DisplayEmail = "~/Views/Account/DisplayEmail.cshtml";
            public readonly string ForgetPassword = "~/Views/Account/ForgetPassword.cshtml";
            public readonly string ForgetPasswordConfirmation = "~/Views/Account/ForgetPasswordConfirmation.cshtml";
            public readonly string Login = "~/Views/Account/Login.cshtml";
            public readonly string RegisterProgramBranchProvince = "~/Views/Account/RegisterProgramBranchProvince.cshtml";
            public readonly string RegisterProgramCentralOrganization = "~/Views/Account/RegisterProgramCentralOrganization.cshtml";
            public readonly string RegisterProgramUniversity = "~/Views/Account/RegisterProgramUniversity.cshtml";
            public readonly string RegisterUser = "~/Views/Account/RegisterUser.cshtml";
            public readonly string ResetPassword = "~/Views/Account/ResetPassword.cshtml";
            public readonly string ResetPasswordConfirmation = "~/Views/Account/ResetPasswordConfirmation.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AccountController : Comision.Ui.Controllers.AccountController
    {
        public T4MVC_AccountController() : base(Dummy.Instance) { }

        [NonAction]
        partial void RegisterProgramCentralOrganizationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterProgramCentralOrganization()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterProgramCentralOrganization);
            RegisterProgramCentralOrganizationOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RegisterProgramCentralOrganizationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Service.Model.RegisterProgramCentralOrganizationModel registerProgramCentralOrganizationModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterProgramCentralOrganization(Comision.Service.Model.RegisterProgramCentralOrganizationModel registerProgramCentralOrganizationModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterProgramCentralOrganization);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "registerProgramCentralOrganizationModel", registerProgramCentralOrganizationModel);
            RegisterProgramCentralOrganizationOverride(callInfo, registerProgramCentralOrganizationModel);
            return callInfo;
        }

        [NonAction]
        partial void RegisterProgramBranchProvinceOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterProgramBranchProvince()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterProgramBranchProvince);
            RegisterProgramBranchProvinceOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RegisterProgramBranchProvinceOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Service.Model.RegisterProgramBranchProvinceModel registerProgramBranchProvinceModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterProgramBranchProvince(Comision.Service.Model.RegisterProgramBranchProvinceModel registerProgramBranchProvinceModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterProgramBranchProvince);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "registerProgramBranchProvinceModel", registerProgramBranchProvinceModel);
            RegisterProgramBranchProvinceOverride(callInfo, registerProgramBranchProvinceModel);
            return callInfo;
        }

        [NonAction]
        partial void RegisterProgramUniversityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterProgramUniversity()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterProgramUniversity);
            RegisterProgramUniversityOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RegisterProgramUniversityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Service.Model.RegisterProgramUniversityModel registerProgramUniversityModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterProgramUniversity(Comision.Service.Model.RegisterProgramUniversityModel registerProgramUniversityModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterProgramUniversity);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "registerProgramUniversityModel", registerProgramUniversityModel);
            RegisterProgramUniversityOverride(callInfo, registerProgramUniversityModel);
            return callInfo;
        }

        [NonAction]
        partial void RegisterUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RegisterUser()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterUser);
            RegisterUserOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RegisterUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Ui.Models.RegisterUserViewModel registerUserViewModel);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RegisterUser(Comision.Ui.Models.RegisterUserViewModel registerUserViewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RegisterUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "registerUserViewModel", registerUserViewModel);
            RegisterUserOverride(callInfo, registerUserViewModel);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void ConfirmEmailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? userId, string code);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ConfirmEmail(int? userId, string code)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmEmail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "code", code);
            ConfirmEmailOverride(callInfo, userId, code);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void LoginOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string returnUrl);

        [NonAction]
        public override System.Web.Mvc.ActionResult Login(string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Login);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            LoginOverride(callInfo, returnUrl);
            return callInfo;
        }

        [NonAction]
        partial void LoginOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Ui.Models.LoginViewModel model, string returnUrl);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Login(Comision.Ui.Models.LoginViewModel model, string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Login);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            LoginOverride(callInfo, model, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void CheckProfileOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? userId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CheckProfile(long? userId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CheckProfile);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            CheckProfileOverride(callInfo, userId);
            return callInfo;
        }

        [NonAction]
        partial void ForgetPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ForgetPassword()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ForgetPassword);
            ForgetPasswordOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ForgetPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Ui.Models.ForgetPasswordViewModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ForgetPassword(Comision.Ui.Models.ForgetPasswordViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ForgetPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ForgetPasswordOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void ForgetPasswordConfirmationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ForgetPasswordConfirmation()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ForgetPasswordConfirmation);
            ForgetPasswordConfirmationOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ResetPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string code);

        [NonAction]
        public override System.Web.Mvc.ActionResult ResetPassword(string code)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "code", code);
            ResetPasswordOverride(callInfo, code);
            return callInfo;
        }

        [NonAction]
        partial void ResetPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Comision.Ui.Models.ResetPasswordViewModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ResetPassword(Comision.Ui.Models.ResetPasswordViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ResetPasswordOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void ResetPasswordConfirmationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ResetPasswordConfirmation()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResetPasswordConfirmation);
            ResetPasswordConfirmationOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void IsEmailExistOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string email);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> IsEmailExist(string email)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IsEmailExist);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "email", email);
            IsEmailExistOverride(callInfo, email);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void CompareCaptchaOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string captcha);

        [NonAction]
        public override System.Web.Mvc.ActionResult CompareCaptcha(string captcha)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CompareCaptcha);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "captcha", captcha);
            CompareCaptchaOverride(callInfo, captcha);
            return callInfo;
        }

        [NonAction]
        partial void IsEmailConfirmedOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string email);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> IsEmailConfirmed(string email)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IsEmailConfirmed);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "email", email);
            IsEmailConfirmedOverride(callInfo, email);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void HasValidIdentificationCodeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string identificationCode);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> HasValidIdentificationCode(string identificationCode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HasValidIdentificationCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "identificationCode", identificationCode);
            HasValidIdentificationCodeOverride(callInfo, identificationCode);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void HasValidNationalCodeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string nationalCode);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> HasValidNationalCode(string nationalCode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HasValidNationalCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "nationalCode", nationalCode);
            HasValidNationalCodeOverride(callInfo, nationalCode);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void IsStudentExistOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long studentNumber, int requestType);

        [NonAction]
        public override System.Web.Mvc.ActionResult IsStudentExist(long studentNumber, int requestType)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IsStudentExist);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "studentNumber", studentNumber);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "requestType", requestType);
            IsStudentExistOverride(callInfo, studentNumber, requestType);
            return callInfo;
        }

        [NonAction]
        partial void LogOffOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> LogOff()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LogOff);
            LogOffOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114