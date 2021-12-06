using System;
using System.Collections.Generic;
using System.Text;

namespace VisualBusinessCards.Shared.CustomException
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException(string message) : base(message)
        {
            //log id
        }
    }
}
