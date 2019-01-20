﻿using System;

namespace CheckerApi.Services.Conditions
{
    [GlobalCondition(4)]
    public class CriticalTotalMarketCondition : TotalMarketCondition
    {
        public CriticalTotalMarketCondition(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            TotalHashThreshold = 1;
            MessagePrefix = "Critical ";
        }
    }
}