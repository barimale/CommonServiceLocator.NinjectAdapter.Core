using CommonServiceLocator.NinjectAdapter.Extension;
using Ninject;
using NUnit.Framework;

namespace UT.CQRSlite.Ninject.Binding.NET30
{
    public class When_nuget_is_in_use
    {
        [Test]
        public void I_d_like_to_have_bindings_loaded_correctly()
        {
            //given
            StandardKernel kernel = new StandardKernel();

            //when
            NinjectServiceLocator locator = new NinjectServiceLocator(kernel);

            //then
            Assert.IsNotNull(locator);
        }
    }
}
