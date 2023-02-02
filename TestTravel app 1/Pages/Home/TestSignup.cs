using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.Home;

namespace TestTravel_app_1
{
	public class TestSignup
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbCheckboxModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Signup>();
			Assert.NotNull(componentUnderTest);
		}
	}
}