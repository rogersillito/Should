using System;
using System.Collections.Generic;
using Should.Core.Exceptions;
using Xunit;
using Assert = Should.Core.Assertions.Assert;

namespace Should.Facts.Core
{
    public class EqualsSequenceTests
    {
        [Fact]
        public void SequencesAreEqual()
        {
            var list = new List<int> { 1,2,3 };
            Assert.SequencesAreEqual(list, new[] { 1,2,3 });
        }

        [Fact]
        public void SequencesAreNotEqual()
        {
            var list = new List<int>();

            var ex = Assert.Throws<SequencesAreEqualException>(() => Assert.SequencesAreEqual(new int[] {}, list));

            //TODO: the message should be useful!
            //Assert.Equal("Assert.SequencesAreEqual() failure: sequences are not equal: ", ex.Message);
        }
    }
}