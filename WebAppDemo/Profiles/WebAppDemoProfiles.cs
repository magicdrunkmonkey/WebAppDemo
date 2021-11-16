using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;
using WebAppDemo.ViewModels;

namespace WebAppDemo.Profiles
{
    public class WebAppDemoProfiles : Profile
    {
        public WebAppDemoProfiles()
        {
            CreateMap<PersonModel, PeopleViewModel>();
        }
    }
}
