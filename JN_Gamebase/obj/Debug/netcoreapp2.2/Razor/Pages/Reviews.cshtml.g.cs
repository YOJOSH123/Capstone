#pragma checksum "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9057febe72e8ca6f06d0a784e72aa0c6235cf9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JN_Gamebase.Pages.Pages_Reviews), @"mvc.1.0.razor-page", @"/Pages/Reviews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Reviews.cshtml", typeof(JN_Gamebase.Pages.Pages_Reviews), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9057febe72e8ca6f06d0a784e72aa0c6235cf9a", @"/Pages/Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20665d6f1079d4dc682f76600e83db16e2735684", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reviews : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\Reviews.cshtml"
  
    ViewData["Title"] = "Reviews";

#line default
#line hidden
            BeginContext(89, 848, true);
            WriteLiteral(@"
<h2>Reviews</h2>

<div class=""review-tiny"">
    <textarea>
        Write a review
    </textarea>
    <script>
            tinymce.init({
                selector: 'textarea',
                plugins: 'a11ychecker advcode casechange formatpainter linkchecker autolink lists checklist media mediaembed pageembed permanentpen powerpaste table advtable tinycomments tinymcespellchecker',
                toolbar: 'a11ycheck addcomment showcomments casechange checklist code formatpainter pageembed permanentpen table',
                toolbar_mode: 'floating',
                tinycomments_mode: 'embedded',
                tinycomments_author: 'Author name',
            });
    </script>
</div>

<input type=""text"" class=""rating"" placeholder=""Rating 1-10""/>

<button type=""submit"" class=""button-review"">Post Review</button>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JN_Gamebase.Pages.ReviewsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JN_Gamebase.Pages.ReviewsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JN_Gamebase.Pages.ReviewsModel>)PageContext?.ViewData;
        public JN_Gamebase.Pages.ReviewsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
