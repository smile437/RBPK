using System.Web.UI.WebControls;

namespace MvcApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("UserProfile")]
    public partial class UserProfile
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string what_language_you_want_to_learn { get; set; }

        public string Native_Language { get; set; }

        public string Talk_topics { get; set; }
    }
}
