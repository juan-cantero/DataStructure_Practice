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
            _array.Add(1);
            _array.Add(2);
            _array.Add(3);
        }

        [Test]
        public void Add_WhenCalled_AddElementIntoArray()
        {
            int expected = _array.GetElementAt(0);
            Assert.That(expected,Is.EqualTo(1));
        }

        [Test]
        public void RemoveAt_WhenCalled_RemoveElementAtPosition()
        {

            _array.RemoveAt(1);

            var expected = _array.GetItems();

            Assert.That(expected, Is.EquivalentTo(new[] { 1, 3 }));

        }

        [Test]
        public void IndexOF_WhenCalled_ReturnTheIndexOfTheElementPassed()
        {
            var indexOfElement = _array.IndexOf(2);
            Assert.That(indexOfElement, Is.EqualTo(1));


        }

        [Test]
        public void InsertAt_WhenCalled_InsertElementInGivenPosition()
        {
            _array.InsertAt(3,5);


            Assert.That(_array.GetItems(), Is.EquivalentTo(new[] { 1, 2, 3, 5 }));
        }
    }
}