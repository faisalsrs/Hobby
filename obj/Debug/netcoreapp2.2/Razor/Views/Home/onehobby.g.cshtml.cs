#pragma checksum "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7517a7928ee07fbd9d843b845359dc18a4b0ab65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_onehobby), @"mvc.1.0.view", @"/Views/Home/onehobby.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/onehobby.cshtml", typeof(AspNetCore.Views_Home_onehobby))]
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
#line 1 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\_ViewImports.cshtml"
using BeltExam3;

#line default
#line hidden
#line 2 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\_ViewImports.cshtml"
using BeltExam3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7517a7928ee07fbd9d843b845359dc18a4b0ab65", @"/Views/Home/onehobby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abdac35439fa2b118bcaf2f7e2f945d13f14650", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_onehobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hobby>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 7, true);
            WriteLiteral("\r\n<h1> ");
            EndContext();
            BeginContext(22, 10, false);
#line 3 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(32, 12, true);
            WriteLiteral("</h1>\r\n<h3> ");
            EndContext();
            BeginContext(45, 17, false);
#line 4 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(62, 20, true);
            WriteLiteral("</h3>\r\n\r\n<div>\r\n<p> ");
            EndContext();
            BeginContext(83, 10, false);
#line 7 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(93, 20, true);
            WriteLiteral(" Enthusiasts: </p>\r\n");
            EndContext();
#line 8 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
 foreach (JOIN join in @Model.CreatedJOINs){

#line default
#line hidden
            BeginContext(159, 10, true);
            WriteLiteral("<ul>\r\n    ");
            EndContext();
            BeginContext(170, 19, false);
#line 10 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
Write(join.UserJOIN.fname);

#line default
#line hidden
            EndContext();
            BeginContext(189, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(191, 19, false);
#line 10 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
                    Write(join.UserJOIN.lname);

#line default
#line hidden
            EndContext();
            BeginContext(210, 9, true);
            WriteLiteral("\r\n</ul>\r\n");
            EndContext();
            BeginContext(221, 32, true);
            WriteLiteral("<p> Become an Enthusiasts!</p>\r\n");
            EndContext();
#line 15 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
  if(join.UserId ==  Model.Creator.UserId){

#line default
#line hidden
            BeginContext(300, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7517a7928ee07fbd9d843b845359dc18a4b0ab657292", async() => {
                BeginContext(406, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-HobbyId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
                            WriteLiteral(join.HobbyId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["HobbyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-HobbyId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["HobbyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
}else if(Model.CreatedJOINs.Any(a => a.UserId == Model.Creator.UserId)){

#line default
#line hidden
            BeginContext(490, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7517a7928ee07fbd9d843b845359dc18a4b0ab6510118", async() => {
                BeginContext(585, 31, true);
                WriteLiteral("<button>Add to Hobbies</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-HobbyId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
                               WriteLiteral(Model.HobbyId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["HobbyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-HobbyId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["HobbyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(623, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
}

#line default
#line hidden
#line 19 "C:\Users\faisa\Documents\Coding_Dojo\CSharp\BeltExam3\Views\Home\onehobby.cshtml"
 
}

#line default
#line hidden
            BeginContext(631, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hobby> Html { get; private set; }
    }
}
#pragma warning restore 1591
