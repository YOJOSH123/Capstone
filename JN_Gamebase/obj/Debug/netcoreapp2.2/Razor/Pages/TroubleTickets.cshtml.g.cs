#pragma checksum "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\TroubleTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f0ab73990e4d5053606483ee7dabea77221f8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JN_Gamebase.Pages.Pages_TroubleTickets), @"mvc.1.0.razor-page", @"/Pages/TroubleTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TroubleTickets.cshtml", typeof(JN_Gamebase.Pages.Pages_TroubleTickets), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f0ab73990e4d5053606483ee7dabea77221f8e", @"/Pages/TroubleTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20665d6f1079d4dc682f76600e83db16e2735684", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TroubleTickets : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Nick\Documents\capstone\Capstone\JN_Gamebase\JN_Gamebase\Pages\TroubleTickets.cshtml"
  
    ViewData["Title"] = "TroubleTickets";

#line default
#line hidden
            BeginContext(103, 1138, true);
            WriteLiteral(@"
<div>
    <h2>Support Ticket</h2>
    
    <div class=""ticket-form"">
        <div class=""ticket-inner"">
            <input type=""text"" placeholder=""Your Name"" />
        </div>
        <div class=""ticket-inner"">
            <input type=""text"" placeholder=""Game Title"" />
        </div>
        <div class=""ticket-inner"">
            <input type=""text"" placeholder=""Email"" />
        </div>
        <div class=""ticket-inner"">
            <input type=""text"" placeholder=""Subject"" />
        </div>
        <div class=""ticket-inner"">
            <input type=""text"" placeholder=""Description"" />
        </div>

        <div class=""ticket-inner"">
            <button type=""submit"" class=""submit-ticket-button"">Submit Ticket</button>
        </div>
    </div>



    <h2>Past User tickets</h2>

    <table class=""top-table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Title</th>
                <th>Email</th>
              ");
            WriteLiteral("  <th>Subject</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JN_Gamebase.Pages.TroubleTicketsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JN_Gamebase.Pages.TroubleTicketsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JN_Gamebase.Pages.TroubleTicketsModel>)PageContext?.ViewData;
        public JN_Gamebase.Pages.TroubleTicketsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591