﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enums
{
    public enum ResponseState
    {
        Success = 100,
        Error = 101,
        ValidationError = 102,
        NotFound = 103,
        AccessDenied = 104,
        AuthenticationError = 105,
        ProcessError = 106,
        InvalidInput = 107,
    }
}
