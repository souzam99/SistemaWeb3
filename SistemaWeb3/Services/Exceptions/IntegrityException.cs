﻿using System;

namespace SistemaWeb3.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
