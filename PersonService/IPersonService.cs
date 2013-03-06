using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PersonService
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        Person GetPerson(int id);

    }

    [DataContract]
    public class Person
    {
        string _stringValue = "Hello ";

        [DataMember]
        public string Name
        {
            get { return _stringValue; }
            set { _stringValue = value; }
        }
    }
}
