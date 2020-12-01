#pragma checksum "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4fd08d1bbf8aca830823e5da618831616b806c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_SearchPeople), @"mvc.1.0.view", @"/Views/Person/SearchPeople.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4fd08d1bbf8aca830823e5da618831616b806c3", @"/Views/Person/SearchPeople.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df697ec1d298ed3a8c90f2ec2b1808baa59622f", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_SearchPeople : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchPeopleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Person", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersonViewInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
  
    ViewData["Title"] = "Search People";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 13 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
   Write(Html.TextBoxFor(model => model.SearchTerm));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" />\r\n");
#nullable restore
#line 19 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
      
        var People = Model.People;
        if (People != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <label>ID</label>\r\n                <label>First Name</label>\r\n                <label>Last Name</label>\r\n            </div>\r\n");
#nullable restore
#line 30 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
            foreach (var person in People)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <label>");
#nullable restore
#line 33 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
                      Write(person.PersonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label>");
#nullable restore
#line 34 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
                      Write(person.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label>");
#nullable restore
#line 35 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
                      Write(person.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4fd08d1bbf8aca830823e5da618831616b806c36533", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
                          
                            ViewBag.Person = person;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"button\" value=\"View\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 43 "D:\VisualStudioProjects\LibraryManagement\LibraryManagementMVC\Views\Person\SearchPeople.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchPeopleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
