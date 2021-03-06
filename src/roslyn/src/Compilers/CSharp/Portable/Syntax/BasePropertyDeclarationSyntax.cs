// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class BasePropertyDeclarationSyntax
    {
        public abstract override SyntaxList<AttributeListSyntax> AttributeLists { get; }
        public abstract override SyntaxTokenList Modifiers { get; }
    }
}
