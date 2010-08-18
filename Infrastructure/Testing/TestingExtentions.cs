using NUnit.Framework;

namespace Infrastructure.Testing
{
    public static class TestingExtentions
    {

        public static void ShouldBeEqualTo<T>(this T subject, T item)
        {
            Assert.AreEqual(subject,item);
        }

    }
}
