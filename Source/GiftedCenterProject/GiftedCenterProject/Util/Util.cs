using GiftedCenterProject.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace GiftedCenterProject.Util
{
    public class Util
    {
        public static Connect cnn= new Connect();
        public const int ISACTIVE = 1;
    }
}