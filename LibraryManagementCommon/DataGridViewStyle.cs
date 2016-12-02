using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagementCommon
{
    /// <summary>
    /// 设置DataGridView的样式
    /// </summary>
    public class DataGridViewStyle
    {
        /// <summary>
        /// 普通的样式
        /// </summary>        
        public void DgvStyle1(DataGridView dgv)
        {
            //奇数行的背景色
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 134 ) ));
            //默认的行样式
            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ));
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            //数据网格颜色
            dgv.GridColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ));
            //列标题的宽度
            dgv.ColumnHeadersHeight = 28;
        }
        /// <summary>
        /// 凹凸样式
        /// </summary>
        /// 需要手动设置this.RowTemplate.DividerHeight = 2;    
        public void DgvStyle2(DataGridView dgv)
        {
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            //列标题的边框样式
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 134 ) ));
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            dgv.ColumnHeadersHeight = 28;
            //行的边框样式
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 134 ) ));
            dgv.RowTemplate.DividerHeight = 1;
            //禁止当前默认的视觉样式
            dgv.EnableHeadersVisualStyles = false;
        }

        /// <summary>
        /// 给DataGridView添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var strRowNo = ( e.RowIndex + 1 ).ToString();
            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers  
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(strRowNo, e.InheritedRowStyle.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
