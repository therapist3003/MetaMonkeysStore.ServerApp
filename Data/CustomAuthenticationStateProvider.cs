using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;

        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                //await Task.Delay(5000);
                var employeeSessionStorageResult = await _sessionStorage.GetAsync<EmployeeSession>("EmployeeSession");
                var employeeSession = employeeSessionStorageResult.Success ? employeeSessionStorageResult.Value : null;

                if (employeeSession == null)
                {
                    return await Task.FromResult(new AuthenticationState(_anonymous));
                }

                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, employeeSession.UserName),
                    new Claim(ClaimTypes.Role, employeeSession.Role)
                }, "CustomAuth"));

                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }

            catch
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }

        public async Task UpdateAuthenticationState(EmployeeSession employeeSession)
        {
            ClaimsPrincipal claimsPrincipal;

            if (employeeSession != null)
            {
                await _sessionStorage.SetAsync("EmployeeSession", employeeSession);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, employeeSession.UserName),
                    new Claim(ClaimTypes.Role, employeeSession.Role)
                }));
            }
            else
            {
                await _sessionStorage.DeleteAsync("EmployeeSession");
                claimsPrincipal = _anonymous;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
