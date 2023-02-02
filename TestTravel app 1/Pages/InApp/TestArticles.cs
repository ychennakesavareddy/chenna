using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app_1.Pages.InApp;
using Travel_app_1.TravelApp;

namespace TestTravel_app_1
{
	public class TestArticles
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new TravelAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Articles>();
			Assert.NotNull(componentUnderTest);
		}
	}
}