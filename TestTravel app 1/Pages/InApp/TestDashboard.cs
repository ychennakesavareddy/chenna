using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.InApp;
using Travel_app_1.TravelApp;
using Travel_app_1.Northwind;

namespace TestTravel_app_1
{
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbGridModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new TravelAppService(mockHttpClient));
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}