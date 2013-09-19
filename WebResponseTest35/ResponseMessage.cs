using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace WebResponseTest35
{
    class ResponseMessage
    {
        public Stream Content { get; private set; }

        public HttpWebResponse Response { get; private set; }

        public ResponseMessage(Stream content, HttpWebResponse response)
        {
            this.Content = content;
            this.Response = response;
        }

        #region Bad Finalizer
        ~ResponseMessage()
        {
            if (this.Response != null)
            {
                try
                {
                    this.Response.Close();
                }
                catch (Exception)
                {
                    // ignore
                }
            }
        }
        #endregion
    }
}
