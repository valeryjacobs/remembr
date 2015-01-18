using Remembr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remembr.Interfaces
{
    public interface IMindmapDataService
    {
        Task<List<MindMap>> GetAllMindmaps();

        Task<List<MindMap>> GetMindmaps(DateTime since);

        Task<List<MindMap>> GetMindmap(string id);

        string AddMindmap(string id, MindMap mindmap);

        void UpdateMindmap(string id, MindMap mindmap);

        void DeleteMindmap(string id);
    }
}
