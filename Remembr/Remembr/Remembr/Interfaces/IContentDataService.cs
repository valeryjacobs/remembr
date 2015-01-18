using Remembr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remembr.Interfaces
{
    public interface IContentDataService
    {
        Task<List<Content>> GetAllContent();

        Task<List<Content>> GetContent(DateTime since);

        Task<List<Content>> GetContent(string id);

        string AddContent(string id, Content content);

        void UpdateContent(string id, Content content);
        
        void DeleteContent(string id);
    }
}
