using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Calling before Feature");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Calling before Scenarios");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Calling after Scenarios");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Calling after Feature");
        }

    }
}
