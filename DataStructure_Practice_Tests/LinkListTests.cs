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
    }
}