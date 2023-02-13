namespace LmsApi.Models
{
    public class History
    {
        public long Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
    }
}