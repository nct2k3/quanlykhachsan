using System.Diagnostics.CodeAnalysis;

namespace QuanLyKhachSan.DTO
{
    public class CustomerDTO
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        public int gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phone { get; set; }
        public int IDDocType { get; set; }
        public string IDDocNumber { get; set; }
        public DateTime dateOfIssue { get; set; }
        public string placeOfIssue { get; set; }
        public string address { get; set; }
        public string nationaly { get; set; }
        public string state { get; set; }
        public string visaNumber { get; set; }
        public DateTime visaInsuanceDate { get; set; }
        public DateTime visaValidity { get; set; }
        public string placeOfIssuance { get; set; }
        public DateTime dateOfEntry { get; set; }
        public string portOfEntry { get; set; }
        public string purposeOfEntry { get; set; }
        public string note { get; set;}
        public CustomerDTO() { }
        public CustomerDTO(int customerId, string name, int gender, DateTime dateOfBirth, string phone, int iDDocType, string iDDocNumber, DateTime dateOfIssue, string placeOfIssue, string address, string nationaly, string state, string visaNumber, DateTime visaInsuanceDate, DateTime visaValidity, string placeOfIssuance, DateTime dateOfEntry, string portOfEntry, string purposeOfEntry, string note)
        {
            this.customerId = customerId;
            Name = name;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.phone = phone;
            IDDocType = iDDocType;
            IDDocNumber = iDDocNumber;
            this.dateOfIssue = dateOfIssue; 
            this.placeOfIssue = placeOfIssue;
            this.address = address;
            this.nationaly = nationaly;
            this.state = state;
            this.visaNumber = visaNumber;
            this.visaInsuanceDate = visaInsuanceDate;
            this.visaValidity = visaValidity;
            this.placeOfIssuance = placeOfIssuance;
            this.dateOfEntry = dateOfEntry;
            this.portOfEntry = portOfEntry;
            this.purposeOfEntry = purposeOfEntry;
            this.note = note;
        }
    }
}
