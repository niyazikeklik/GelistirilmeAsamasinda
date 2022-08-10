using Quartz.Impl;
using Quartz;
using System;using BinanceBot.Jobs;

namespace BinanceBot.Scheulders
{
    public class Scheulder
    {
        public static async void SchedulerSetup()
        {
            var _scheduler = await new StdSchedulerFactory().GetScheduler();
            await _scheduler.Start();

            var showDateTimeJob = JobBuilder.Create<StrategieControl>()
                .WithIdentity("StrategieControl")
                .Build();
            var trigger = TriggerBuilder.Create()
                .WithIdentity("StrategieControl")
                .StartNow()
                .WithSimpleSchedule(builder => 
                builder.WithIntervalInSeconds(15).RepeatForever()).Build();
            //.WithCronSchedule("*/1 * * * *")


            var result = await _scheduler.ScheduleJob(showDateTimeJob, trigger);
        }
    }
}
