using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;

namespace MSMQ_Test_1
{
    public partial class FrmMSMQ : Form
    {
        /// <summary>
        /// Path to the to-be-used queue.
        /// </summary>
        private string queuePath = @".\private$\test1";

        public FrmMSMQ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the user wants to send a particular message to the queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSend_Click(object sender, EventArgs e)
        {
            // Use a message queue.
            using(MessageQueue queue = new MessageQueue())
            {
                // Set the path on the correct queue.
                queue.Path = queuePath;

                // Check if the path exists, if not, notify.
                if (!MessageQueue.Exists(queue.Path))
                {
                    MessageBox.Show("Could not find queue.");
                }
                else
                {
                    // Create a new message and set textbox text.
                    System.Messaging.Message message = new System.Messaging.Message();
                    message.Body = TxtSend.Text;

                    // Send the message.
                    queue.Send(message);
                }
            }
        }

        /// <summary>
        /// Called when the user wants to receive a message on the queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReceive_Click(object sender, EventArgs e)
        {
            // Use a message queue.
            using(MessageQueue queue = new MessageQueue())
            {
                // Set the path on the correct queue.
                queue.Path = queuePath;

                // Check if the path exists, if not, notify.
                if (!MessageQueue.Exists(queue.Path))
                {
                    MessageBox.Show("Could not find queue.");
                }
                else
                {
                    // Create a new message.
                    //System.Messaging.Message message = new System.Messaging.Message();

                    // Receive message.
                    System.Messaging.Message message = queue.Receive();

                    // Set formatter.
                    message.Formatter = new XmlMessageFormatter(new string[] { "System.String, mscorlib" });

                    // Set contents to textbox.
                    TxtReceive.Text = message.Body.ToString();
                }
            }
        }
    }
}
