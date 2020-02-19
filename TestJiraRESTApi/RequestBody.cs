using System.Collections.Generic;
namespace JiraCreationSite
{
    public class RequestBody
    {
        public Fields fields { get; set; }
        public class Project
        {
            public string key { get; set; }
        }

        public class Issuetype
        {
            public string id { get; set; }
        }

        public class Component
        {
            public string name { get; set; }
        }
        public class Assignee
        {
            public string name { get; set; }
        }
        public class Parent
        {
            public string key { get; set; }
        }
        public class Reporter
        {
            public string name { get; set; }
        }

        public class Fields
        {
            public Project project { get; set; }
            public string summary { get; set; }
            public string description { get; set; }
            public Issuetype issuetype { get; set; }
            public List<string> labels { get; set; }
            public List<Component> components { get; set; }
            public Assignee assignee { get; set; }
            public Parent parent { get; set; }
            public Reporter reporter { get; set; }
        }
    }
}
