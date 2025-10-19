using AutoMapper;
using Dal.Entities;
using Logic.Models;

namespace Logic.Mapping;

/// <summary>
/// Профайл для маппинга Logic.Model в Dal.Entity
/// </summary>
public class TextLogicProfile : Profile
{
    public TextLogicProfile()
    {
        CreateMap<TextDal, TextModel>().ForMember(d => d.Text, o => o.MapFrom(s => s.TextContent));
    }
}