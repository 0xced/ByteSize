using System.Globalization;
using FluentAssertions;
using Xunit;

namespace ByteSizeLib.Tests.Decimal
{
    public class ParsingMethods
    {
        [Fact]
        public void ParseKb()
        {
            var result = ByteSize.Parse("1020Kb");

            result.Should().Be(ByteSize.FromKiloBits(1020));
        }

        [Fact]
        public void ParseKB()
        {
            var result = ByteSize.Parse("1020KB");

            result.Should().Be(ByteSize.FromKiloBytes(1020));
        }

        [Fact]
        public void ParseMb()
        {
            var result = ByteSize.Parse("1000Mb");

            result.Should().Be(ByteSize.FromMegaBits(1000));
        }

        [Fact]
        public void ParseMB()
        {
            var result = ByteSize.Parse("1000MB");

            result.Should().Be(ByteSize.FromMegaBytes(1000));
        }

        [Fact]
        public void ParseGb()
        {
            var result = ByteSize.Parse("805Gb");

            result.Should().Be(ByteSize.FromGigaBits(805));
        }

        [Fact]
        public void ParseGB()
        {
            var result = ByteSize.Parse("805GB");

            result.Should().Be(ByteSize.FromGigaBytes(805));
        }

        [Fact]
        public void ParseTb()
        {
            var result = ByteSize.Parse("100Tb");

            result.Should().Be(ByteSize.FromTeraBits(100));
        }

        [Fact]
        public void ParseTB()
        {
            var result = ByteSize.Parse("100TB");

            result.Should().Be(ByteSize.FromTeraBytes(100));
        }

        [Fact]
        public void ParsePb()
        {
            var result = ByteSize.Parse("100Pb");

            result.Should().Be(ByteSize.FromPetaBits(100));
        }

        [Fact]
        public void ParsePB()
        {
            var result = ByteSize.Parse("100PB");

            result.Should().Be(ByteSize.FromPetaBytes(100));
        }

        [Fact]
        public void ParseCultureNumberSeparator()
        {
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");

            var result = ByteSize.Parse("1.500,5 MB");

            result.Should().Be(ByteSize.FromMegaBytes(1500.5));
            
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }
    }
}
