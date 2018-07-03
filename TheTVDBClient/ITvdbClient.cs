using System.Threading.Tasks;
using TheTVDBClient.Models;

namespace TheTVDBClient
{
    public interface ITvdbClient
    {
        Task<Episode> GetEpisodeAsync(int id);
        Task RefreshTokenAsync(string apiKey, string userKey, string username);
        Task RefreshTokenAsync(string apiKey);
    }
}
