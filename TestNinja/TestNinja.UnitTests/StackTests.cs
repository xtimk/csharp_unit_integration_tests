using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack; 

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Push_CallWithNonNullObj_UpdateState()
        {
            var count = _stack.Count;
            _stack.Push("1");

            Assert.That(_stack.Count, Is.EqualTo(count + 1));
        }

        [Test]
        public void Push_CallNullObj_RaiseArgumentNullException()
        {
            Assert.That(() => { _stack.Push(null); }, Throws.ArgumentNullException);
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_NonEmptyStack_ReturnTopElementOfStack()
        {
            // Arrange
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            var result = _stack.Pop();

            // Assert
            Assert.That(result, Is.EqualTo("3"));
        }

        [Test]
        public void Pop_NonEmptyStack_RemoveElementFromStack()
        {
            // Arrange
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            var result = _stack.Pop();

            // Assert
            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnTopElementOfStack()
        {
            // Arrange
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("3"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTopElementOfStack()
        {
            // Arrange
            _stack.Push("1");
            _stack.Push("2");
            _stack.Push("3");

            _ = _stack.Peek();

            // Assert
            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}
