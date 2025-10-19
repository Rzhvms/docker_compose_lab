using AutoMapper;
using Dal.Interfaces;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Services;

/// <inheritdoc />
public class TextService : ITextService
{
    private readonly ITextRepository _textRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Конструктор
    /// </summary>
    public TextService(ITextRepository textRepository, IMapper mapper)
    {
        _textRepository = textRepository;
        _mapper = mapper;
    }
    
    /// <inheritdoc />
    public async Task<TextModel> GetTextAsync()
    {
        var textDal = await _textRepository.GetTextAsync();
        return _mapper.Map<TextModel>(textDal);
    }
}