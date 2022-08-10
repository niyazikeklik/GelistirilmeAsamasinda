using BinanceBot.Models;
using Microsoft.EntityFrameworkCore;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceBot.Jobs
{
    public class StrategieControl : IJob
    {
        Strategie strategie;
        public StrategieControl() {
            strategie = new();
        }
        public Task Execute(IJobExecutionContext context)
        {
            Debug.WriteLine("Strateji kontrol ediliyor.");
            if (strategie.BuySignal("GTOUSDT"))
                Trader.BuyTrainer("GTOUSDT", 0.02m);
            if (strategie.SellSignal("GTOUSDT"))
                Trader.SellTrainer("GTOUSDT", 1, 1, 1, 1);
            return Task.CompletedTask;
        }

    }
}
