using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections.Specialized;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool GetUser(string username, string password);

        [OperationContract]
        [return: MessageParameter(Name = "NewUser")]
        UserTable InsertUser(UserTable user);


        [OperationContract]
        string encryptPassword(string password);

        [OperationContract]
        void sendEmail(string email);
        //void generateEncryptedPassword(string username, string password);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserTable
    {
        [DataMember]
        public string username { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public string email { get; set; }

    }
}
