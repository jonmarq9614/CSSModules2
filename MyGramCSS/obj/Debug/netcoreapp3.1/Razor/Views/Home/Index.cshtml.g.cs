#pragma checksum "/Users/jonathanmarquez/Desktop/CSSClass/MyGramCSS/MyGramCSS/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "980c59383d263b25e03484a795e7be159a4372cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/jonathanmarquez/Desktop/CSSClass/MyGramCSS/MyGramCSS/Views/_ViewImports.cshtml"
using MyGramCSS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jonathanmarquez/Desktop/CSSClass/MyGramCSS/MyGramCSS/Views/_ViewImports.cshtml"
using MyGramCSS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980c59383d263b25e03484a795e7be159a4372cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a84d9474c1261db0cd889e67601587c60f6103", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jonathanmarquez/Desktop/CSSClass/MyGramCSS/MyGramCSS/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "980c59383d263b25e03484a795e7be159a4372cb3910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<span>My Gram</span>
<input type=""search"" class=""SearchInput"" placeholder=""Search"">
<button type=""button"" id=""LogIn"">Log In</button>
<button type=""button"" id=""SignUp"" onclick=""location.href='/Home/SignUp'"">Sign Up</button>

<div id=""Div"">
    <div class=""Table1"">

        <div>
            <img src=""https://upload.wikimedia.org/wikipedia/en/thumb/4/40/Razer_snake_logo.svg/1200px-Razer_snake_logo.svg.png""
                 width=""100"" height=""100"">
        </div>
        <div>
            <span>Profile Name</span>
            <button type=""button"" id=""Follow"">Follow</button>
            <br>
            <span>0 Posts  0 Followers  0 Following</span>
            <br>
            <span>Description</span>
            <br>
        </div>


    </div>
</div>
<div class=""Story"">

    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdu5J1IKFOpM-Ix06Yizy3oORyMXHkaXaD2A&usqp=CAU""
             width=""50"" height=""50"">
    </div>
    <div>
        <img src=""https://encrypted-tbn0.gstatic.com");
            WriteLiteral(@"/images?q=tbn:ANd9GcTNQOCw1ZGoL2xM0PLI-Pg7KNRNEPFtQD8gpA&usqp=CAU""
             width=""50"" height=""50"">
    </div>

    <div>Story1</div>
    <div>Story2</div>

</div>

<div class=""Table2"">

    <div>POSTS</div>
    <div>REELS</div>
    <div>IGTV</div>
    <div>TAGGED</div>
    <div onclick=""location.href='/Home/Calendar'"">View By Calander</div>

</div>
<div class=""Table3"">

    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaq8kIhgpcbd3rG3Qn8rfwR7AZTIp90Zy9Rw&usqp=CAU""
             width=""150"" height=""150"">
    </div>
    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvAoRTkAfM8KIiGHt3QDHZ5CjhaxlO-Jr0yg&usqp=CAU""
             width=""150"" height=""150"">
    </div>
    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRG-Gf487I-jnE_DX2K2pycUbVsyg8KmqyLQ&usqp=CAU""
             width=""150"" height=""150"">
    </div>

    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLySoy6QEIzANWMAIW8njJ6Drl");
            WriteLiteral(@"jcjeXklLCQ&usqp=CAU""
             width=""150"" height=""150"">
    </div>
    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkDVG00cdjvalKKG6wq6Ml7CU-R_wqiFQHmg&usqp=CAU""
             width=""150"" height=""150"">
    </div>
    <div>
        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR5mm3w_55IA3fc5yB2BfoQXIfwj6RvwcxW5A&usqp=CAU""
             width=""150"" height=""150"">
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
