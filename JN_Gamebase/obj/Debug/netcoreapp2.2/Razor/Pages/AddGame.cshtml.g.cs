#pragma checksum "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\AddGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea33bd6710531c05764c620a2d87eb0e26d6441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JN_Gamebase.Pages.Pages_AddGame), @"mvc.1.0.razor-page", @"/Pages/AddGame.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AddGame.cshtml", typeof(JN_Gamebase.Pages.Pages_AddGame), null)]
namespace JN_Gamebase.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\_ViewImports.cshtml"
using JN_Gamebase;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea33bd6710531c05764c620a2d87eb0e26d6441", @"/Pages/AddGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20665d6f1079d4dc682f76600e83db16e2735684", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddGame : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\AddGame.cshtml"
  
    ViewData["Title"] = "AddGame";

#line default
#line hidden
            BeginContext(89, 1722, true);
            WriteLiteral(@"
<script src=""https://cdn.tiny.cloud/1/0ov0gut0a32tpk6b1r3xrgggfz3t4h1ygkots7rslvc3r1m3/tinymce/5/tinymce.min.js"" referrerpolicy=""origin""></script>

<h1>Add Game</h1>

<div class=""add-form"">
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Title"" />
    </div>
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Developer"" />
    </div>
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Genre"" />
    </div>
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Rating (E/E+/T/M)"" />
    </div>
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Series"" />
    </div>
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Price"" />
    </div>
    <div class=""add-inner"">
        <input type=""text"" placeholder=""Release Date"" />
    </div>

    

    <div class=""add-tiny"">
        <textarea>
            About the game
        </textarea>
        <script>
            tinymce.init({
      ");
            WriteLiteral(@"          selector: 'textarea',
                plugins: 'a11ychecker advcode casechange formatpainter linkchecker autolink lists checklist media mediaembed pageembed permanentpen powerpaste table advtable tinycomments tinymcespellchecker',
                toolbar: 'a11ycheck addcomment showcomments casechange checklist code formatpainter pageembed permanentpen table',
                toolbar_mode: 'floating',
                tinycomments_mode: 'embedded',
                tinycomments_author: 'Author name',
            });
        </script>
    </div>

    <div class=""add-inner"">
        <button type=""submit"" class=""button-add-game"">Add</button>
    </div>
</div>



  

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JN_Gamebase.Pages.AddGameModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JN_Gamebase.Pages.AddGameModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JN_Gamebase.Pages.AddGameModel>)PageContext?.ViewData;
        public JN_Gamebase.Pages.AddGameModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591