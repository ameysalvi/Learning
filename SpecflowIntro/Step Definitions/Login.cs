using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowIntro.Step_Definitions
{
    [Binding]
    public sealed class Login
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            
        }

        [Given(@"I login to application")]
        [Scope(Feature = "Customer_login")]
        public void GivenILoginToApplication() 
        {
            
        }

        [Then(@"I see customer protal")]
        public void ThenISeeCustomerProtal()
        {
            
        }

        [Then(@"I see last date logged in data is (.* days from current date)")]
        public void ThenISeeLastDateLoggedInDataIsDaysFromCurrentDate(DateTime correctDateTime)
        {
            Console.WriteLine(correctDateTime);
        }

        [Then(@"I see the menus like")]
        public void ThenISeeTheMenusLike(Table menus)
        {
            IEnumerable<dynamic> menuList = menus.CreateDynamicSet();
            var menu = menuList.FirstOrDefault();

            string menu1 = menu.Menu_1;
            string menu2 = menu.Menu_2;
            //string menu3 = menu.Menu_3;
            //string menu4 = menu.Menu_4;

            Console.WriteLine("The value of Menu1 is {0} and Menu2 is {1}", menu1, menu2 );
        }

    }
}
