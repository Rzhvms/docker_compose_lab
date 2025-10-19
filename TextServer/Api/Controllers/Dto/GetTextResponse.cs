using System.Text.Json.Serialization;

namespace Api.Controllers.Dto;

/// <summary>
/// Выходная модель для получения текста
/// </summary>
public record GetTextResponse
{
    /// <summary>
    /// Текстовые данные 
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }
}