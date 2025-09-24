using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            //var spendings = db.Spendings.ToList();
            //dataGridView1.DataSource = spendings;

            using (var db = new FinancialCrmDbEntities()) //Db ile  işi bitince otomatik dispose edilir.
            {
                var spendings = db.Spendings
                    .Select(x => new
                    {
                        x.SpendingId,
                        x.SpendingTitle,
                        x.SpendingAmount,
                        x.SpendingDate
                    })
                    .ToList();

                dataGridView1.DataSource = spendings;
            }
        }
    }
}
