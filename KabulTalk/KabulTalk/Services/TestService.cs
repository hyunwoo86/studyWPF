﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabulTalk.Services
{
    public class TestService : ITestService
    {
        public string GetString()
        {
            return "까불톡 입니다.";
        }
    }
}
