namespace WWWWW.models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Appliance { get; set; } // устройство
        public string IssueDescription { get; set; } // описание проблемы
        public string RequestDate { get; set; } // дата запроса
        public bool Status { get; set; } // статус заявки
    }
}
