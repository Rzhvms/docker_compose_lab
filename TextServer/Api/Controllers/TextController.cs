using Api.Controllers.Dto;
using AutoMapper;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <summary>
/// Контроллер для работы с текстом
/// </summary>
[ApiController]
[Route("api/text")]
public class TextController : ControllerBase
{
    private readonly ITextService _textService;
    private readonly IMapper _mapper;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public TextController(ITextService textService, IMapper mapper)
    {
        _textService = textService;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Получение текста на клиенте
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(GetTextResponse),StatusCodes.Status200OK)]
    public async Task<IActionResult> GetTextAsync()
    {
        var model = await _textService.GetTextAsync();
        var response = _mapper.Map<GetTextResponse>(model);
        return Ok(response);
    }
}