﻿using System;
using Elision.Foundation.FieldTokens.Pipelines.ReplaceFieldValueTokens;
using FluentAssertions;
using NUnit.Framework;

namespace Elision.Foundation.FieldTokens.Tests
{
    [TestFixture]
    public class ReplaceSystemTokensTests
    {
        [Test]
        public void ReplacesNowValue()
        {
            var processor = new ReplaceSystemTokens();
            var args = new ReplaceFieldValueTokensArgs("{Now:yyyy-MM-dd}", null);
            processor.Process(args);
            args.FieldValue.Should().Be(DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
