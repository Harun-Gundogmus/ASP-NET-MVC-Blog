#pragma checksum "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e280aab2c8f255573e9a32b1d2299d78706efd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genel_Writer), @"mvc.1.0.view", @"/Views/Genel/Writer.cshtml")]
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
#line 1 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\_ViewImports.cshtml"
using ReaAkademiProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\_ViewImports.cshtml"
using ReaAkademiProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e280aab2c8f255573e9a32b1d2299d78706efd2", @"/Views/Genel/Writer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a17d00518edfaf4ebd65254f2e508e6412e7f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Genel_Writer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""container"">
        <div class=""row justify-content-center"">
        <h2>SİTEMİZDEKİ BLOG YAZARLARININ KAYITLARI</h2>
        <div class=""table-responsive"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Yazarın Kodu</th>
                        <th>Yazarın İsmi</th>
                        <th>Yazarın Soyismi</th>
                        <th>Yazarın Alanı</th>
                        <th>Yazarın Maaşı</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 20 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                                       Write(item.teammate_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                           Write(item.teammate_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                           Write(item.teammate_Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                           Write(item.teammate_Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                           Write(item.teammate_Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\HUAWEI\source\repos\ReaAkademiProje\ReaAkademiProje\Views\Genel\Writer.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n           \r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n<div class=\"btn-group-vertical\">\r\n    ...\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
