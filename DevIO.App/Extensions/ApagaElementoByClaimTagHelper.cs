﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace DevIO.App.Extensions
{
    [HtmlTargetElement("*", Attributes = "supress-by-claim-name")]
    [HtmlTargetElement("*", Attributes = "supress-by-claim-value")]
    public class ApagaElementoByClaimTagHelper : TagHelper
    {
        [HtmlAttributeName("supress-by-claim-name")]

        public string IdentityClaimName { get; set; }

        [HtmlAttributeName("supress-by-claim-value")]

        public string IdentityClaimValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
                throw new ArgumentNullException(paramName: nameof(context));
            if (output == null)
                throw new ArgumentNullException(paramName: nameof(output));

            var temAcesso = CustomAuthorization.ValidarClaimsUsuario(context: null, IdentityClaimName, IdentityClaimValue);

            if (temAcesso) return;

            output.SuppressOutput();
        }
    }
}
