using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace xUnitTutorialYoutube
{
    [CollectionDefinition("Guid Generator")]
    public class GuidGeneratorDefinition : ICollectionFixture<GuidGenerator>
    {

    }

    [Collection("Guid Generator")]
    public class GuidGeneratorTestsOne //: IClassFixture<GuidGenerator>, IDisposable
    {
        private readonly GuidGenerator _guidgenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsOne(ITestOutputHelper output, GuidGenerator guidgenerator)
        {
            _output = output;
            _guidgenerator = guidgenerator;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidgenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidgenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        public void Dispose()
        {
            _output.WriteLine("The class was disposed");
        }

    }

    [Collection("Guid Generator")]
    public class GuidGeneratorTestsTwo //: IClassFixture<GuidGenerator>, IDisposable
    {
        private readonly GuidGenerator _guidgenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsTwo(ITestOutputHelper output, GuidGenerator guidgenerator)
        {
            _output = output;
            _guidgenerator = guidgenerator;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidgenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidgenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        public void Dispose()
        {
            _output.WriteLine("The class was disposed");
        }

    }
}
