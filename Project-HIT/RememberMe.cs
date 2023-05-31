using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Project_HIT
{

    [Serializable()]

    public class RememberMe : ISerializable
    {
        Person p;



        bool askedToBeRemembered;
        string id;
        string pass;

        public Person P { get => p; set => p = value; }
        public bool AskedToBeRemembered { get => askedToBeRemembered; set => askedToBeRemembered = value; }
        public string Id { get; internal set; }
        public string Pass { get => pass; set => pass = value; }

        public RememberMe()
        {
            bool askedToBeRemembered;
            string id = "-1";
            string pass = "-1";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("p", p);
            info.AddValue("askedToBeRemembered", askedToBeRemembered);
            info.AddValue("id", id);
            info.AddValue("pass", pass);

        }

        public RememberMe(SerializationInfo info, StreamingContext context)
        {

            p = (Person)info.GetValue("p", typeof(Person));
            askedToBeRemembered = (bool)info.GetValue("askedToBeRemembered", typeof(bool));
            id = (string)info.GetValue("id", typeof(string));
            pass = (string)info.GetValue("pass", typeof(string));
        }
    }
}
