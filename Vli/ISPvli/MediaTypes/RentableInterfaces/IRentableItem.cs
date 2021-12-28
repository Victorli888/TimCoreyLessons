using System;

namespace MediaTypes
{
    public interface IRentableItem
    {
        void CheckOut(string borrower);
        void CheckIn();
        DateTime GetDueDate();
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
    }
}