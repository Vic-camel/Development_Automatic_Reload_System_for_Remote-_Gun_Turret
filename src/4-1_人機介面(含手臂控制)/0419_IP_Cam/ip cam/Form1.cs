using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using VisioForge.Core.VideoCapture;
using VisioForge.Types;
using VisioForge.Types.Output;
using VisioForge.Types.VideoCapture;

using System.Net.Sockets;
using System.Net;

using HIWIN;
using System.Diagnostics;

namespace ip_cam
{


    public partial class video : Form
    {
        // 各類IP 輸入
        String IP_CAM_IP = "192.168.0.14";
        String Fire_Arduino_IP = "192.168.0.68";
        String Gripper_Arduino_IP = "192.168.0.96";
        String Python_IP = "172.16.27.146";
        int RA605_ID = -1;
        int Bullet_numbers = 15;
        bool connectState = false;
        private VideoCaptureCore core;

        private void GUI_update()
        {
            connectToolStripMenuItem.Text = connectState ? "disconnect" : "connect";
            //指定Form1的任何東西，記得要用「this」
            this.Text = "HIWIN RA605 Utility (ID: " + RA605_ID + ")";
        }
        private async void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 啟動ip cam
            core.IP_Camera_Source = new IPCameraSourceSettings()
            {
                URL = "rtsp://" + IP_CAM_IP + "/user=admin_password=tlJwpbo6_channel=1_stream=0.sdp?real_stream",
                Type = IPSourceEngine.Auto_LAV
            };

            core.Audio_PlayAudio = core.Audio_RecordAudio = false;
            core.Mode = VideoCaptureMode.IPPreview;

            //await core.StartAsync();

            if (connectState)
            {
                //disconnect
                //serialPort1.Close();
                connectState = false;
                RA605.Close(RA605_ID);
                RA605_ID = -1;
                await core.StopAsync();
                btnConnect.Text = "Connect";
                State.Text = "State: Unworking";
            }
            else
            {
                //connect
                //serialPort1.Open();
                connectState = true;
                RA605_ID = RA605.Connect("192.168.0.3");
                connectState = RA605_ID == -1 ? false : true;
                await core.StartAsync();
                btnConnect.Text = "Disconnect";
                State.Text = "State: Recording";
            }
            GUI_update();
        }

        #region ip_cam_函式
        //  ip cam 函式
        public video()
        {
            InitializeComponent();
        }

        //  ip cam 啟動
        private async void btstart_Click(object sender, EventArgs e)
        {
            core.IP_Camera_Source = new IPCameraSourceSettings()
            {
                URL = "rtsp://" + "/user=admin_password=tlJwpbo6_channel=1_stream=0.sdp?real_stream",
                Type = IPSourceEngine.Auto_LAV
            };

            core.Audio_PlayAudio = core.Audio_RecordAudio = false;
            core.Mode = VideoCaptureMode.IPPreview;

            await core.StartAsync();
        }

        //  ip cam 啟動
        private async void btstop_Click(object sender, EventArgs e)
        {

            await core.StopAsync();
        }

        //  ip cam 啟動
        private void videoCapture1_Paint(object sender, PaintEventArgs e)
        {

        }

        //  ip cam 啟動
        private void video_Load(object sender, EventArgs e)
        {

            core = new VideoCaptureCore(videoCapture1 as IVideoView);
        }
        #endregion

        #region Gripper_Arduino_socket_open
        private void Gripper_Arduino_socket_open()
        {
            Socket client_Gripper_ArduinoSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client_Gripper_ArduinoSocket.Connect(new IPEndPoint(IPAddress.Parse(Gripper_Arduino_IP), 7000));

            //open gripper send msg
            string Gripper_msg = "1"; //1是開
            byte[] Gripper_data = System.Text.Encoding.UTF8.GetBytes(Gripper_msg); //轉換成為bytes陣列
            client_Gripper_ArduinoSocket.Send(Gripper_data);
            /*
            //receieve msg
            byte[] Gripper_recvBuffer = new byte[1024];
            int Gripper_recvRes = client_Gripper_ArduinoSocket.Receive(Gripper_recvBuffer);
            string Gripper_recvMsg = Encoding.UTF8.GetString(Gripper_recvBuffer, 0, Gripper_recvRes);
            State.Text = "State: " + Gripper_recvMsg;
            */
            State.Text = "State: Start Gripping";
            client_Gripper_ArduinoSocket.Close();
        }
        #endregion

        #region Gripper_Arduino_socket_close
        private void Gripper_Arduino_socket_close()
        {
            Socket client_Gripper_ArduinoSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client_Gripper_ArduinoSocket.Connect(new IPEndPoint(IPAddress.Parse(Gripper_Arduino_IP), 7000));

            //send_msg close gripper
            string Gripper_msg2 = "2"; //2是夾
            byte[] Gripper_data2 = System.Text.Encoding.UTF8.GetBytes(Gripper_msg2); //轉換成為bytes陣列
            client_Gripper_ArduinoSocket.Send(Gripper_data2);
            /*
            //receieve msg
            byte[] Gripper_recvBuffer2 = new byte[1024];
            int Gripper_recvRes2 = client_Gripper_ArduinoSocket.Receive(Gripper_recvBuffer2);
            string Gripper_recvMsg2 = Encoding.UTF8.GetString(Gripper_recvBuffer2, 0, Gripper_recvRes2);
            State.Text = "State: " + Gripper_recvMsg2;
            */
            // close socket
            State.Text = "State: Start Gripping";
            client_Gripper_ArduinoSocket.Close();
        }
        #endregion

        #region Python_socket
        private void Python_socket()
        {
            Socket clientPythonSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientPythonSocket.Connect(new IPEndPoint(IPAddress.Parse(Python_IP), 7000));

            //send msg
            string Pyhon_msg = "5";
            byte[] Python_data = System.Text.Encoding.UTF8.GetBytes(Pyhon_msg); //轉換成為bytes陣列
            clientPythonSocket.Send(Python_data);

            //receieve msg
            byte[] Python_recvBuffer = new byte[1024];
            int Python_recvRes = clientPythonSocket.Receive(Python_recvBuffer);
            string Python_recvMsg = Encoding.UTF8.GetString(Python_recvBuffer, 0, Python_recvRes);
            State.Text = "State: " + Python_recvMsg;

            // close socket
            clientPythonSocket.Close();
        }
        #endregion


        private async void btnConnect_Click(object sender, EventArgs e)
        {

            // ip cam 、RA605開關
            if (connectState)
            {
                //disconnect
                //serialPort1.Close();
                connectState = false;
                RA605.Close(RA605_ID);
                await core.StopAsync();
                btnConnect.Text = "Connect";
                State.Text = "State: Unworking";
            }
            else
            {
                //connect
                //serialPort1.Open();
                connectState = true;
                RA605_ID = RA605.Connect("192.168.0.3");
                await core.StartAsync();
                btnConnect.Text = "Disconnct";
                State.Text = "State: Recording";
            }


        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            // 呈現彈藥數
            Bullet_numbers = Bullet_numbers - 1;
            Bullets_Result.Text = "Number of Bullets：" + Bullet_numbers.ToString();
            State.Text = "State: Firing";
            if (Bullet_numbers == 0)
            {
                btnFire.Enabled = false;
            }

            // Fire_Arduino_socket 
            Socket client_Fire_Arduino_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client_Fire_Arduino_Socket.Connect(new IPEndPoint(IPAddress.Parse(Fire_Arduino_IP), 7000));

            //send msg
            string Fire_msg = "1";
            byte[] Fire_data = System.Text.Encoding.UTF8.GetBytes(Fire_msg); //轉換成為bytes陣列
            client_Fire_Arduino_Socket.Send(Fire_data);

            //receieve msg
            byte[] Fire_recvBuffer = new byte[1024];
            int Fire_recvRes = client_Fire_Arduino_Socket.Receive(Fire_recvBuffer);
            string Fire_recvMsg = Encoding.UTF8.GetString(Fire_recvBuffer, 0, Fire_recvRes);
            State.Text = "State: " + Fire_recvMsg;

            // close socket
            client_Fire_Arduino_Socket.Close();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            // 呈現數量標籤
            Bullet_numbers = 15;
            Bullets_Result.Text = "Number of Bullets：" + Bullet_numbers.ToString();
            btnFire.Enabled = true;

            // 機械手臂(打開馬達)
            int state = btnReload.Enabled ? 1 : 0;
            RA605.set_motor_state(RA605_ID, state);
            Thread.Sleep(1000);
            RA605.set_override_ratio(RA605_ID, 100);

            //先移動機械手臂到機匣蓋
            double[] pos_2 = { -87.729, 0, 0, 0, -90, 0 };//夾取彈鏈_1
            double[] pos_3_1 = { -87.729, 0, 0, 0, -90, 0 };//夾取彈鏈_1
            double[] pos_3_2 = { -85.462, -81.176, 65.349, 0, -90, 0 };//夾取彈鏈_2
            RA605.ptp_axis(RA605_ID, pos_2);
            Thread.Sleep(100);
            RA605.ptp_axis(RA605_ID, pos_3_1);
            Thread.Sleep(100);
            Gripper_Arduino_socket_open();
            RA605.ptp_axis(RA605_ID, pos_3_2);
            Thread.Sleep(15000);          
            Gripper_Arduino_socket_close();
            Thread.Sleep(500);

            //移動機械手臂到舊彈鏈區
            double[] pos_3_3 = { -87.729, 0, 0, 0, -90, 0 };//夾取彈鏈_3
            double[] pos_3_4 = { -145.271, -29.45, 18.97, 0, -84.81, 0 };//夾取彈鏈_4
            double[] pos_4_1 = { -137.458, -75.482, 35.37, 0, -54.363, -40.331 };//到舊彈鏈區放彈鏈
            RA605.ptp_axis(RA605_ID, pos_3_3);
            Thread.Sleep(300);
            RA605.ptp_axis(RA605_ID, pos_3_4);
            Thread.Sleep(100);
            RA605.ptp_axis(RA605_ID, pos_4_1);
            Thread.Sleep(22000);
            Gripper_Arduino_socket_open();

            //手臂到新彈鏈區

            //Python_socket();

            // 手臂下去，夾新彈鏈
            double[] pos_4_2 = { -158.298, -64.646, 17.93, 0, -48.106, -65.749 };//到新彈鏈區夾彈鏈
            double[] pos_4_3 = { -158.298, -69.112, 17.93, 0, -48.106, -65.749 };//到新彈鏈區夾彈鏈
            Gripper_Arduino_socket_open();
            Thread.Sleep(1000);
            RA605.ptp_axis(RA605_ID, pos_4_2);
            Thread.Sleep(100);
            RA605.ptp_axis(RA605_ID, pos_4_3);
            Thread.Sleep(5000);
            Gripper_Arduino_socket_close();

            //手臂到機槍上
            double[] pos_5_1 = { -145.271, -29.45, 18.97, 0, -84.81, 0 };//放回彈鏈_1
            double[] pos_5_2 = { -87.729, 0, 0, 0, -90, 0 };//放回彈鏈_2
            double[] pos_5_3 = { -85.462, -81.176, 65.349, 0, -90, 0   };//放回彈鏈_3
            RA605.ptp_axis(RA605_ID, pos_5_1);
            Thread.Sleep(100);
            RA605.ptp_axis(RA605_ID, pos_5_2);
            Thread.Sleep(100);
            RA605.ptp_axis(RA605_ID, pos_5_3);
            Thread.Sleep(24000);
            Gripper_Arduino_socket_open();
            //Thread.Sleep(1750);

            // 拉拉柄
            double[] pos_5_4 = { -96.294, -32.407, 9.161, 0, -57.206, -83.203 };//拉拉柄_1
            double[] pos_6 = { -96.294, -57.091, 9.161, 0, -57.206, -83.203 };//拉拉柄_1
            double[] pos_6_1 = { -96.294, -59.117, 14.995, 0, -57.206, -83.203 };//拉拉柄_1
            double[] pos_6_2 = { -98.871, -59.117, 14.995, 0, -57.206, -83.203 };//拉拉柄_2
            RA605.ptp_axis(RA605_ID, pos_5_4);
            Thread.Sleep(100);
            //Gripper_Arduino_socket_close();
            //Thread.Sleep(4500);
            //RA605.ptp_axis(RA605_ID, pos_6);
            //Thread.Sleep(100);
            RA605.ptp_axis(RA605_ID, pos_6_1);
            Thread.Sleep(6500);
            Gripper_Arduino_socket_close();
            Thread.Sleep(500);
            //Gripper_Arduino_socket_close();
            //Thread.Sleep(1000);
            RA605.ptp_axis(RA605_ID, pos_6_2);
            Thread.Sleep(100);
            Gripper_Arduino_socket_open();
            Thread.Sleep(1750);

            //回到原點
            double[] pos_7_1 = { -87.729, 0, 0, 0, -90, 0 };//回到原點_1
            double[] pos_7_2 = { 0, 0, 0, 0, -90, 0 };//回到原點_2
            Gripper_Arduino_socket_close();
            RA605.ptp_axis(RA605_ID, pos_7_1);
            Thread.Sleep(300);
            RA605.ptp_axis(RA605_ID, pos_7_2);
        }
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            RA605.jog_stop(RA605_ID);
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            RA605.set_ptp_speed(RA605_ID, 100);
            double[] pos = { 0, 0, 0, 0, -90, 0 };
            RA605.ptp_axis(RA605_ID, pos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gripper_Arduino_socket_open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gripper_Arduino_socket_close();
        }
    }
}


