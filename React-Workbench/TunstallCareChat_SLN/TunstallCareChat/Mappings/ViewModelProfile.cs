using AutoMapper;
using TunstallCareChat.ViewModels;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChat.Mappings
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<TerminalModel, TerminalViewModel>();
        }
    }
}