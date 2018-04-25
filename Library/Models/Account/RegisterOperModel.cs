using System.ComponentModel.DataAnnotations;


namespace Library.Models.Account
{
    public class RegisterOperModel
    {
        [Required(ErrorMessage = "Введите фамилию, имя и отчество")]
        //  [RegularExpression(@"([А-Яа-я]+\s){2}[А-Яа-я]+", ErrorMessage = "Некорректный формат ФИО")]
        public string Fio1 { get; set; }

        [Required(ErrorMessage = "Введите дату рождения")]
        [RegularExpression(@"((0[1-9]|[12]\d)(\.)(0[1-9]|1[012])|30(\.)(0[13-9]|1[012])|31(\.)(0[13578]|1[02]))(\.)[0-9]{4}", ErrorMessage = "Некорректный формат даты")]
        public string Birthday1 { get; set; }

        [Required(ErrorMessage = "Введите серию паспорта")]
        //[RegularExpression(@"(89)[0-9]{9}", ErrorMessage = "Некорректный формат серии паспорта")]
        public string PassportSeries1 { get; set; }

        [Required(ErrorMessage = "Введите номер паспорта")]
        // [RegularExpression(@"(89)[0-9]{9}", ErrorMessage = "Некорректный формат номера паспорта")]
        public string PassportKod1 { get; set; }

        [Required(ErrorMessage = "Введите номер свидетельства о рождении")]
        // [RegularExpression(@"(89)[0-9]{9}", ErrorMessage = "Некорректный формат номера паспорта")]
        public string CertificateCode1 { get; set; }

        [Required(ErrorMessage = "Введите e-mail")]
        [EmailAddress(ErrorMessage = "Неккоректный e-mail")]
        public string Email1 { get; set; }

        [Required(ErrorMessage = "Это точно оператор?")]
        public string userRole1 { get; set; }

        [Required(ErrorMessage = "Введите логин")]
        public string Login1 { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        public string Password1 { get; set; }
    }
}
