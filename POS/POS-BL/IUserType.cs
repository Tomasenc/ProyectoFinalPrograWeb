﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DATA;
using POS_Entitiy;

namespace POS_BL
{
    public interface IUserType
    {
        List<UserType> UserTypeList();
    }
}