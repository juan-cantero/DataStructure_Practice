using NUnit.Framework;
using Datastructure_Practice;

namespace Datastructure_Practice
{   
    
    public class LinkListTests
    {
        LinkList<int> _list;
        
        
        [SetUp]
        public void Setup()
        {
            _list = new LinkList<int>();
            _list.AddFirst(0);
        }

        [Test]
        public void AddFirst_ShouldAddElement_First()
        {
            _list.AddFirst(1);
            var expectedList = _list.GetList();

            Assert.That(expectedList, Is.EquivalentTo(new[] { 1,0 }));
        }

        [Test]

        public void AddLast_ShouldAddElement_Last()
        {
            _list.AddLast(1);
            var expectedList = _list.GetList();
            Assert.That(expectedList, Is.EquivalentTo(new[] { 0, 1 }));
        }

        [Test]
        public void IndexOf_ShouldReturnIndex_OfElementPassed()
        {
            int expectedIndex = _list.IndexOf(0);

            Assert.That(expectedIndex, Is.EqualTo(0));
        }

        [Test]

        public void Contains_ShouldReturnABoolean_TrueIfElementIsPresent()
        {
            _list.AddLast(2);

            var contains = _list.Contains(2);

            Assert.IsTrue(contains);
        }

        [Test]
        public void RemoveFirst_ShouldRemoveThe_FirstElement()
        {
            _list.AddFirst(5);
            _list.RemoveFirst();

            var expected = _list.Head.Element;

            Assert.AreEqual(expected, 0);
        }

        [Test]

        public void RemoveLast_ShouldRemoveThe_LastElement()
        {
            //_list.AddLast(8);
            _list.RemoveLast();



            Assert.IsNull(_list.Tail);
        }

        [Test]
        public void Size_ShouldReturnAnInt_WithTheSizeOfTheList()
        {
            _list.AddFirst(2);
            _list.AddLast(3);
            _list.RemoveFirst();

            var listSize = _list.Size;
            Assert.AreEqual(listSize, 2);
        }

        [Test]
        public void Reverse_ShouldReverse_TheList()
        {
            _list.AddLast(1);
            _list.AddLast(2);
            _list.AddLast(3);
            _list.ReverseList();
            var reversedList = _list.GetList();

            Assert.AreEqual(reversedList, new[] { 3, 2, 1, 0 });
        }

        [Test]
        public void GetKthFromTheEnd_ReturnsElementKPositions_FromTheEndElement()
        {
            _list.AddLast(1);
            _list.AddLast(2);
            _list.AddLast(3);
            _list.AddLast(4);

            var expectedElement = _list.GetKthFromTheEnd(3);

            Assert.AreEqual(expectedElement, 1);
        }


    }
}