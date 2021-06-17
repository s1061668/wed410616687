using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410616687.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }
    public class StudentMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="請輸入姓名")]
        [Display(Name="姓名")]
        [StringLength(5,MinimumLength =2,ErrorMessage = "請輸入2~5個字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入學號")]
        [Display(Name = "學號")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "請輸入1~10個字")]
        public string Number { get; set; }

        [Required(ErrorMessage = "請輸入 Email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}