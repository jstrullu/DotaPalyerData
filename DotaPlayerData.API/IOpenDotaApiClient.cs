namespace DotaPlayerData.API;

public interface IOpenDotaApiClient
{
    Task<string> GetAllDotaHeroes();
}