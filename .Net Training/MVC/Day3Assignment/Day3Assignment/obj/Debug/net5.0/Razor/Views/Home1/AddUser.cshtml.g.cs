#pragma checksum "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\Home1\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4c26d7609b28a4e7462888f757b3a2580fe67d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home1_AddUser), @"mvc.1.0.view", @"/Views/Home1/AddUser.cshtml")]
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
#line 1 "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\_ViewImports.cshtml"
using Day3Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\_ViewImports.cshtml"
using Day3Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4c26d7609b28a4e7462888f757b3a2580fe67d", @"/Views/Home1/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694f206fa32d7481dac9ac1a6e6d711962790ce2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home1_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\Home1\AddUser.cshtml"
 using (Html.BeginForm("SaveUser", "Home1"))

{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n\r\n        ");
#nullable restore
#line 13 "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\Home1\AddUser.cshtml"
   Write(Html.TextBoxFor(user => user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n\r\n        ");
#nullable restore
#line 21 "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\Home1\AddUser.cshtml"
   Write(Html.PasswordFor(user => user.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </p>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Add User\" />\r\n");
#nullable restore
#line 26 "C:\Users\BSUDHIRT\source\repos\Day3Assignment\Day3Assignment\Views\Home1\AddUser.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
