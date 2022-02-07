using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static MemberManagement.Models.MemberModel;

namespace MemberManagement.Extension
{
    public class ValidateRegister
    {

        public static DoRegisterOut CheckRegister(DoRegisterIn inModel)
        {
            DoRegisterOut outModel = new DoRegisterOut();
            if (DateTime.Now < inModel.BirthDay)
            {
                outModel.ErrMsg = "Error Birthday";
            }


            EmailAddressAttribute MailIsValid = new System.ComponentModel.DataAnnotations.EmailAddressAttribute();        
            if (!MailIsValid.IsValid(inModel.UserEmail))
            {
                outModel.ErrMsg = "Please enter a valid e-mail adress";
            }



            return outModel;
        }


    }
}