using Conspiration.NetzwerkLib;

using Network;
using Network.Enums;

using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Conspiratio.Server
{
    public partial class frmMain : Form
    {
        #region Variablen

        private Netzwerk oNetzwerk = new Netzwerk();
        private ServerConnectionContainer oServerConnectionContainer = null;
        private StringBuilder oStringBuilderLog = new StringBuilder("");

        private delegate void LogSetzenCallback(string sText);

        #endregion


        #region frmMain
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region frmMain_Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Werte für den Server auslesen und setzen
                txtHostname.Text = Dns.GetHostName();
                txtServerIP.Text = oNetzwerk.LokaleIPAdresseErmitteln();
                txtPort.Text = oNetzwerk.StandardPort.ToString();
            }
            catch (Exception ex)
            {
                oStringBuilderLog.Append("Fehler bei der Initialisierung: " + ex.Message + Environment.NewLine);
                LogSetzen(oStringBuilderLog.ToString());
            }
        }
        #endregion

        #region btnProgrammBeenden_Click
        private void btnProgrammBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region btnStarten_Click
        private void btnStarten_Click(object sender, EventArgs e)
        {
            try
            {
                if (oServerConnectionContainer == null)
                {
                    // Server erstellen, wenn noch nicht vorhanden
                    oServerConnectionContainer = ConnectionFactory.CreateServerConnectionContainer(txtServerIP.Text, Convert.ToInt32(txtPort.Text), false);   // Auf dem angegebenen Port lauschen
                    oServerConnectionContainer.AllowBluetoothConnections = false;
                    oServerConnectionContainer.AllowUDPConnections = false;

                    oServerConnectionContainer.ConnectionLost += ServerConnectionContainer_ConnectionLost;
                    oServerConnectionContainer.ConnectionEstablished += ServerConnectionContainer_ConnectionEstablished;

                    txtPort.Enabled = false;   // Eine Änderung des Ports ist während der Runtime nicht möglich
                }

                oServerConnectionContainer.StartTCPListener();

                oStringBuilderLog.Append(string.Format("Server wurde gestartet (Port {0}).{1}",
                                                       txtPort.Text, Environment.NewLine));
                LogSetzen(oStringBuilderLog.ToString());
            }
            catch (Exception ex)
            {
                oStringBuilderLog.Append("Fehler beim Starten des Servers: " + ex.Message + Environment.NewLine);
                LogSetzen(oStringBuilderLog.ToString());
            }
        }
        #endregion

        #region btnStoppen_Click
        private void btnStoppen_Click(object sender, EventArgs e)
        {
            try
            {
                oServerConnectionContainer.CloseConnections(Network.Enums.CloseReason.ServerClosed);
                oServerConnectionContainer.CloseTCPConnections(Network.Enums.CloseReason.ServerClosed);
                // oServerConnectionContainer.StopTCPListener();  // führt zu einer Exception

                oStringBuilderLog.Append(string.Format("Server wurde gestoppt.{0}", Environment.NewLine));
                LogSetzen(oStringBuilderLog.ToString());
            }
            catch (Exception ex)
            {
                oStringBuilderLog.Append("Fehler beim Stoppen des Servers: " + ex.Message + Environment.NewLine);
                LogSetzen(oStringBuilderLog.ToString());
            }

        }
        #endregion


        #region ServerConnectionContainer_ConnectionEstablished
        /// <summary>
        /// We got a connection.
        /// </summary>
        /// <param name="connection">The connection we got. (TCP or UDP)</param>
        private void ServerConnectionContainer_ConnectionEstablished(Connection connection, ConnectionType type)
        {
            oStringBuilderLog.Append(string.Format("{0}. {1} (IP: {2}) verbunden auf Port {3}.{4}",
                                                   oServerConnectionContainer.Count, connection.GetType(), connection.IPLocalEndPoint.Address.ToString(),
                                                   connection.IPRemoteEndPoint.Port, Environment.NewLine));
            LogSetzen(oStringBuilderLog.ToString());

            //3. Register packet listeners.
            // connection.RegisterStaticPacketHandler<CalculationRequest>(calculationReceived);
        }
        #endregion

        #region ServerConnectionContainer_ConnectionLost
        private void ServerConnectionContainer_ConnectionLost(Connection connection, ConnectionType connectionType, Network.Enums.CloseReason closeReason)
        {
            oStringBuilderLog.Append(string.Format("Verbindung {0} ({1}) wurde getrennt. Grund: {2}{3}",
                                                   connection.IPRemoteEndPoint, connectionType.ToString(), closeReason.ToString(), Environment.NewLine));
            LogSetzen(oStringBuilderLog.ToString());
        }

        #endregion


        #region LogSetzen
        private void LogSetzen(string sText)
        {
            if (this.txtLog.InvokeRequired)
            {
                LogSetzenCallback d = new LogSetzenCallback(LogSetzen);
                this.Invoke(d, new object[] { sText });
            }
            else
            {
                this.txtLog.Text = sText;
            }
        }
        #endregion
    }
}