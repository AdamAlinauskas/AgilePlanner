using NUnit.Framework;

namespace Infrastructure.Testing
{
    [TestFixture]
    public abstract class ContextSpec<T>
    {
        protected T sut;
        public abstract T CreateSut();
        public abstract void UnderTheseConditions();
        public abstract void BecauseOf();

        [SetUp]
        public void SetUp()
        {
            sut = CreateSut();
            UnderTheseConditions();
            BecauseOf();
        }
    }
}