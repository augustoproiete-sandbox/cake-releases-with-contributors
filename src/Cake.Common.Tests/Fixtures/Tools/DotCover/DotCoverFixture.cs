// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Testing.Fixtures;

namespace Cake.Common.Tests.Fixtures.Tools.DotCover
{
    internal abstract class DotCoverFixture<TSettings> : DotCoverFixture<TSettings, ToolFixtureResult>
    where TSettings : ToolSettings, new()
    {
        protected override ToolFixtureResult CreateResult(FilePath path, ProcessSettings process)
        {
            return new ToolFixtureResult(path, process);
        }
    }

    internal abstract class DotCoverFixture<TSettings, TFixtureResult> : ToolFixture<TSettings, TFixtureResult>
        where TSettings : ToolSettings, new()
        where TFixtureResult : ToolFixtureResult
    {
        protected DotCoverFixture()
            : base("dotCover.exe")
        {
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
    }
}