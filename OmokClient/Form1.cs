using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Network;

namespace OmokClient
{
    public partial class Form1 : Form
    {
        private readonly C_Network.RefChattingClient client;

        //public unsafe delegate RefErrorCode CallbackDelegate(C_Utility::RefSerializationBuffer^);

        // Dictionary<RefPacketType, CallbackDelegate> callbackDic = new Dictionary<RefPacketType, CallbackDelegate>();

        public Form1()
        {
            client = new C_Network.RefChattingClient("127.0.0.1", 6000,1);

            //RegistHandle();

            InitializeComponent();
        }

        public void RegistHandle(RefPacketType packetType, C_Utility.RefSerializationBuffer refBuffer)
        {
            client.RegisterHandler(RefPacketType.LOG_IN_RESPONSE_PACKET, Func);
        
        }
        C_Network.RefErrorCode Func(C_Utility.RefSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }
    }
}
