using POC_SignalR_Realtime_Notification.DTOs.Auth;

namespace POC_SignalR_Realtime_Notification.Services.Auth
{
    public interface ILoginDetailServices
    {
        string Token { get; }

        string[] Roles { get; }

        string[] Permissions { get; }

        LoginDetailDto GetClaim();

        bool CheckPermission(string permission);

        bool CheckRole(string role);
    }
}