using System;
using System.Runtime.Serialization;

namespace Project_HIT
{
    [Serializable()]
    public class Request : ISerializable
    {
        public String Lecturer { get; set; }
        public String Subject { get; set; }
        public String Content { get; set; }

        public Request() { Clear(); }

        public Request(String lecturer, String subj, String content)
        {
            Lecturer = lecturer;
            Subject = subj;
            Content = content;
        }

        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(Lecturer) && String.IsNullOrEmpty(Subject) && String.IsNullOrEmpty(Content);
        }

        public void Clear()
        {
            Lecturer = String.Empty;
            Subject = String.Empty;
            Content = String.Empty;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Lecturer", Lecturer);
            info.AddValue("Subject", Subject);
            info.AddValue("Content", Content);
        }

        public Request(SerializationInfo info, StreamingContext context)
        {
            Lecturer = (String)info.GetValue("Lecturer", typeof(string));
            Lecturer = (String)info.GetValue("Subject", typeof(string));
            Lecturer = (String)info.GetValue("Content", typeof(string));
        }
    }
}
