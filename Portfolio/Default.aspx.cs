using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      Table tbl = new Table();
      TableRow tr = new TableRow();
      TableCell tc = new TableCell();
      for (int i=0; i< 19; i++)
      {
        tr = new TableRow();
        tc = new TableCell();
        tc.Text = (tbl.Rows.Count +1).ToString();
        tr.Cells.Add(tc);
        tbl.Rows.Add(tr);
      }

      div1.Controls.Add(tbl);
    }
  }
}