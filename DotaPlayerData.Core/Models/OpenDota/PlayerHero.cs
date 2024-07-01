using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.OpenDota;

public class PlayerHero
{
    public string HeroId { get; set; }
    public string Name { get; set; }
    public int LastPlayed { get; set; }
    private int Games { get; set; }

    public string Avatar { get; set; }
    
    [JsonPropertyName("games")]
    public int GamesPlayed
    {
        get => Games;
        set
        {
            Games = value;
            OnPropertyChanged(nameof(GamesPlayed));
            OnPropertyChanged(nameof(WinRate));
        }
    }
    
    [JsonPropertyName("win")]
    public int WinCount
    {
        get => Win;
        set
        {
            Win = value;
            OnPropertyChanged(nameof(WinCount));
            OnPropertyChanged(nameof(WinRate));
        }
    }

    private int Win { get; set; }

    public double WinRate => (double)Win / (double)Games;

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}