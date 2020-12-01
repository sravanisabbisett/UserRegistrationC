using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UserRegistration
{
    public class UserDetails
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage = "Name{0} is required")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "Entered Name is not Valid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should contains atlesast three letters")]
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [Required(ErrorMessage = "MobileNumber{0} is required")]
        [RegularExpression("^[0-9]{2}\\s[6-9]{1}[0-9]{9}", ErrorMessage = "Entered Number is not valid")]
        [StringLength(13, ErrorMessage = "MobileNumber should contain countrycode")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required(ErrorMessage = "Email{0} is required")]
        [RegularExpression("^^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$", ErrorMessage = "Entered Email is not valid")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required(ErrorMessage = "Password{0} is required")]
        [RegularExpression("^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$", ErrorMessage = "Entered Password is not valid")]
        [StringLength(32,MinimumLength =8, ErrorMessage = "Passwod should contain atleast 8 characters")]
        public string Password { get; set; }



    }
}
