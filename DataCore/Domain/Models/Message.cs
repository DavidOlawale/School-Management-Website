using System;

namespace DataCore.Models
{
    public class Message
    {
        public int Id { get; set; }
        public Guid SenderId { get; set; }
        public ApplicationUser Sender { get; set; }
        public Guid? ReceiverId { get; set; }
        public string Content { get; set; }
        public bool Received { get; set; }
        public bool ToAllParents { get; set; }
        public bool ToAdmin { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
    }

}
