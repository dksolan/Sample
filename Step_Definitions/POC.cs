using System;
using System.Collections.Generic;
using System.Text;
using Specflow;

namespace WTW.Step_Definitions
{
    class POC 
    {

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
