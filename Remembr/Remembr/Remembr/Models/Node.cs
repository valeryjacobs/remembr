using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Remembr.Models
{
    public class Node : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Node()
        {
            Children = new ObservableCollection<Node>();
            ContentId = "1";
        }
     

        private string _id;
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private string _description;

        [JsonProperty("d")]
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }

        private string _title;

         [JsonProperty("n")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }

        private string _contentId;

         [JsonProperty("cid")]
        public string ContentId
        {
            get { return _contentId; }
            set
            {
                _contentId = value;
                NotifyPropertyChanged("ContentId");
            }
        }

        private Node _parent;

        [JsonIgnoreAttribute]
        public Node Parent
        {
            get { return _parent; }
            set
            {
                _parent = value;
                NotifyPropertyChanged("Parent");
            }
        }


        private bool _markedForDeletion;

        public bool MarkedForDeletion
        {
            get { return _markedForDeletion; }
            set { _markedForDeletion = value; }
        }
        


        private ObservableCollection<Node> _children;

        [JsonProperty("c")]
        public ObservableCollection<Node> Children
        {
            get { return _children; }
            set
            {
                _children = value;
                NotifyPropertyChanged("Children");
            }
        }



        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
