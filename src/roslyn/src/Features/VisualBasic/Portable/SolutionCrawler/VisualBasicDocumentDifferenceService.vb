' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.Host.Mef
Imports Microsoft.CodeAnalysis.SolutionCrawler

Namespace Microsoft.CodeAnalysis.VisualBasic.SolutionCrawler
    <ExportLanguageService(GetType(IDocumentDifferenceService), LanguageNames.VisualBasic), [Shared]>
    Friend Class VisualBasicDocumentDifferenceService
        Inherits AbstractDocumentDifferenceService

        <ImportingConstructor>
        <Obsolete(MefConstruction.ImportingConstructorMessage, True)>
        Public Sub New()
        End Sub
    End Class
End Namespace
