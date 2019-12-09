using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeHostForm
{
    public partial class Form1 : Form
    {
        ServiceHost host;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(EmployeeServiceRepository.EmployeeRepository));
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (host.State == CommunicationState.Opened)
            {
                host.Close();

                btnService.Text = "Start";

                lblStatus.Text = "Service stopped...";
            }
            else if (host.State == CommunicationState.Closed || host.State == CommunicationState.Created)
            {
                host.Open();
                btnService.Text = "Stop";
                lblStatus.Text = "Service started at " + DateTime.Now;
            }
            else
            {
                lblStatus.Text = "Unknown Service status";
            }
        }
    }
}
