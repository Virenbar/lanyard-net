using Lanyard.WF.Properties;

namespace Lanyard.WF
{
    public partial class FormMain : Form
    {
        private readonly LanyardClient Client = new();

        public FormMain()
        {
            InitializeComponent();

            TB_UserID.DataBindings.Add("Text", Settings.Default, "UserID", true, DataSourceUpdateMode.OnPropertyChanged);
            TB_APIKey.DataBindings.Add("Text", Settings.Default, "APIKey", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private async void B_DeleteKey_Click(object sender, EventArgs e)
        {
            using var KV = new KVClient(Settings.Default.UserID, Settings.Default.APIKey);
            await KV.DeleteKey(TB_KVKey.Text);
        }

        private async void B_Patch_Click(object sender, EventArgs e)
        {
            using var KV = new KVClient(Settings.Default.UserID, Settings.Default.APIKey);
            var D = new Dictionary<string, string> {
                { TB_KVKey.Text, TB_KVValue.Text }
            };
            await KV.SetKeys(D);
        }

        private async void B_SetKey_Click(object sender, EventArgs e)
        {
            using var KV = new KVClient(Settings.Default.UserID, Settings.Default.APIKey);
            await KV.SetKey(TB_KVKey.Text, TB_KVValue.Text);
        }

        private async void B_User_Click(object sender, EventArgs e)
        {
            var Presence = await Client.GetPresence(Settings.Default.UserID);
            PG_Data.SelectedObject = Presence;
        }

        private void FormMain_Load(object sender, EventArgs e)
        { /* No OP */ }
    }
}