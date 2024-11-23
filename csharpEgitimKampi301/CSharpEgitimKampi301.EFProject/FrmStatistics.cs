using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db= new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblSumGuide.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text= ((int)db.Location.Average(x => x.Capacity)).ToString();
            lblAvgLocPrice.Text=((int)db.Location.Average(x=>x.Price)).ToString()+ " ₺";

            int lblLastLocId = db.Location.Max(x=>x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lblLastLocId).Select(y =>
            y.Country).FirstOrDefault();

            lblCapadociaLocCap.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTrCapacity.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var RomaGuideId = db.Location.Where(x => x.City == "Roma").Select(y=>y.GuideId).FirstOrDefault();
            lblRomaGuide.Text = db.Guide.Where(x=>x.GuideId==RomaGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacity.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();


            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPrice.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            //ayşegülün idyi bul. idnin cityleri -- count city yap.

            var TourGuideId = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select
                (y => y.GuideId).FirstOrDefault();
            lblGuideTours.Text = db.Location.Where(x=>x.GuideId==TourGuideId).Count().ToString();   


        }
    }
}
