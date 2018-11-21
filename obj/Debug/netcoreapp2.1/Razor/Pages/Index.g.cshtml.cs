#pragma checksum "E:\GitHub\HC2\HolidayChecklist\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "891772efde870823b9f7d7eae2008a1e98020309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HolidayChecklist.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(HolidayChecklist.Pages.Pages_Index), null)]
namespace HolidayChecklist.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\GitHub\HC2\HolidayChecklist\Pages\_ViewImports.cshtml"
using HolidayChecklist;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891772efde870823b9f7d7eae2008a1e98020309", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f90e6b79a2498bf38006f64a6095ea7bf4a53d3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\GitHub\HC2\HolidayChecklist\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 117, true);
            WriteLiteral("<div id=\"App\" class= \"container\">\r\n    <div id = \"searchForm\" class = \"container\" style = \"padding-top: 10px;\">\r\n    ");
            EndContext();
            BeginContext(188, 824, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daa227d716f74c878ac490577b39ee29", async() => {
                BeginContext(194, 811, true);
                WriteLiteral(@"
        <div class = ""row"">
            <div class = ""col-xs-8"">
                <input v-model=""searchTerm"" class=""form-control form-control"" type=""text"" placeholder=""Search for a show...""v-on:keyup=""searchShow()"">
                <ul class = ""list-group"">
                     <li  v-for = ""item in searchResults"" class=""list-group-item"">{{item.name}}</li> 
                </ul>
            </div>
            <div class = ""col-xs-2"">
                <button id = ""searchSubmit"" type = ""submit"" class = ""btn btn-primary"" v-on:click.stop.prevent='searchShow()'>Find</button>
            </div>
            <div class = ""col-xs-2"">
                <button id = ""searchCancel"" class = ""btn btn-default"" v-on:click.stop.prevent=""emptySearch()"">Back</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1012, 588, true);
            WriteLiteral(@"
    </div>
    <div id = ""searchResults"" class = ""container"" style=""padding-top: 15px;"" v-if=""showSearchResults"">
        <div class = ""col-xs-12"" v-for = ""item in searchResults"">
            <div class = ""col-xs-10"">
                <img v-bind:src=""imgURL + item.poster_path"" v-bind:alt = ""item.name"" style=""max-width: 100%;""> 
            </div>
            <div class = ""col-xs-2"">
                <button class = ""btn btn-success""><span class=""glyphicon glyphicon-floppy-disk"" style=""color:black""></span></button>
            </div>
        </div> 
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1618, 2057, true);
                WriteLiteral(@"
    <script>
    var ItemsVue = new Vue({
            el: '#App',
            data: {
                searchTerm: """",
                searchResults: """",
                showSearchResults: false,
                baseURL: ""https://api.themoviedb.org/3/"",
                imgURL: ""https://image.tmdb.org/t/p/w200"",
                apiKEY: ""api_key=dfb21457261ef1c427601ffcefc3da80""
            },
            
            mounted: function () {
            
               
            },
            methods: { 
                searchShow: function(searchTerm){
                    var self = this;
                    
                    if(self.searchTerm.length>=3){
                        self.showSearchResults = true;
                        $.ajax({
                        url: self.baseURL + ""search/tv?""+ self.apiKEY +""&language=en-US&query="" + self.searchTerm + ""&page=1"",
                        dataType: 'json',
                        contentType: 'application/json',
             ");
                WriteLiteral(@"           method: 'GET',
                        success: function (data) {
                            self.searchResults = data.results.sort(function(a,b){
                                return b.popularity - a.popularity;
                            }).slice(0,5);
                        },
                        error: function (error) {
                            console.log(error);
                            alert(""Oh no! We couldn't find your shows. D:"");
                        }
                        });
                    }
                    else{
                        self.showSearchResults = false;
                    }
                },
                emptySearch: function(){
                    var self = this;
                    self.searchResults = '';
                    self.searchTerm = '';
                    self.showSearchResults = false;
                },
                saveShow: function(){

                }
            }     
        });
</");
                WriteLiteral("script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
