using System;
using System.Collections.Generic;
using System.Text;

namespace VisualBusinessCards.Shared.CustomException
{
    public class NoteException : Exception
    {
        public NoteException(string message) : base(message)
        {

        }
    }
}
