#pragma checksum "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e00dc4eebf82b6db34940b6528bf76f28a328dc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Index), @"mvc.1.0.view", @"/Views/Tasks/Index.cshtml")]
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
#line 1 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\_ViewImports.cshtml"
using TaskList.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\_ViewImports.cshtml"
using TaskList.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\_ViewImports.cshtml"
using TaskList.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\_ViewImports.cshtml"
using TaskList.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00dc4eebf82b6db34940b6528bf76f28a328dc8", @"/Views/Tasks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55bc4a8432de9a6513d7908f04ba6e866151c9cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskList.Domain.TaskItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
  
    ViewData["Title"] = "Tasks";
    Layout = "~/Views/Shared/_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
   Write(Html.ActionLink("Create New Task", "Create", "Tasks", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <td>Task Name</td>
                    <td>Is Task Completed?</td>
                    <td>Task Created</td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                 if (Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                     foreach (var task in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                           Write(task.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                           Write(task.IsCompleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                           Write(task.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 32 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                                               Write(Html.ActionLink("Edit", "Edit", "Tasks", new { Id = task.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 32 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                                                                                                                 Write(Html.ActionLink("Delete", "Delete", "Tasks", new { Id = task.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\" class=\"text-center\">\r\n                            No Records Found.\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Rosa\source\repos\TaskList\TaskList.Web\Views\Tasks\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskList.Domain.TaskItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591