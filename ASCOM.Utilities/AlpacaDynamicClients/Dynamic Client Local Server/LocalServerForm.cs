using System.Windows.Forms;

namespace ASCOM.DynamicClients
{
    public partial class LocalServerForm : Form
    {
        public string DeviceId { get; set; }
        public string DeviceClass { get; set; }
        public string DeviceInterface { get; set; }
        public int InterfaceVersion { get; set; }
        public string Namespace { get; set; }

        private delegate void SetTextCallback(string text);

        public LocalServerForm(ASCOM.Utilities.TraceLogger tL)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.Visible = false;
        }

    }
}