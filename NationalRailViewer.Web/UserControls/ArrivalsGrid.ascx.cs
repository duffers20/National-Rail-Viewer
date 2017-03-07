using NationalRailViewer.Model;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NationalRailViewer.Web.UserControls
{
    public partial class ArrivalsGrid : UserControl
    {
        public void LoadData(QueryResult data)
        {
            gvData.DataSource = data;
            gvData.DataBind();
            gvData.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}