using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace ShowCustomTextOnEmptyDataSource {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        bool emptyDataSource = false;

        private void DetailReport_BeforePrint(object sender, PrintEventArgs e) {
            // Uncomment the following line, to see the report's data.
            // categoriesTableAdapter.Fill(dataSet11.Categories);

            if (((XtraReportBase)sender).DataSource != null) {
                emptyDataSource = 
                    ((DataSet1)((XtraReportBase)sender).DataSource).Categories.Rows.Count == 0;
            }
            else {
                emptyDataSource = true;
            }

            e.Cancel = emptyDataSource;
        }

        private void DetailReport1_BeforePrint_1(object sender, PrintEventArgs e) {
            e.Cancel = !emptyDataSource;
        }
    }
}
