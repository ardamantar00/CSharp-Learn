using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatisticts : Form
    {
        public FrmStatisticts()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatisticts_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgTourPrice.Text = db.Location.Average(x=>x.Price).ToString() + "₺";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTrAvgCapacity.Text = db.Location.Where(x=>x.Country == "Türkiye").Average(y=>y.Capacity).ToString();
            int romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y=>y.Guide.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString() ;
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityTour.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City + " - " + y.Country).FirstOrDefault().ToString();
            var maxPriceTour = db.Location.Max(x => x.Price);
            lblMaxPriceTour.Text = db.Location.Where(x=>x.Price == maxPriceTour).Select(y=>y.City).FirstOrDefault().ToString();
            var guideIdByNameAliYidiz = db.Guide.Where(x => x.GuideName == "Ali" && x.GuideSurname == "Yıldız").Select(y => y.GuideId).FirstOrDefault();
            lblAliYildizLocationCount.Text = db.Location.Where(x=>x.GuideId == guideIdByNameAliYidiz).Count().ToString();
        }

       
    }
}
