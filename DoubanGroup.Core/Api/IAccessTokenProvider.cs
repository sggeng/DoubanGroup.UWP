﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanGroup.Core.Api
{
    public interface IAccessTokenProvider
    {
        string AccessToken { get; }
    }
}
