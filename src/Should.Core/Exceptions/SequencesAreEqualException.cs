using System;

namespace Should.Core.Exceptions
{
    public class SequencesAreEqualException: AssertActualExpectedException
    {
        public SequencesAreEqualException(object expected, object actual, string userMessage) : base(expected, actual, userMessage)
        {
            throw new NotImplementedException();
        }

        public SequencesAreEqualException(object expected, object actual, string userMessage, bool skipPositionCheck) : base(expected, actual, userMessage, skipPositionCheck)
        {
            throw new NotImplementedException();
        }
    }
}