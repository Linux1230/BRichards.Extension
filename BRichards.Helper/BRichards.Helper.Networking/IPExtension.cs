using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;

namespace BRichards.Helper.Networking;

public class IPExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static IPHostEntry GetLocalHostEntry() =>
        Dns.GetHostEntry(Dns.GetHostName());

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static string GetLocalIPv4Address()
    {
        foreach (var ip in GetLocalHostEntry().AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static string GetLocalIPv6Address()
    {
        foreach (var ip in GetLocalHostEntry().AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetworkV6)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static bool GetIsNetworkAvailable() =>
        NetworkInterface.GetIsNetworkAvailable();
}
