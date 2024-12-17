namespace WWWWW.models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public int RequestId { get; set; }
        public bool Status { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string IssueDescription { get; set; }
        public string Appliance { get; set; }
        public int Cost { get; set; }
        public string RequestDate { get; set; }
    }
}
