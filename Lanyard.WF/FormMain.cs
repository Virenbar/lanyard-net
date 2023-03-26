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

        private async void B_SetKey_Click(object sender, EventArgs e)
        {
            using var KV = new KVClient(Settings.Default.UserID, Settings.Default.APIKey);
            await KV.SetKey(TB_KVKey.Text, TB_KVValue.Text);
        }

        private async void B_User_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(Settings.Default.UserID, out var ID)) { return; }
            var Responce = await Client.User(ID);

            PG_Data.SelectedObject = Responce.Data;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}