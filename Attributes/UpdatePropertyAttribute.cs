using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelisystem.Utils.Dapper.Extensions.Attributes
{
    public class UpdatePropertyAttribute : Attribute
    {

        private bool _update;
        public UpdatePropertyAttribute(bool update = true)
        {
            this._update = update;
        }

        public bool UpdateProperty => this._update;
    }
}