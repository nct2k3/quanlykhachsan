namespace QuanLyKhachSan
{
    public class FundDTO
    {
        public int fundID { get; set; }
        public string fundName { get; set; }
        public int fundType { get; set;}
        public int openingBalance { get; set; }
        public string note { get; set; }    
        public FundDTO() { }
        public FundDTO(int fundID, string fundName, int fundType, int openingBalance, string note)
        {
            this.fundID = fundID;
            this.fundName = fundName;
            this.fundType = fundType;
            this.openingBalance = openingBalance;
            this.note = note;
        }
    }
}