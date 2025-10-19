using Api.Controllers.Dto;
using AutoMapper;
using Logic.Models;

namespace Api.Mapping;

/// <summary>
/// Профайл для маппинга Api.Dto в Logic.Model
/// </summary>
public class TextProfile : Profile
{
    public TextProfile()
    {
        CreateMap<TextModel, GetTextResponse>().ForMember(d => d.Text, o => o.MapFrom(s => s.Text));
    }
}