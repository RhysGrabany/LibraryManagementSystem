#pragma checksum "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c49d1eda3c8a33cbfcb2bbeb236e5708134772"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Components_PersonAddressInfoListedPartial), @"mvc.1.0.view", @"/Views/Person/Components/PersonAddressInfoListedPartial.cshtml")]
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
#nullable restore
#line 2 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
using LibraryManagementLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c49d1eda3c8a33cbfcb2bbeb236e5708134772", @"/Views/Person/Components/PersonAddressInfoListedPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df697ec1d298ed3a8c90f2ec2b1808baa59622f", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Components_PersonAddressInfoListedPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
  
    foreach (var addressItem in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
           Write(Html.DisplayFor(ai => addressItem.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
           Write(Html.DisplayFor(ai => addressItem.AddressLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
           Write(Html.DisplayFor(ai => addressItem.Town));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
           Write(Html.DisplayFor(ai => addressItem.Postcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\Components\PersonAddressInfoListedPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Address>> Html { get; private set; }
    }
}
#pragma warning restore 1591
