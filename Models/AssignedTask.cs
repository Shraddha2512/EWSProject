﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace EmployeeWorkScheduler.Web.Models
{
    [Table(name: "AssignedTasks")]
    public class AssignedTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Task ID")]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Please enter the Task Description !")]
        [Display(Name = "Task Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the Assigned Date !")]
        [Display(Name = "Assigned Date")]
        public System.DateTime AssignedDate { get; set; }

        [Required(ErrorMessage = "Please enter the Due Date !")]
        [Display(Name = "Due Date")]
        public System.DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Please select the Status !")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Please select the Status Updated Date !")]
        [Display(Name = "Status Updated On")]
        public System.DateTime StatusUpdateDate { get; set; }

        [Required(ErrorMessage = "Please select the Priority !")]
        public string Priority { get; set; }


        #region navigation to Employee and Admin Models
       
        //[Required(ErrorMessage = "Please select the Employee ID !")]
        //[Display(Name = "Employee ID")]
        // public int EmpId { get; set; }
       

        //[Required(ErrorMessage = "Please select the Manager ID !")]
        //[Display(Name = "Manager ID")]
        // public int AdminId { get; set; }

        #endregion

        [Required(ErrorMessage = "Please add the Comment !")]
        public string Comment { get; set; }

    }
}