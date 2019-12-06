using System;
using AutoFrame.Core.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using AutoFrame.Services.Services.StopWatchService;
using MatchScratchPageComponent.Pages;

namespace MatchScratchBackOffice
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {
        [TestMethod]
        public void CreateRound()
        {
            Logger.Info("\nEnter TestTimer() method. ");
            IStopWatchService stopWatchService = Container.Resolve<IStopWatchService>();
            stopWatchService.StartTimer();
            MatchScratchLoginPage matchScatchLoginPage = NavigateTo<MatchScratchLoginPage>(ServerURL);
            var duration = stopWatchService.StopTimer();
            Console.WriteLine("Duration=" + duration);
            Logger.Info("\nExit TestTimer() method. ");
        }
    }
    
}
