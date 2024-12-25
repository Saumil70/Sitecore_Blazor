using System.Net;

namespace Sitecore_Blazor.RestGateway
{
    public class RestResponse<T> : IDisposable
    {
        private Boolean _issuccessful;
        private T _resultdata;
        private HttpStatusCode _statuscode;
        private string _errormessage;

        public Boolean IsSuccessful { get { return _issuccessful; } set { _issuccessful = value; } }
        public T ResultData { get { return _resultdata; } set { _resultdata = value; } }
        public HttpStatusCode StatusCode { get { return _statuscode; } set { _statuscode = value; } }
        public string ErrorMessage { get { return _errormessage; } set { _errormessage = value; } }
        public Exception Error { get; set; }
        bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
    public class ErrorResponse
    {
        public List<string> Errors { get; set; }
    }
}

