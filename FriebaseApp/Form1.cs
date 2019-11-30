using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FriebaseApp
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "P9JCrClbZSdexlKpTJmu8vhmez1YC7vkK6eRZPJ8",
            BasePath = "https://firesbaseapp-d0651.firebaseio.com/",
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("ຕິດຕໍ່ Firebase ສໍາເລັດ");
            }
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            var data = new Data
           {
               Id = txtid.Text,
               name = txtname.Text,
               lastname=txtlastname.Text,
               address=txtaddress.Text,
               tel=txttel.Text
           };
            SetResponse respose = await client.SetTaskAsync("Information/" + txtid.Text, data);
            Data result = respose.ResultAs<Data>();
            MessageBox.Show("Save Data" + result.Id);
        }

        private async void btnedit_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txtid.Text,
                name = txtname.Text,
                lastname = txtlastname.Text,
                address = txtaddress.Text,
                tel = txttel.Text
            };
            FirebaseResponse respose = await client.UpdateTaskAsync("Information/" + txtid.Text, data);
            Data result = respose.ResultAs<Data>();
            MessageBox.Show("update Data" + result.Id);

        }
    }
}
