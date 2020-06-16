using Microsoft.AspNetCore.Components;
using SchoolHRM.Service.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolHRM.Service.ServerApp.Pages
{
    public class StudentOverviewBase : ComponentBase
    {
        public List<Student> Students { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await PopuplateData();
        }


        public async Task PopuplateData()
        {
            Student student = new Student();
            Students = new List<Student>();
            for (int i = 1; i < 10; i++)
            {
                student.StudentId = i;
                student.FirstName = "Jack";
                student.SurName = "Jones";
                StudentCategory studentCategory = new StudentCategory();
                studentCategory.StudentCategoryId = 1;
                studentCategory.StudentCategoryDescription = "A";
                ParentalDetails parentalDetails = new ParentalDetails();
                parentalDetails.FatherName = "Jackie";
                parentalDetails.MotherName = "Joniela";
                parentalDetails.ContactNumber = "4546578595955";
                parentalDetails.AnnualIncome = 30000;
                parentalDetails.EmailAddress = "test@gmail.com";
                Address address = new Address();
                address.AddressId = 1;
                address.AddressLine1 = "Muthayaa";
                address.AddressLine2 = "Teststst";
                address.AddressLine3 = "eeeeee";
                address.PostCode = "534234";
                student.Address = address;
                student.ParentalDetails = parentalDetails;
                student.StudentCategory = studentCategory;
                Students.Add(student);

            }

        }
    }
}
