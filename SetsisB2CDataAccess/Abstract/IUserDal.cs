using SetsisB2C_Core.DataAccess;
using SetsisB2C_Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SetsisB2C_DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
