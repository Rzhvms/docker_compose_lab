using Dal.Entities;

namespace Dal.Interfaces;

/// <summary>
/// Репозиторий для работы с текстовыми данными
/// </summary>
public interface ITextRepository
{
    /// <summary>
    /// Получение текстовых данных из БД
    /// </summary>
    Task<TextDal> GetTextAsync();
}