﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XboxWCFService
{
    [DataContract]
    public class BodyDataObject
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Joints { get; set; }
        [DataMember]
        public string JointPoints { get; set; }
        [DataMember]
        public DateTime TimeStamp { get; set; }

        public BodyDataObject()
        {
          
        }
        public BodyDataObject(string u, string j, string jp, DateTime ts)
        {
            UserName = u;
            Joints = j;
            JointPoints = jp;
            TimeStamp = ts;
        }
    }

 
}