#pragma checksum "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b718596a69dde18c6c9cf8d69da20b78403513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_PersonViewInfo), @"mvc.1.0.view", @"/Views/Person/PersonViewInfo.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\_ViewImports.cshtml"
using LibraryManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\_ViewImports.cshtml"
using LibraryManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b718596a69dde18c6c9cf8d69da20b78403513", @"/Views/Person/PersonViewInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df697ec1d298ed3a8c90f2ec2b1808baa59622f", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_PersonViewInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
  
    var person = Model.Person;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.LabelFor(x => x.Person.PersonID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.LabelFor(x => x.Person.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.LabelFor(x => x.Person.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.LabelFor(x => x.Person.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 31 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.DisplayFor(x => x.Person.PersonID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 34 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.DisplayFor(x => x.Person.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 37 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.DisplayFor(x => x.Person.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 40 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
       Write(Html.DisplayFor(x => x.Person.EmailAddress.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n<table class=\"table\">\r\n    \r\n    ");
#nullable restore
#line 47 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
Write(await Html.PartialAsync("Components/PersonAddressInfoListedPartial", Model.Person.Addresses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n\r\n<table class=\"table\">\r\n    ");
#nullable restore
#line 52 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\PersonViewInfo.cshtml"
Write(await Html.PartialAsync("Components/PersonCheckedBooksListedPartial", Model.Person.CheckedBooks));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
