using Atos.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOS.Resource.Common
{
    public class Person : IEntityBase<Guid, Guid>
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }
        public bool State { get; set; }
        public Guid IdUserCreator { get; set; }
        public DateTime DateCreated { get; set; }




    }
}
