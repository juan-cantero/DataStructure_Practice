using Datastructure_Practice;
using NUnit.Framework;

namespace DataStructure_Practice_Tests
{
    [TestFixture]
    public class Array_test
    {
        Array<int> _array;
        [SetUp]
        public void Setup()
        {
            _array = new Array<int>();
        }

        [Test]
        public void Add_WhenCalled_AddElementIntoArray()
        {
            _array.Add(1);
            int expected = _array.GetElementAt(0);
            Assert.That(expected,Is.EqualTo(1));
        }

        [Test]
        public void RemoveAt_WhenCalled_REmoveElementAtPosition()
        {
            _array.Add(1);
            _array.Add(2);
            _array.Add(3);

            _array.RemoveAt(1);

            var expected = _array.GetItems();

            Assert.That(expected, Is.EquivalentTo(new[] { 1, 3 }));

        }
    }
}