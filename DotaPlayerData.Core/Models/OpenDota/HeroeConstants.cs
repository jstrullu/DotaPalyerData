using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.OpenDota;

public class HeroeConstants
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("Name")]
    public string Name { get; set; }
    [JsonPropertyName("primary_attr")]
    public string PrimaryAttr { get; set; }
    [JsonPropertyName("attack_type")]
    public string AttackType { get; set; }
    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; }
    
    private string _img { get; set; }
    
    [JsonPropertyName("img")]
    public string Img {
        get => "https://cdn.cloudflare.steamstatic.com/" + _img;
        set => _img = value;
    }
    
    private string _icon { get; set; }

    [JsonPropertyName("icon")]
    public string Icon
    {
        get => "https://cdn.cloudflare.steamstatic.com/" + _icon;
        set => _icon = value;
    }
    [JsonPropertyName("base_health")]
    public double BaseHealth { get; set; }
    [JsonPropertyName("base_health_regen")]
    public double BaseHealthRegen { get; set; }
    [JsonPropertyName("base_mana")]
    public double BaseMana { get; set; }
    [JsonPropertyName("base_mana_regen")]
    public double BaseManaRegen { get; set; }
    [JsonPropertyName("base_armor")]
    public double BaseArmor { get; set; }
    [JsonPropertyName("base_mr")]
    public double BaseMr { get; set; }
    [JsonPropertyName("base_attack_min")]
    public double BaseAttackMin { get; set; }
    [JsonPropertyName("base_attack_max")]
    public double BaseAttackMax { get; set; }
    [JsonPropertyName("base_str")]
    public double BaseStr { get; set; }
    [JsonPropertyName("base_agi")]
    public double BaseAgi { get; set; }
    [JsonPropertyName("base_int")]
    public double BaseInt { get; set; }
    [JsonPropertyName("str_gain")]
    public double StrGain { get; set; }
    [JsonPropertyName("agi_gain")]
    public double AgiGain { get; set; }
    [JsonPropertyName("int_gain")]
    public double IntGain { get; set; }
    [JsonPropertyName("attack_range")]
    public double AttackRange { get; set; }
    [JsonPropertyName("projectile_speed")]
    public double ProjectileSpeed { get; set; }
    [JsonPropertyName("attack_rate")]
    public double AttackRate { get; set; }
    [JsonPropertyName("base_attack_time")]
    public double BaseAttackTime { get; set; }
    [JsonPropertyName("attack_point")]
    public double AttackPoint { get; set; }
    [JsonPropertyName("move_speed")]
    public double MoveSpeed { get; set; }
    [JsonPropertyName("turn_rate")]
    public object TurnRate { get; set; }
    [JsonPropertyName("cm_enabled")]
    public bool CmEnabled { get; set; }
    [JsonPropertyName("legs")]
    public double Legs { get; set; }
    [JsonPropertyName("day_vision")]
    public double DayVision { get; set; }
    [JsonPropertyName("night_vision")]
    public double NightVision { get; set; }
    [JsonPropertyName("localized_name")]
    public string LocalizedName { get; set; }
}