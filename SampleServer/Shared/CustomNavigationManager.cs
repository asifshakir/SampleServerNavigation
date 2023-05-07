using Microsoft.AspNetCore.Components;

namespace SampleServer.Shared;

public class CustomNavigationManager : NavigationManager
{
    protected override void NavigateToCore(string uri, bool forceLoad)
    {
        var options = new NavigationOptions {
            ForceLoad = forceLoad,
            ReplaceHistoryEntry = false
        };
        base.NavigateToCore(uri, options);
    }
}
