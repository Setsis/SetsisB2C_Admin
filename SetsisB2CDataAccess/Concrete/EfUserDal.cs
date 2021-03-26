using Microsoft.EntityFrameworkCore;
using SetsisB2C_Core.DataAccess.Entityframework;
using SetsisB2C_Core.Entities;
using SetsisB2C_DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SetsisB2C_DataAccess.Concrete
{
    public class EfUserDal:EfEntitiyRepositoryBase<User,AdminDbContext>,IUserDal
    {
    }
}
