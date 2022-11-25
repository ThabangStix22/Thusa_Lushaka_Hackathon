namespace WebAPI.Data
{
    public class Client
    {
        public Client()
        {

        }
        public int CL_IdNumber { get; set; }

        public string CL_Name { get; set; }

        public string CL_Surname { get; set; }

        public string CL_Address { get; set; }
        public string CL_Email_Address { get; set; }

        public int CL_CellNumber { get; set; }

        public bool CL_Gender { get; set; }

        public string CL_Affidavit { get; set; }

        public string CL_Password { get; set; }

        public string CL_Role { get; set; }
    }
}
