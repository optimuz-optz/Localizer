﻿using FluentAssertions;
using Localizer.Plugins;
using NUnit.Framework;

namespace Localizer.Tests.Plugins;

[TestFixture]
public class DefaultLanguageDetectorFixture
{
    [Test]
    public void GetLanguage_ShouldReturnProvidedLanguage()
    {
        var detector = new DefaultLanguageDetector("de-DE");
        detector.GetLanguage().Should().Be("de-DE");

        detector = new DefaultLanguageDetector("en-US");
        detector.GetLanguage().Should().Be("en-US");

        detector = new DefaultLanguageDetector("fr");
        detector.GetLanguage().Should().Be("fr");
    }
}