using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Network;

namespace OmokClient
{
    public partial class Form1 : Form
    {
        private readonly C_Network.RefChattingClient client;

        Dictionary<RefPacketType, Func<RefErrorCode>> MakeFuncsDic =
            new Dictionary<RefPacketType, Func<RefErrorCode>>();
        public enum ConnectionType
        {
            CONN,
            DISCONN,
        }
        ConnectionType curConnType = ConnectionType.CONN;
        public Form1()
        {
            InitializeComponent();

            string ip = ipTB.Text;
            ushort port = ushort.Parse(portTB.Text);
            client = new C_Network.RefChattingClient(ip,port,1);

            RegisterFunctions();
        }

        public void RegisterFunctions()
        {
            client.RegisterHandler(RefPacketType.LOG_IN_RESPONSE_PACKET, ProcessLogIn);
            client.RegisterHandler(RefPacketType.ROOM_LIST_RESPONSE_PACKET, ProcessRoomInfo);
            client.RegisterHandler(RefPacketType.ENTER_ROOM_RESPONSE_PACKET, ProcessEnterRoom);
            client.RegisterHandler(RefPacketType.ENTER_ROOM_NOTIFY_PACKET, ProcessNotifyEnterRoom);
            client.RegisterHandler(RefPacketType.LEAVE_ROOM_RESPONSE_PACKET, ProcessLeaveRoom);
            client.RegisterHandler(RefPacketType.LEAVE_ROOM_NOTIFY_PACKET, ProcessNotifyLeaveRoom);
            client.RegisterHandler(RefPacketType.CHAT_NOTIFY_PACKET, ProcessChatNotify);
            client.RegisterHandler(RefPacketType.CHAT_TO_USER_RESPONSE_PACKET, ProcessChatUser);
            client.RegisterHandler(RefPacketType.CHAT_TO_ROOM_RESPONSE_PACKET, ProcessChatRoom);
        
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

        }

        // 받은 메시지를 처리하는 부분.
        #region 패킷처리
        C_Network.RefErrorCode ProcessLogIn(C_Utility.RefRecvSerializationBuffer buff)
        {
            connTB.Text = "연결됨";

            
            return RefErrorCode.NONE;
        }

        C_Network.RefErrorCode ProcessRoomInfo(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }

        C_Network.RefErrorCode ProcessEnterRoom(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }
        C_Network.RefErrorCode ProcessNotifyEnterRoom(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }
        C_Network.RefErrorCode ProcessLeaveRoom(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }
        C_Network.RefErrorCode ProcessNotifyLeaveRoom(C_Utility.RefRecvSerializationBuffer buff)
        {
            int a;
            buff.GetBuffer() >> a;
            return RefErrorCode.NONE;
        }
        C_Network.RefErrorCode ProcessChatNotify(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }
        C_Network.RefErrorCode ProcessChatRoom(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }
        C_Network.RefErrorCode ProcessChatUser(C_Utility.RefRecvSerializationBuffer buff)
        {
            return RefErrorCode.NONE;
        }


        // 보낼 메시지를 등록하는 부분.
        C_Network.RefErrorCode SendMessage(C_Network.RefPacketType packetType)
        {
            C_Network.RefErrorCode error = MakeFuncsDic[packetType]();

            return error;
        }

        C_Network.RefErrorCode MakeLogInRequestPacket()
        {

            C_Network.RefLogInRequestPacket packet;

            uint size = sizeof(RefLogInRequestPacket);
            C_Utility.RefSendSerializationBuffer sendBuffer = client.MakeBuffer();

            ulong id = 1;
            
            ulong pw = 2;

            sendBuffer.Attach(id).Attach(pw); 
            
            return C_Network.RefErrorCode.NONE;
        }

        C_Network.RefErrorCode MakeRoomListRequestPacket()
        {
            return C_Network.RefErrorCode.NONE;
        }
        C_Network.RefErrorCode MakeEnterRoomRequestPacket()
        {
            return C_Network.RefErrorCode.NONE;
        }
        C_Network.RefErrorCode MakeLeaveRoomRequestPacket()
        {
            return C_Network.RefErrorCode.NONE;
        }
        C_Network.RefErrorCode MakeChatToUserRequestPacket()
        {
            return C_Network.RefErrorCode.NONE;
        }
        C_Network.RefErrorCode MakeChatToRoomRequestPacket()
        {
            return C_Network.RefErrorCode.NONE;
        }
        #endregion

        private void connButton_Click(object sender, EventArgs e)
        {
            if(curConnType == ConnectionType.DISCONN)
            {
                client.Begin();

                SendMessage(C_Network.RefPacketType.LOG_IN_REQUEST_PACKET);
                
                connButton.Text = "연결 끊기 버튼";
                
                curConnType = ConnectionType.CONN;
            }
            else
            {
                client.End();

                connButton.Text = "연결 버튼";

                curConnType = ConnectionType.DISCONN;
            }
        }
    }
}
