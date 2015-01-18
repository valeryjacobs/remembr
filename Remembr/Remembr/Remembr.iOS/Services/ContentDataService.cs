using Remembr.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remembr.iOS.Services
{
    public class ContentDataService : IContentDataService
    {

        public string AddContent(string id, Models.Content content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(string id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<List<Models.Content>> GetAllContent()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<List<Models.Content>> GetContent(string id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<List<Models.Content>> GetContent(DateTime since)
        {
            throw new NotImplementedException();
        }

        public void UpdateContent(string id, Models.Content content)
        {
            throw new NotImplementedException();
        }
    }
}
