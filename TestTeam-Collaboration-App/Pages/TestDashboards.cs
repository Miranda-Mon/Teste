using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Team_Collaboration_App.Pages;

namespace TestTeam_Collaboration_App
{
	public class TestDashboards
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbListModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule));
			var componentUnderTest = ctx.RenderComponent<Dashboards>();
			Assert.NotNull(componentUnderTest);
		}
	}
}