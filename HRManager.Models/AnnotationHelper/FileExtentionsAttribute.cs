using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.AnnotationHelper
{
    internal class ExtentionAttribute:ValidationAttribute
    {
        public string Extensions { get; set; }
        public override bool IsValid(object? value)
        {
            bool IsValid = true;
            IFormFile? file = value as IFormFile;
            List<string> allowedExtensions = this.Extensions.Split(",").ToList();
            if (file is not null)
            {
                var fileName=file.FileName;
                IsValid = allowedExtensions.Any(y=>fileName.EndsWith(y));
            }
            if(IsValid==false)
            {
                ErrorMessage = " Should be of type " + Extensions;
                return false;
            }
            return true;
        }
    }
}
