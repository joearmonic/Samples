using System.Linq;
using AutoMapper;
using TunstallCareChat.ViewModels;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChat.Mappings
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<TerminalModel, TerminalViewModel>()
            .ForMember(tm => tm.TemplateName, dto => dto.ResolveUsing(
                (src,dest, member, ctx) => 
                member = src.ConfigurationTemplate.Version.Number
            ))
            .ForMember(tm => tm.ControlCentre, dto => dto.MapFrom(
                src => src.ControlCentre.Name
            ));
        }
    }
}