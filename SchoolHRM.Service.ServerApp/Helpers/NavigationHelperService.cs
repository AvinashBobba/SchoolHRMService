using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolHRM.Service.ServerApp.Helpers
{
    public class NavigationHelperService
    {
        private NavigationManager _navigationManager;
        public NavigationHelperService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void ChangePage()
        {
            _navigationManager.NavigateTo("/archive");
        }
    }
}
