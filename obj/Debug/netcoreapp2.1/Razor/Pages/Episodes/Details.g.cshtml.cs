#pragma checksum "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679ad89c6f22fd16feff707525f831b979f0f31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HolidayChecklist.Pages.Episodes.Pages_Episodes_Details), @"mvc.1.0.razor-page", @"/Pages/Episodes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Episodes/Details.cshtml", typeof(HolidayChecklist.Pages.Episodes.Pages_Episodes_Details), null)]
namespace HolidayChecklist.Pages.Episodes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\GitHub\HolidayChecklist\Pages\_ViewImports.cshtml"
using HolidayChecklist;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679ad89c6f22fd16feff707525f831b979f0f31b", @"/Pages/Episodes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f90e6b79a2498bf38006f64a6095ea7bf4a53d3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Episodes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(105, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Episode</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(227, 50, false);
#line 15 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.ShowID));

#line default
#line hidden
            EndContext();
            BeginContext(277, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(321, 46, false);
#line 18 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.ShowID));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 56, false);
#line 21 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.SeasonNumber));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 52, false);
#line 24 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.SeasonNumber));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(607, 53, false);
#line 27 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.ShowTitle));

#line default
#line hidden
            EndContext();
            BeginContext(660, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(704, 49, false);
#line 30 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.ShowTitle));

#line default
#line hidden
            EndContext();
            BeginContext(753, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(797, 60, false);
#line 33 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.ShowBackdropPath));

#line default
#line hidden
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(901, 56, false);
#line 36 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.ShowBackdropPath));

#line default
#line hidden
            EndContext();
            BeginContext(957, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1001, 56, false);
#line 39 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.ShowOverview));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1101, 52, false);
#line 42 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.ShowOverview));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1197, 58, false);
#line 45 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.EpisodeAirDate));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1299, 54, false);
#line 48 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.EpisodeAirDate));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1397, 57, false);
#line 51 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.EpisodeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1498, 53, false);
#line 54 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.EpisodeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1595, 56, false);
#line 57 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.EpisodeTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1695, 52, false);
#line 60 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.EpisodeTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1791, 59, false);
#line 63 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Episode.EpisodeOverview));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1894, 55, false);
#line 66 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Episode.EpisodeOverview));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1996, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17892b83cf60404bb325f614eda0d2e8", async() => {
                BeginContext(2057, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "E:\GitHub\HolidayChecklist\Pages\Episodes\Details.cshtml"
                           WriteLiteral(Model.Episode.EpisodeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2065, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2073, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d0b573841d42669a732875cdbfb0e4", async() => {
                BeginContext(2095, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2111, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HolidayChecklist.Pages.Episodes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolidayChecklist.Pages.Episodes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HolidayChecklist.Pages.Episodes.DetailsModel>)PageContext?.ViewData;
        public HolidayChecklist.Pages.Episodes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
