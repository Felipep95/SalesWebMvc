using System;

namespace SalesWebMvc.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Message { get; set; }//custom
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}