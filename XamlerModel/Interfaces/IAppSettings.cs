using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XamlerModel.Interfaces
{
    public interface IAppSettings
    {
        void Load(SplitContainer container);
        void Save(SplitContainer container);
    }
}
