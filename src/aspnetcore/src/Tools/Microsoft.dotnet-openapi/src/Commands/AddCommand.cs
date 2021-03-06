// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using Microsoft.DotNet.Openapi.Tools;

namespace Microsoft.DotNet.OpenApi.Commands
{
    internal class AddCommand : BaseCommand
    {
        private const string CommandName = "add";

        public AddCommand(Application parent, IHttpClientWrapper httpClient)
            : base(parent, CommandName, httpClient)
        {
            Commands.Add(new AddFileCommand(this, httpClient));
            //TODO: Add AddprojectComand here: https://github.com/dotnet/aspnetcore/issues/12738
            Commands.Add(new AddURLCommand(this, httpClient));
        }

        internal new Application Parent => (Application)base.Parent;

        protected override Task<int> ExecuteCoreAsync()
        {
            ShowHelp();
            return Task.FromResult(0);
        }

        protected override bool ValidateArguments()
        {
            return true;
        }
    }
}
