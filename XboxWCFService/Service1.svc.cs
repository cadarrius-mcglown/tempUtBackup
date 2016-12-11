using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XboxWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<BodyDataObject> GetData(int value)
        {
            List<BodyDataObject> temp = null;
            using (UTBodyDataEntitiesV3 db = new UTBodyDataEntitiesV3())
            {

                temp = db.BodyDatas.Select(x => new BodyDataObject() {UserName = x.UserName,Joints = x.Joints,JointPoints = x.JointPoints, TimeStamp = x.timestamp }).ToList(); 

               // List<BodyDataObject> temp = db.uspGetBodyData();
            }
            return temp;
        }
        public string SendData(string username, string joints, string jointPoints, DateTime dt)
        {
            using(UTBodyDataEntitiesV3 db = new UTBodyDataEntitiesV3())
            {
                db.uspInsertBodyData(username, joints, jointPoints, dt);
            }
            return "hi";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
