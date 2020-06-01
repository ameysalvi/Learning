using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public class CustomStepTransformer
    {
        [StepArgumentTransformation(@"(\d+) days from current date")]
        public DateTime DayAdderTranformer(int days)
        {
            return DateTime.Today.AddDays(days);
        }
    }
}
