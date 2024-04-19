using Core;

namespace InvocationTests
{
    public class Tests
    {
        private HS256 encoder;

        [SetUp]
        public void Setup()
        {
            this.encoder = new HS256(Path.Combine("../../../../", "testSecret.json"));
        }

        [Test]
        public void Execute()
        {
            encoder.Encode(null, null);
            
            Assert.Pass();
        }
    }
}