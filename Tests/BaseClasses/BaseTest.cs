using FrameWork;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.BaseClasses
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
        }

        [TearDown]
        public virtual void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.FullName);
            }
            Driver.CloseDriver();
        }
    }
}
