using System.Text.Json.Serialization;

namespace Dal.Entities;

/// <summary>
/// Dal-сущность для текста
/// </summary>
public record TextDal
{
    /// <summary>
    /// Текстовые данные
    /// </summary>
    [JsonPropertyName("textContent")]
    public string TextContent { get; set; }
}