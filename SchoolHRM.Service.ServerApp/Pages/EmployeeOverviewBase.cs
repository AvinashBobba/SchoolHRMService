using Microsoft.AspNetCore.Components;
using SchoolHRM.Service.ServerApp.Components;
using SchoolHRM.Service.ServerApp.Services;
using SchoolHRM.Service.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolHRM.Service.ServerApp.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }
    }
}
