using System;
using System.Collections.Generic;

namespace BethanysPieShop.Web.EFModels
{
    public partial class Feedback
    {
        public long FeedbackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool ContactMe { get; set; }
    }
}
