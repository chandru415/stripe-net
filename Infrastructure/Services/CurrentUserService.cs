﻿using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class CurrentUserService : ICurrentUserService
    {
        public string UserId => string.Empty;
    }
}
