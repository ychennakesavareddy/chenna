using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Shared;

namespace TestTravel_app_1
{
	public class TestInApp
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbNavDrawerModule));
			var componentUnderTest = ctx.RenderComponent<InApp>();
			Assert.NotNull(componentUnderTest);
		}
	}
}