#pragma checksum "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbe59c9bb3561289d9580bd3066d8bcbba5caeec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Addresses_Delete), @"mvc.1.0.view", @"/Views/Addresses/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe59c9bb3561289d9580bd3066d8bcbba5caeec", @"/Views/Addresses/Delete.cshtml")]
    public class Views_Addresses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheKingdomSystem.Management.Domain.Entities.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Address</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\BACKUP\Ricky\Documents\TheKingdomSystem\TheKingdomSystem.Management\Api\TheKingdomSystem.Management.Api\Views\Addresses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheKingdomSystem.Management.Domain.Entities.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
