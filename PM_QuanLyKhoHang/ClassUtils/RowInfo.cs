using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QuanLyKhoHang.ClassUtils
{
    public class RowInfo
    {
        public RowInfo(DevExpress.XtraGrid.Views.Grid.GridView view, int rowHandle)
        {
            this.RowHandle = rowHandle;
            this.View = view;
        }
        public DevExpress.XtraGrid.Views.Grid.GridView View;
        public int RowHandle;
    }
}
