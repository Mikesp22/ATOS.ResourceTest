using Atos.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOS.Resource.Abstraction
{
    public interface IEntityBaseAuditable<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        public DateTime ModifyDate { get; set; }
        public TUserKey ModifiedBy { get; set; }
    }
}
