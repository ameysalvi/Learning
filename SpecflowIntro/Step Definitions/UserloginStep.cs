using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro.Step_Definitions
{
    [Binding]
    public sealed class UserloginStep
    {
        [Given(@"I login to application as admin")]
        [Scope(Feature = "User_Login")]
        public void GivenILoginToApplication()
        {
            
        }
    }
}
