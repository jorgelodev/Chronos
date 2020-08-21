using System;
using System.Collections.Generic;
using System.Text;

namespace Chronos.Business.Interfaces.Specifications
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
