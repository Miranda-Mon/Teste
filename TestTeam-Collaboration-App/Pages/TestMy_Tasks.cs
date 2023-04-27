using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Team_Collaboration_App.Pages;

namespace TestTeam_Collaboration_App
{
	public class TestMy_Tasks
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
				typeof(IgbIconButtonModule),
				typeof(IgbCalendarModule));
			var componentUnderTest = ctx.RenderComponent<My_Tasks>();
			Assert.NotNull(componentUnderTest);
		}
	}
}