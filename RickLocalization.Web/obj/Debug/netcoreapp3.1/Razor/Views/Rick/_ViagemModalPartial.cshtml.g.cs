#pragma checksum "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\Rick\_ViagemModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de3cd6bdb07b15879c9e3d0b68f0d99b14f3b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rick__ViagemModalPartial), @"mvc.1.0.view", @"/Views/Rick/_ViagemModalPartial.cshtml")]
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
#line 1 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\_ViewImports.cshtml"
using RickLocalization.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\_ViewImports.cshtml"
using RickLocalization.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de3cd6bdb07b15879c9e3d0b68f0d99b14f3b5d", @"/Views/Rick/_ViagemModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab8129a5667680ff9ddce645a94219aa02148e70", @"/Views/_ViewImports.cshtml")]
    public class Views_Rick__ViagemModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RickLocalization.Web.Models.TripViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\Rick\_ViagemModalPartial.cshtml"
 using (Html.BeginForm("ProcessarDados", "Rick", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal fade js-modal-cadastrar-viagem"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                ");
#nullable restore
#line 8 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\Rick\_ViagemModalPartial.cshtml"
           Write(Html.HiddenFor(model => model.IdRick));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 9 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\Rick\_ViagemModalPartial.cshtml"
           Write(Html.HiddenFor(model => model.IdDimensao));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Cadastrar Viagem</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div>
                        ");
#nullable restore
#line 18 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\Rick\_ViagemModalPartial.cshtml"
                   Write(Html.TextBoxFor(c => c.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Cadastrar</button>
                    <button type=""button"" class=""btn btn-secondary js-modal-cancelar"" data-dismiss=""modal"">Fechar</button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 28 "C:\Users\Gabriela Pinheiro\Documents\Gabriela\RickLocalization\RickLocalization.Web\Views\Rick\_ViagemModalPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RickLocalization.Web.Models.TripViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
