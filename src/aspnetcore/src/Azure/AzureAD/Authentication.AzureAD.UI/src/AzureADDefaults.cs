// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.AspNetCore.Authentication.AzureAD.UI
{
    /// <summary>
    /// Constants for different Azure Active Directory authentication components.
    /// </summary>
    [Obsolete("This is obsolete and will be removed in a future version. Use Microsoft.Identity.Web instead. See https://aka.ms/ms-identity-web.")]
    public static class AzureADDefaults
    {
        /// <summary>
        /// The scheme name for Open ID Connect when using
        /// <see cref="AzureADAuthenticationBuilderExtensions.AddAzureAD(AuthenticationBuilder, System.Action{AzureADOptions})"/>.
        /// </summary>
        public const string OpenIdScheme = "AzureADOpenID";

        /// <summary>
        /// The scheme name for cookies when using
        /// <see cref="AzureADAuthenticationBuilderExtensions.AddAzureAD(AuthenticationBuilder, System.Action{AzureADOptions})"/>.
        /// </summary>
        public const string CookieScheme = "AzureADCookie";

        /// <summary>
        /// The default scheme for Azure Active Directory Bearer.
        /// </summary>
        public const string BearerAuthenticationScheme = "AzureADBearer";

        /// <summary>
        /// The scheme name for JWT Bearer when using
        /// <see cref="AzureADAuthenticationBuilderExtensions.AddAzureADBearer(AuthenticationBuilder, System.Action{AzureADOptions})"/>.
        /// </summary>
        public const string JwtBearerAuthenticationScheme = "AzureADJwtBearer";

        /// <summary>
        /// The default scheme for Azure Active Directory.
        /// </summary>
        public const string AuthenticationScheme = "AzureAD";

        /// <summary>
        /// The display name for Azure Active Directory.
        /// </summary>
        public static readonly string DisplayName = "Azure Active Directory";
    }
}
