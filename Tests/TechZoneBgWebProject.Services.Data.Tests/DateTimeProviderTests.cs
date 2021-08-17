namespace TechZoneBgWebProject.Services.Data.Tests
{
    using System;

    using FluentAssertions;

    using TechZoneBgWebProject.Services.Providers;
    using Xunit;

    public class DateTimeProviderTests
    {
        [Fact]
        public void NowMethodShouldReturnCurrentTime()
        {
            var dateTimeProvider = new DateTimeProvider();

            var time = dateTimeProvider.Now();

            time.Should().BeSameDateAs(DateTime.Now);
        }
    }
}
