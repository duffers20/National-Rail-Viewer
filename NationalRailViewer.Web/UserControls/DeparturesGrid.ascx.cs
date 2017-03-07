using NationalRailViewer.Model;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NationalRailViewer.Web.UserControls
{
    public partial class DeparturesGrid : UserControl
    {
        public void LoadData(QueryResult data)
        {
            gvData.DataSource = data;
            gvData.DataBind();
            gvData.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}