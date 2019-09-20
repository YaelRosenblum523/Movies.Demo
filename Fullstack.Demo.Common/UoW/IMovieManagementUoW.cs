using Fullstack.Demo.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Common.UoW
{
    public interface IMovieManagementUoW
    {
        IMovieRepository Movies { get; }
    }
}
