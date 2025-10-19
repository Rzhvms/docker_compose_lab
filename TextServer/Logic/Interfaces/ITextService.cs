using Logic.Models;

namespace Logic.Interfaces;

/// <summary>
/// Сервис для работы с текстом
/// </summary>
public interface ITextService
{
    /// <summary>
    /// Получение текстовых данных
    /// </summary>
    Task<TextModel> GetTextAsync();
}