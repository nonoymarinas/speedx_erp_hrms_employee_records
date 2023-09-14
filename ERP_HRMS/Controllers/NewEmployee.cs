﻿using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using BusinessModel;
using DataAccess;
using Microsoft.Extensions.Options;

namespace ERP_HRMS.Controllers
{
    public class NewEmployee : Controller
    {
        [Route("new-employee-main-page")]
        public IActionResult NewEmployeeMainPage()
        {
            return View();
        }

        [Route("new-employee-ref-data")]
        async public Task<IActionResult> NewEmployeeReferenceData()
        {
            NewEmpReferenceDataLogic dataLogic = new();
            return Json(await dataLogic.GetReferenceData());
        }

        [Route("employee-detail-page")]
        public IActionResult NewEmployeeOldMainPage()
        {
            return View();
        }

        [Route("save-personal-information")]
        async public Task<IActionResult> SavePersonalInfo(ParamPersonalInfoModel persInfo)
        {
            PersonalInformationLogic dataLogic = new(persInfo);
            return Json(await dataLogic.SavePersonalInfo());
        }

        [Route("update-personal-information")]
        async public Task<IActionResult> UpdatePersonalInfo(ParamUpdatePersonalInfoModel persInfo)
        {
            PersonalInformationLogic dataLogic = new(persInfo);
            return Json(await dataLogic.UpdatePersonalInfo());
        }

        [Route("save-benifits")]
        async public Task<IActionResult> SaveBenifits(ParamSaveBenifitsModel benifits)
        {
            WorkersBenifitsLogic dataLogic = new(benifits);
            return Json(await dataLogic.SaveBenifits());
        }

        [Route("update-benifits")]
        async public Task<IActionResult> UpdateBenifits(ParamUpdateBenifitsModel benifit)
        {
            WorkersBenifitsLogic dataLogic = new(benifit);
            return Json(await dataLogic.UpdateBenifits());
        }


        [Route("save-contacts")]
        async public Task<IActionResult> SaveContacts(ParamContactModel contacts)
        {
            WorkersContactsLogic dataLogic = new(contacts);
            return Json(await dataLogic.SaveContacts());
        }

        [Route("update-contacts")]
        async public Task<IActionResult> UpdateContacts(ParamUpdateContactsModel contacts)
        {
            WorkersContactsLogic dataLogic = new(contacts);
            return Json(await dataLogic.UpdateContacts());
        }

        [Route("save-compensation")]
        async public Task<IActionResult> SaveCompensation(ParamCompensationModel compensation)
        {
            WorkersCompensationLogic dataLogic = new(compensation);
            return Json(await dataLogic.SaveCompensation());
        }

        [Route("update-compensation")]
        async public Task<IActionResult> UpdateCompensation(ParamUpdateCompensationModel updateCompensation)
        {
            WorkersCompensationLogic dataLogic = new(updateCompensation);
            return Json(await dataLogic.UpdateCompensation());
        }

        [Route("save-new-employee-personalinfo")]
        async public Task<IActionResult> SaveNewEmployeePersonalInfo(ParamSaveNewEmployeePersonalInfoModel personalInfo)
        {
            NewEmployeeAllInformationLogic dataLogic = new(personalInfo);
            return Json(await dataLogic.SavePersonalInfo());
        }

        [Route("save-new-employee-benifits")]
        async public Task<IActionResult> SaveNewEmployeeBenifits(ParamSaveNewEmployeeBenifitsModel benifits)
        {
            NewEmployeeAllInformationLogic dataLogic = new(benifits);
            return Json(await dataLogic.SaveBenifits());
        }

        [Route("save-new-employee-contacts")]
        async public Task<IActionResult> SaveNewEmployeeContacts(ParamSaveNewEmployeeContactsModel contacts)
        {
            NewEmployeeAllInformationLogic dataLogic = new(contacts);
            return Json(await dataLogic.SaveContacts());
        }

        [Route("save-new-employee-jobdescriptions")]
        async public Task<IActionResult> SaveNewEmployeeJobDescriptions(ParamSaveNewEmployeeJobDescriptionsModel jobDesc)
        {
            NewEmployeeAllInformationLogic dataLogic = new(jobDesc);
            return Json(await dataLogic.SaveJobDescriptions());
        }

        [Route("update-new-employee-ind-info")]
        async public Task<IActionResult> UpdateNewEmployeeSingleInfo(ParamUpdateNewEmployeeSingleInfoModel singleInfo)
        {
            NewEmployeeAllInformationLogic dataLogic = new(singleInfo);
            return Json(await dataLogic.UpdateSingleInfo());
        }
    }

}
