using Code360NEWWEB.Models;
using Code360NEWWEB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Code360NEWWEB.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IStudent _studentRepo;
     
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger logger;

      
        public HomeController(IStudent studentRepo,
            IHostingEnvironment hostingEnvironment,
             ILogger<HomeController> logger )
        {
            _studentRepo = studentRepo; 
            this.hostingEnvironment = hostingEnvironment;
            this.logger=logger;

     
      
        }

    


        //[Route("")]
        //[Route("/home")]
        //[Route("/index")]
        [AllowAnonymous]
        public ViewResult Index()
        {
            var model = _studentRepo.GetAllStudents();
            return View(model);
        }


        [AllowAnonymous]
        public ViewResult Details(int? id)
        {

            //throw new Exception("Error in Details View")
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");








            StudentClass studentClass = _studentRepo.GetStudent(id.Value);
            if (studentClass == null)
            {
                Response.StatusCode = 404;
                return View("StudentNotFound", id.Value);
            }

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                StudentClass = studentClass,
                PageTitle = "StudentClass Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
       
        public ViewResult Create()
        {
            return View();
        }




        // DElete code
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _studentRepo.Delete(id);
            return RedirectToAction("index");
        }



        [HttpGet]
       
        public ViewResult Edit(int id)
        {
            StudentClass studentClass = _studentRepo.GetStudent(id);
            StudentEditViewModel studentEditViewModel = new StudentEditViewModel
            {
                Id = studentClass.Id,
                Name = studentClass.Name,
                Email = studentClass.Email,
                Gender= studentClass.Gender,
                NextOfKinName= studentClass.NextOfKinName,
                NextOfKinPhone = studentClass.NextOfKinPhone,
                NextOfKinAddress = studentClass.NextOfKinAddress,
                DOB = studentClass.DOB,
                Address = studentClass.Address,
                Identification = studentClass.Identification,
                Nationality = studentClass.Nationality,
                Phone = studentClass.Phone,
                 HealthCondition = studentClass.HealthCondition,
                Marital = studentClass.Marital,
                StudentStatus = studentClass.StudentStatus,
                AdmissionType = studentClass.AdmissionType,
                ExistingPhotoPath = studentClass.PhotoPath
            };


            return View(studentEditViewModel);
        }



        [HttpPost]
       
        public IActionResult Edit(StudentEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                StudentClass studentClass = _studentRepo.GetStudent(model.Id);
                studentClass.Name = model.Name;
                studentClass.Email = model.Email;
                studentClass.DOB = model.DOB;
                studentClass.Address = model.Address;
                studentClass.Identification = model.Identification;
                studentClass.Nationality = model.Nationality;
                studentClass.Phone = model.Phone;
                studentClass.NextOfKinName = model.NextOfKinName;
                studentClass.NextOfKinPhone = model.NextOfKinPhone;
                studentClass.NextOfKinAddress = model.NextOfKinAddress;
                studentClass.HealthCondition = model.HealthCondition;
                studentClass.Marital = model.Marital;
                studentClass.StudentStatus = model.StudentStatus;
                studentClass.AdmissionType = model.AdmissionType;
                studentClass.Gender = model.Gender;

                if (model.Photo != null)
                {

                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                            "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }

                     studentClass.PhotoPath = ProcessUloadedFile(model);
                }

                _studentRepo.Update(studentClass);
                return RedirectToAction("index");


                //var result = _studentRepo.Update(studentClass);
                //if (result == null)
                //{
                //    return View(model);
                //}
                //return RedirectToAction("index");
            }


            return View();
        }

        private string ProcessUloadedFile(StudentCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)

            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }

            }

            return uniqueFileName;
        }

        [HttpPost]
      
        public IActionResult Create(StudentCreateViewModel model)
        {

            if (ModelState.IsValid)
            {

                string uniqueFileName = ProcessUloadedFile(model);

                StudentClass newStudent = new StudentClass
                {


                    Name = model.Name,
                    Email = model.Email,
                    Gender=model.Gender,
                    DOB = model.DOB,
                    Address = model.Address,
                    Identification = model.Identification,
                    Nationality = model.Nationality,
                    Phone = model.Phone,
                    HealthCondition = model.HealthCondition,
                    Marital = model.Marital,
                    NextOfKinName= model.NextOfKinName,
                    NextOfKinPhone = model.NextOfKinPhone,
                    NextOfKinAddress= model.NextOfKinAddress,
                    StudentStatus = model.StudentStatus,
                    AdmissionType = model.AdmissionType,
                    PhotoPath = uniqueFileName



                };
                _studentRepo.Add(newStudent);
                return RedirectToAction("index", new { Id = newStudent.Id});



            }


            return View();
        }


}   }
