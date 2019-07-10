using Caterpillar.TpemDesktopSc.Properties;
using Caterpillar.TpemDesktopSc.Resxfiles;
using System.Diagnostics;
using System.Reflection;

namespace Caterpillar.TpemDesktopSc
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Gets Assembly version of the application.
        /// </summary>
        /// <value>
        /// The assembly version.
        /// </value>
        public string AssemblyVersion
        {
            get
            {
                return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
                //return Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
            }
        }

        public frmAbout()
        {
            InitializeComponent();
            InitializeTranslations();

            //lblVersion.Text = @"Version " + AssemblyVersion;
            lblVersion.Text = CommonFormElements.FrmAbout_Version + " " + AssemblyVersion;
            pictureEdit1.Image = Resources.icon;
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.caterpillar-energy-solutions.de");
        }

        private void InitializeTranslations()
        {
            
           lblApplicationName.Text = CommonFormElements.FrmAbout_ApplicationName;
           lblVersion.Text = CommonFormElements.FrmAbout_Version;
           linkLabel1.Text = CommonFormElements.FrmAbout_Linklabel;
           this.Text = CommonFormElements.FrmAbout_Title;
            

        }
    }
}