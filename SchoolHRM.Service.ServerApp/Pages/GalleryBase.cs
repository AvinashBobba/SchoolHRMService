using Microsoft.AspNetCore.Components;
using SchoolHRM.Service.ServerApp.Helpers;
namespace SchoolHRM.Service.ServerApp.Pages
{
    public class GalleryBase : ComponentBase
    {

        [Inject] 
        NavigationHelperService _navigationHelperService { get; set; }

        public void NavigateToArchive()
        {
            _navigationHelperService.ChangePage();
        }
    }
}
