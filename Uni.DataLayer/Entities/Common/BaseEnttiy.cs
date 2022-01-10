using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.DataLayer.Entities.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
